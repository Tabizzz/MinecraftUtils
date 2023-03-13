using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.Bukkit;
using Serilog;
using Serilog.Events;
using TextureGenerator;
using YamlDotNet.Serialization;

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Information()
	.WriteTo.Console(LogEventLevel.Verbose, "[{Timestamp:HH:mm:ss} {Level:u4}] {Message:lj}{NewLine}{Exception}")
	.CreateLogger();

var yamlDeserializer = new DeserializerBuilder().Build();

var modelsPerMaterial = new Dictionary<Material, JObject>();

var allItems = Directory.EnumerateFiles("Items", "*.yml", SearchOption.AllDirectories)
	.Select(item => new Item()
	{
		Path = item,
		Name = Path.ChangeExtension(Path.GetRelativePath("Items", item), null)
	}).ToList();

foreach (var item in allItems)
{
	Log.Verbose("Found item file: {File}", item.Path);
	var texturePath = Path.ChangeExtension(Path.Combine("textures", item.Name), "png");
	var modelPath = Path.ChangeExtension(Path.Combine("models", item.Name), "json");

	if (File.Exists(texturePath))
	{
		item.Texture = texturePath;
		Log.Information("Found texture for item {Item} at {Path}", item.Name, item.Texture);
	}
	if (File.Exists(modelPath))
	{
		item.Model = modelPath;
		Log.Information("Found model for item {Item} at {Path}", item.Name, item.Model);
	}
}

allItems = allItems.Where(item => !string.IsNullOrWhiteSpace(item.Texture) || !string.IsNullOrWhiteSpace(item.Model)).ToList();

foreach (var item in allItems.ToList())
{
	using var reader = File.OpenText(item.Path);
	item.Data = yamlDeserializer.Deserialize<Dictionary<string, object>>(reader);

	var material = item.Data["material"].ToString()?.ToUpper();
	Material mat;
	try
	{
		item.Data["material"] = mat = Enum.Parse<Material>(material ?? "");
	}
	catch (Exception e)
	{
		Log.Error("Invalid material {Material}", material);
		continue;
	}

	if (item.Data.ContainsKey("model") &&
	    item.Data["model"] is string modelstr &&
	    int.TryParse(modelstr, out var model))
	{
		item.Data["model"] = model;
		var flag = true;
		if (mat == Material.BOW)
		{
			for (var i = 0; i < 3; i++)
			{
				if (!File.Exists(Path.ChangeExtension(Path.Combine("textures", item.Name + "_" + i), "png")))
				{
					Log.Warning("Bow item {Item} must have pulling textures", item.Name);
					flag = false;
					break;
				}
			}
		}
		if (flag) GenerateForItem(item);
	}
	else
	{
		Log.Warning("Item {Item} dont have a custom model data, ignoring", item.Name);
	}
}

foreach (var model in modelsPerMaterial)
{
	var folder = Path.Combine("pack/assets", "minecraft", "models", "item");
	var path = Path.Combine(folder, Path.ChangeExtension(model.Key.ToString().ToLower(), "json"));
	Log.Information("Saving model for {Material} in {Path}", model.Key, path);

	var json = JsonConvert.SerializeObject(model.Value);

	Directory.CreateDirectory(folder);
	File.WriteAllText(path, json);
}

ZipUtils.CompressTo("pack", "pack.zip");

Log.CloseAndFlush();


void GenerateForItem(Item item)
{
	if (item is { Texture: { } texture, Model: null } && item.Data["material"] is Material material)
	{
		// add override to material model
		ModelUtils.AddOverrides(item, material, modelsPerMaterial);

		// save model generated for this
		ModelUtils.GenerateModel(item, material);

		// save texture
		TextureUtils.CopyTextures(item, material);
	}
}
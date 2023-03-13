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

var clearDirs = new[]
{
	"pack/assets/minecraft/models",
	"pack/assets/minecraft/textures",
	"pack/assets/minecraft/optifine",
};

RemovePreviusDirs(clearDirs);

allItems = FilterAllItems(allItems);

allItems = GenerateModelForAllItems(allItems, yamlDeserializer, modelsPerMaterial);

WriteModelPerMaterial(modelsPerMaterial);

ZipUtils.CompressTo("pack", "pack.zip");

Log.CloseAndFlush();

void RemovePreviusDirs(IEnumerable<string> strings)
{
	foreach (var dir in strings)
	{
		if (Directory.Exists(dir))
			Directory.Delete(dir, true);
	}
}

List<Item> FilterAllItems(List<Item> items)
{
	foreach (var item in items)
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

	items = items.Where(item => !string.IsNullOrWhiteSpace(item.Texture) || !string.IsNullOrWhiteSpace(item.Model)).ToList();
	return items;
}

void GenerateForItem(Item item, Dictionary<Material, JObject> dictionary)
{
	if (item is { Texture: { }, Model: null } && item.Data["material"] is Material material)
	{
		// add override to material model
		ModelUtils.AddOverrides(item, material, dictionary);

		// save model generated for this
		ModelUtils.GenerateModel(item, material);

		// save texture
		TextureUtils.CopyTextures(item, material);
	}
}

List<Item> GenerateModelForAllItems(List<Item> list, IDeserializer deserializer, Dictionary<Material, JObject> dictionary)
{
	return list.Where(item =>
	{
		using var reader = File.OpenText(item.Path);
		item.Data = deserializer.Deserialize<Dictionary<string, object>>(reader);

		var material = item.Data["material"].ToString()?.ToUpper();
		try
		{
			item.Material = Enum.Parse<Material>(material ?? "");
			item.Data["material"] = item.Material;
		}
		catch (Exception)
		{
			Log.Error("Invalid material {Material}", material);
			return false;
		}

		if (item.Data.ContainsKey("model") &&
		    item.Data["model"] is string modelstr &&
		    int.TryParse(modelstr, out var model))
		{
			item.Data["model"] = model;
			var flag = true;
			if (item.Material == Material.BOW)
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
			if (flag)
			{
				GenerateForItem(item, dictionary);
				return true;
			}
		}
		else
		{
			Log.Warning("Item {Item} dont have a custom model data, ignoring", item.Name);
		}
		return false;
	}).ToList();

}

void WriteModelPerMaterial(Dictionary<Material, JObject> modelsPerMaterial1)
{
	foreach (var model in modelsPerMaterial1)
	{
		var folder = Path.Combine("pack/assets", "minecraft", "models", "item");
		var path = Path.Combine(folder, Path.ChangeExtension(model.Key.ToString().ToLower(), "json"));
		Log.Information("Saving model for {Material} in {Path}", model.Key, path);

		var json = JsonConvert.SerializeObject(model.Value);

		Directory.CreateDirectory(folder);
		File.WriteAllText(path, json);
	}
}
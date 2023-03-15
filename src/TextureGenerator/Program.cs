using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.Bukkit;
using Serilog;
using Serilog.Events;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using TextureGenerator;
using YamlDotNet.Serialization;

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Verbose()
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

var armorSets = new Dictionary<string, Item>();

var clearDirs = new[]
{
	"pack/assets/minecraft/models",
	"pack/assets/minecraft/textures",
	"pack/assets/minecraft/optifine",
};

RemovePreviusDirs(clearDirs);

CopyDefaultModelsAndTextures();

allItems = FilterAllItems(allItems);

allItems = GenerateModelForAllItems(allItems, yamlDeserializer, modelsPerMaterial);

WriteModelPerMaterial(modelsPerMaterial);

LoadArmors(allItems, armorSets);

GenerateShaderCompatibleArmor(armorSets);

ZipUtils.CompressTo("pack", "pack.zip");
Log.CloseAndFlush();

void CopyDefaultModelsAndTextures()
{
	if(Directory.Exists("models/default"))
		ZipUtils.CopyDirectory("models/default", "pack/assets/minecraft/models", true);
	if(Directory.Exists("textures/default"))
		ZipUtils.CopyDirectory("textures/default", "pack/assets/minecraft/textures", true);
}

void GenerateShaderCompatibleArmor(Dictionary<string, Item> armors)
{
	using var image1 = new Image<Rgba32>(64 * (1 + armors.Count), 32);
	using var image2 = new Image<Rgba32>(64 * (1 + armors.Count), 32);
	var armorsPath = "textures/models/armor";
	var targetArmorPaths = Path.Combine("pack/assets/minecraft", armorsPath);
	var llayer1 = Path.Combine(targetArmorPaths, "leather_layer_1.png");
	var llayer2 = Path.Combine(targetArmorPaths, "leather_layer_2.png");

	var origin = 1;

	using (var leather1 = Image.Load<Rgba32>(Path.Combine(armorsPath, "leather_layer_1.png")))
	{
		leather1.Mutate(o => o.Resize(64, 32, KnownResamplers.NearestNeighbor));
		image1.Mutate(o => o.DrawImage(leather1, new Point(0, 0), 1f));
	}
	image1[0, 1] = new(255, 255, 255, 255);
	
	using (var leather2 = Image.Load<Rgba32>(Path.Combine(armorsPath, "leather_layer_2.png")))
	{
		leather2.Mutate(o => o.Resize(64, 32, KnownResamplers.NearestNeighbor));
		image2.Mutate(o => o.DrawImage(leather2, new Point(0, 0), 1f));
	}
	image2[0, 1] = new(255, 255, 255, 255);

	foreach (var armor in armors)
	{
		var color = (Rgba32)armor.Value.Data["color"];
		using (var layer1 = Image.Load<Rgba32>(armor.Value.Texture!))
		{
			layer1.Mutate(o => o.Resize(64, 32, KnownResamplers.NearestNeighbor));
			image1.Mutate(o => o.DrawImage(layer1, new Point(64 * origin, 0), 1f));
		}
		using (var layer2 = Image.Load<Rgba32>(armor.Value.Model!))
		{
			layer2.Mutate(o => o.Resize(64, 32, KnownResamplers.NearestNeighbor));
			image2.Mutate(o => o.DrawImage(layer2, new Point(64 * origin, 0), 1f));
		}
		
		image1[origin * 64, 0] = color;
		image2[origin * 64, 0] = color;

		origin++;
	}

	image1.SaveAsPng(llayer1);
	image2.SaveAsPng(llayer2);
}

void LoadArmors(List<Item> items, Dictionary<string, Item> armors)
{
	var armorsPath = "textures/models/armor";
	var targetArmorPaths = Path.Combine("pack/assets/minecraft", armorsPath);
	var optifineCits = "pack/assets/minecraft/optifine/cit/armors";
	if (!Directory.Exists(armorsPath))
	{
		Log.Warning("Not generating custom armor sets: directory {Dir} not exists", armorsPath);
		return;
	}

	// check vanilla overlays
	var toCheck = new[]
	{
		"leather_layer_1_overlay.png",
		"leather_layer_1.png",
		"leather_layer_2_overlay.png",
		"leather_layer_2.png"
	};

	foreach (var van in toCheck)
	{
		if (File.Exists(Path.Combine(armorsPath, van)))
			continue;
		Log.Warning("Not generating custom armor sets: File {File} not found on {Dir}", van, armorsPath);
		return;
	}

	// ensure output dir exisst
	Directory.CreateDirectory(targetArmorPaths);
	Directory.CreateDirectory(optifineCits);

	CreateVanillaCit(optifineCits, armorsPath);
	File.Copy(Path.Combine(armorsPath, "leather_layer_1_overlay.png"), Path.Combine(targetArmorPaths, "leather_layer_1_overlay.png"), true);
	File.Copy(Path.Combine(armorsPath, "leather_layer_1_overlay.png"), Path.Combine(targetArmorPaths, "leather_layer_2_overlay.png"), true);

	foreach (var item in items.Where(item => item.Material.IsLeatherArmor()))
	{
		var setName = item.Name.Split("_")[^1];
		var model = (int)item.Data["model"];
		if (armors.ContainsKey(setName)) continue;
		var set = new Item()
		{
			Name = setName,
			Path = setName
		};
		var color = item.Data["color"]?.ToString();
		var colori = uint.Parse(color!);

		byte r = (byte)((colori >> 16) & 0xff);
		byte g = (byte)((colori >> 8) & 0xff);
		byte b = (byte)((colori >> 0) & 0xff);

		var rgba = new Rgba32(r, g, b);
		Log.Information("Found armor set {Set} with color {Color} on item {Item}", setName, rgba, item.Name);
		set.Data["color"] = rgba;
		if (armors.Values.FirstOrDefault(s => s.Data["color"] is Rgba32 c && c == rgba) is { } other)
		{
			Log.Warning("Armor set {Set} have a color {Color} already asigned to set {Other}", setName, rgba, other.Name);
			continue;
		}

		armors.Add(setName, set);
		var layer_1 = Path.Combine(armorsPath, setName + "_layer_1.png");
		var layer_2 = Path.Combine(armorsPath, setName + "_layer_2.png");
		if (!File.Exists(layer_1))
		{
			Log.Warning("Unable to generate armor set {Set}, expected layer_1 texture not found in {Path}", setName, layer_1);
			continue;
		}
		set.Texture = layer_1;
		if (!File.Exists(layer_2))
		{
			Log.Warning("Unable to generate armor set {Set}, expected layer_2 texture not found in {Path}", setName, layer_2);
			continue;
		}
		set.Model = layer_2;

		CreateCit(set, model, optifineCits, armorsPath);

	}
}

void CreateCit(Item set, int model, string cit, string armorsPath)
{
	var path = Path.Combine(cit, set.Name);
	Directory.CreateDirectory(path);
	Log.Verbose("Creating {Set} cit at {Path}", set.Name, path);
	File.Copy(Path.Combine(armorsPath, set.Name + "_layer_1.png"), Path.Combine(path, set.Name + "_layer_1.png"), true);
	File.Copy(Path.Combine(armorsPath, set.Name + "_layer_2.png"), Path.Combine(path, set.Name + "_layer_2.png"), true);

	var props = Path.Combine(path, set.Name + ".properties");
	Log.Verbose("Writing {Set} cit properties in {Path}", set.Name, props);
	File.WriteAllText(props,
		$"""
type=armor
items=minecraft:leather_helmet minecraft:leather_chestplate minecraft:leather_leggings minecraft:leather_boots
texture.leather_layer_1={set.Name}_layer_1.png
texture.leather_layer_1_overlay={set.Name}_layer_1.png
texture.leather_layer_2={set.Name}_layer_2.png
texture.leather_layer_2_overlay={set.Name}_layer_2.png
nbt.CustomModelData={model}
weight=1
""");
}

void CreateVanillaCit(string cit, string armorsPath)
{
	var path = Path.Combine(cit, "leather");
	Directory.CreateDirectory(path);
	Log.Verbose("Creating vanilla cit at {Path}", path);
	File.Copy(Path.Combine(armorsPath, "leather_layer_1_overlay.png"), Path.Combine(path, "leather_layer_overlay.png"), true);
	File.Copy(Path.Combine(armorsPath, "leather_layer_1.png"), Path.Combine(path, "leather_layer_1.png"), true);
	File.Copy(Path.Combine(armorsPath, "leather_layer_2.png"), Path.Combine(path, "leather_layer_2.png"), true);

	var props = Path.Combine(path, "leather.properties");
	Log.Verbose("Writing {Set} cit properties in {Path}", "leather", props);
	File.WriteAllText(props,
		"""
type=armor
items=minecraft:leather_helmet minecraft:leather_chestplate minecraft:leather_leggings minecraft:leather_boots
texture.leather_layer_1=leather_layer_1.png
texture.leather_layer_1_overlay=leather_overlay.png
texture.leather_layer_2=leather_layer_2.png
texture.leather_layer_2_overlay=leather_overlay.png

weight=0
""");
}

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
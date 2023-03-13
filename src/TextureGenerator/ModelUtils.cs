using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.Bukkit;
using Serilog;

namespace TextureGenerator;

public static class ModelUtils
{
	public static JObject GetOrCreateModel(Material material, Dictionary<Material, JObject> modelsPerMaterial)
	{
		var jobj = new JObject();
		if (modelsPerMaterial.TryGetValue(material, out var value))
		{
			return value;
		}

		var parent = material.DefaultParentModel();
		if (parent != null)
			jobj["parent"] = parent;

		var textures = new JObject
		{
			["layer0"] = "item/" + material.ToString().ToLower()
		};
		jobj["textures"] = textures;

		if (material == Material.BOW)
		{
			jobj["display"] = JsonConvert.DeserializeObject<JObject>(Json.BowDisplay);
			jobj["overrides"] = JsonConvert.DeserializeObject<JArray>(Json.BowPulling);
		}

		modelsPerMaterial.Add(material, jobj);
		return jobj;
	}

	public static void AddOverrides(Item item, Material material, Dictionary<Material, JObject> modelsPerMaterial)
	{
		var materialmodel = ModelUtils.GetOrCreateModel(material, modelsPerMaterial);
		var overrides = materialmodel["overrides"] as JArray ?? new JArray();

		Log.Verbose("Generating overrides for {Item} in {Material}", item.Name, material);
		
		overrides.Add(new JObject
		{
			["model"] = item.Name,
			["predicate"] = new JObject
			{
				["custom_model_data"] = (int)item.Data["model"]
			}
		});

		if (material == Material.BOW)
		{
			overrides.Add(new JObject
			{
				["model"] = item.Name + "_0",
				["predicate"] = new JObject
				{
					["pulling"] = 1,
					["custom_model_data"] = (int)item.Data["model"]
				}
			});
			overrides.Add(new JObject
			{
				["model"] = item.Name + "_1",
				["predicate"] = new JObject
				{
					["pulling"] = 1,
					["custom_model_data"] = (int)item.Data["model"],
					["pull"] = 0.65
				}
			});
			overrides.Add(new JObject
			{
				["model"] = item.Name + "_2",
				["predicate"] = new JObject
				{
					["pulling"] = 1,
					["custom_model_data"] = (int)item.Data["model"],
					["pull"] = 0.9
				}
			});
		}
		materialmodel["overrides"] ??= overrides;
	}

	public static void GenerateModel(Item item, Material material)
	{
		var model = new JObject()
		{
			["parent"] = material == Material.BOW ? "item/bow" : material.DefaultParentModel(),
			["textures"] = new JObject
			{
				["layer0"] = item.Name
			}
		};
		
		var folder = Path.Combine("pack", "assets", "minecraft", "models");
		var path = Path.Combine(folder, Path.ChangeExtension(item.Name, "json"));
		var dir = Path.GetDirectoryName(path);
		Log.Information("Saving model for {Item} in {Path}", item.Name, path);
		var json = JsonConvert.SerializeObject(model);
		Directory.CreateDirectory(dir!);
		File.WriteAllText(path, json);

		if (material == Material.BOW)
		{
			Log.Information("Saving bow models for {Item} in {Path}", item.Name, dir);

			for (int i = 0; i < 3; i++)
			{
				path = Path.Combine(folder, Path.ChangeExtension(item.Name + "_" + i, "json"));
				var pull = JsonConvert.SerializeObject(new JObject()
				{
					["parent"] = "item/bow",
					["textures"] = new JObject
					{
						["layer0"] = item.Name + "_" + i
					}
				});
				Directory.CreateDirectory(dir!);
				File.WriteAllText(path, pull);
			}
		}
	}
}
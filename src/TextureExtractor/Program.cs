// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.Bukkit;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
	.WriteTo.Console(LogEventLevel.Warning)
	.CreateLogger();

Log.Information("Extraction textures from models!");
	
var dir = new DirectoryInfo("models/item");
var outdir = new DirectoryInfo("out");
var files = dir.EnumerateFiles();

var materials = Enum.GetValues<Material>().Select(m => m.ToString().ToLower()).ToList();

foreach (var file in files)
{
	var name = file.Name.Replace(file.Extension, "");
	if (materials.Contains(name))
	{
		Log.Information("Getting related models for: {Model}", name);
		using var jfile = file.OpenText();
		var content = jfile.ReadToEnd();
		var jobj = JsonConvert.DeserializeObject<JObject>(content) ?? new ();
		var overrides = jobj["overrides"] as JArray;
		var i = 0;
		foreach (var elem in overrides!)
		{
			var fmodel = Path.Combine("models", elem["model"] + ".json");
			if (File.Exists(fmodel))
			{
				Log.Information("Inspecting {Model}", elem["model"]?.ToString());
				loadModel(fmodel, name, ref i);
			}
			else
			{
				Log.Warning("Model {Model} nor found", elem["model"]?.ToString());
			}
		}
	}
}

// Finally, once just before the application exits...
Log.CloseAndFlush();

void loadModel(string s, string name, ref int i)
{
	var content = File.ReadAllText(s);
	var jobj = JsonConvert.DeserializeObject<JObject>(content) ?? new ();
	var textures = jobj["textures"] as JObject ?? new();

	foreach (var texture in textures)
	{
		var ftex = Path.Combine("textures", texture.Value + ".png");
		if (File.Exists(ftex))
		{
			Log.Information("Moving Texture {Tex}", texture.Value?.ToString());
			Directory.CreateDirectory(Path.Combine("out", "textures", name));
			File.Copy(ftex, Path.Combine("out", "textures", name, $"{name}_{i++}.png"), true);
		}
		else
		{
			Log.Warning("Texture {Text} not found", texture.Value?.ToString() );
		}
	}
}
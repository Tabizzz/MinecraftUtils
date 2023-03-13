
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.Bukkit;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Verbose()
	.WriteTo.Console(LogEventLevel.Verbose, "[{Timestamp:HH:mm:ss} {Level:u4}] {Message:lj}{NewLine}{Exception}")
	.CreateLogger();

var allFiles = Directory.EnumerateFiles("item", "*.json");

var groups = allFiles.Select(file =>
{
	var content = File.ReadAllText(file);
	var jobj = JsonConvert.DeserializeObject<JObject>(content) ?? new JObject();
	
	jobj["material"] = Path.ChangeExtension(Path.GetRelativePath("item", file), null).ToUpper();
	return jobj;
}).GroupBy(model => model?["parent"]?.ToString());

var builder = new StringBuilder();

foreach (var group in groups)
{
	Log.Warning("Items with Parent {Parent}", group.Key);
	foreach (var item in group)
	{
		var material = item["material"]?.ToString() ?? "";
		try
		{
			Enum.Parse<Material>(material);
			Log.Information("{Item}", item["material"]?.ToString());
			builder.Append("case Material." + material + ":\n");
		}
		catch (Exception e)
		{
			// ignored
		}
	}
	if(group.Key is not  null)
		builder.Append($"\treturn \"{group.Key}\";\n");
	else
		builder.Append($"\treturn null;\n");
}

File.WriteAllText("out.txt", builder.ToString());

Log.CloseAndFlush();
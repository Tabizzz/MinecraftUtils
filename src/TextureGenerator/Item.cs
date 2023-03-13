using Org.Bukkit;
namespace TextureGenerator;

public class Item
{
	public Material Material { get; set; }

	public required string Path { get; init; }

	public required string Name { get; init; }

	public string? Texture { get; set; }

	public string? Model { get; set; }

	public Dictionary<string, object> Data { get; set; } = new();
}
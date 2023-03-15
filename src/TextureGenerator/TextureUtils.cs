using Org.Bukkit;
using Serilog;

namespace TextureGenerator;

public static class TextureUtils
{
	public static void CopyTextures(Item item, Material material)
	{
		var path = Path.Combine("pack", "assets", "minecraft", item.Texture!);
		var dir = Path.GetDirectoryName(path);
		Directory.CreateDirectory(dir!);
		Log.Verbose("Copying textures for {Item} in {Dir}", item.Name, dir);
		File.Copy(item.Texture!, Path.Combine("pack", "assets", "minecraft", item.Texture!), true);

		if (material == Material.BOW)
		{
			for (var i = 0; i < 3; i++)
			{
				var name = Path.ChangeExtension(item.Texture, null) + "_" + i;
				name = Path.ChangeExtension(name, "png");
				path = Path.Combine("pack", "assets", "minecraft", name);
				File.Copy(name, path, true);
			}
		}
	}
}
using System.IO.Compression;
using System.Text;
using Serilog;

public static class ZipUtils
{
	public static void CompressTo(string pack, string packZip)
	{
		Log.Information("Compresing texture pack into {File}", Path.GetFullPath(packZip));
		try
		{
			if (File.Exists(packZip)) {
				File.Delete(packZip);
			}
			ZipFile.CreateFromDirectory(pack, packZip, CompressionLevel.SmallestSize, false, Encoding.UTF8);
		}
		catch (Exception e)
		{
			Log.Error(e, "An error ocurred while compresing file");
		}
	}
}
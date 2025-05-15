namespace Imagine.Loaders;

public class RecursiveJpegDirectoryLoader : RecursiveDirectoryLoaderFiltered
{
    public RecursiveJpegDirectoryLoader(string path) : base(path, "*.jpeg")
    {

    }
}
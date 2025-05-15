namespace Imagine.Loaders;

public class RecursiveTifDirectoryLoader : RecursiveDirectoryLoaderFiltered
{
    public RecursiveTifDirectoryLoader(string path) : base(path, "*.tif")
    {

    }
}

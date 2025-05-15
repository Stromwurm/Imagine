namespace Imagine.Loaders;

public class RecursiveTiffDirectoryLoader : RecursiveDirectoryLoaderFiltered
{
    public RecursiveTiffDirectoryLoader(string path) : base(path, "*.tiff")
    {
        
    }
}

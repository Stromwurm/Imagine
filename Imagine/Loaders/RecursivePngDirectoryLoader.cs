namespace Imagine.Loaders;

public class RecursivePngDirectoryLoader : RecursiveDirectoryLoaderFiltered
{
    public RecursivePngDirectoryLoader(string path) : base(path, "*.png")
    {

    }
}

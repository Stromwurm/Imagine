namespace Imagine.Loaders;

public class RecursiveJpgDirectoryLoader : RecursiveDirectoryLoaderFiltered
{
    public RecursiveJpgDirectoryLoader(string path) : base(path, "*.jpg")
    {

    }
}

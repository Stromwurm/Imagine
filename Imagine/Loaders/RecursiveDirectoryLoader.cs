namespace Imagine.Loaders;

public class RecursiveDirectoryLoader : IDirectoryLoader
{
    private string _path = string.Empty;
    public string Path => _path;

    public RecursiveDirectoryLoader(string path)
    {
        _path = path;
    }

    public IEnumerable<string> GetFiles()
    {
        return Directory.GetFiles(_path, "*", SearchOption.AllDirectories);
    }
}

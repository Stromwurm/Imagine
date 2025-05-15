namespace Imagine.Loaders;

public class DirectoryLoader : IDirectoryLoader
{

    private string _path = string.Empty;
    public string Path => _path;

    public DirectoryLoader(string path)
    {
        _path = path;
    }

    public IEnumerable<string> GetFiles()
    {
        return Directory.GetFiles(Path);
    }
}

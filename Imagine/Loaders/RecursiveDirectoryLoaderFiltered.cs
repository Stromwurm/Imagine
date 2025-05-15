namespace Imagine.Loaders;

public class RecursiveDirectoryLoaderFiltered : IDirectoryLoader
{
    private string _path = string.Empty;
    public string Path => _path;

    private string[] _fileExtensions = [];

    public RecursiveDirectoryLoaderFiltered(string path, params string[] fileExtensions)
    {
        _path = path;
        _fileExtensions = fileExtensions;
    }

    public IEnumerable<string> GetFiles()
    {
        List<string> files = [];

        foreach (var item in _fileExtensions)
        {
            files.AddRange(Directory.GetFiles(_path, item, SearchOption.AllDirectories));
        }

        return files;
    }
}

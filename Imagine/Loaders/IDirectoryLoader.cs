namespace Imagine.Loaders
{
    public interface IDirectoryLoader
    {
        string Path { get; }

        IEnumerable<string> GetFiles();
    }
}
namespace Contracts
{
    public interface IDirectories
    {
        string OriginalFileDirectory { get; set; }
        string KeyFileDirectory { get; set; }
        string OutputFileDirectory { get; set; }
    }
}

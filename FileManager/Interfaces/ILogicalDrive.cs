using CloudFileManager.Common.FileSystem.Enumerations;

namespace CloudFileManager.Common.FileSystem.Interfaces
{
    public interface ILogicalDrive
    {
        string Name { get; set; }
        string Label { get; set; }
        long FreeSpace { get; set; }
        long TotalSpace { get; set; }
        FileSystemType FileSystemType { get; set; }
        IFileSystem FileSystem { get; set; }
    }
}
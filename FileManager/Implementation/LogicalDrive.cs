using CloudFileManager.Common.FileSystem.Enumerations;
using CloudFileManager.Common.FileSystem.Interfaces;

namespace CloudFileManager.Common.FileSystem.Implementation
{
    public class LogicalDrive : ILogicalDrive
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public long FreeSpace { get; set; }
        public long TotalSpace { get; set; }
        public FileSystemType FileSystemType { get; set; }
        public IFileSystem FileSystem { get; set; }
    }
}
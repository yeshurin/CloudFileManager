using System.Collections.Generic;
using System.IO;
using CloudFileManager.Common.FileSystem.Interfaces;

namespace CloudFileManager.Plugins.LocalFileSystem
{
    public class FileManagerFile : IFileSystemItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullPath => System.IO.Path.Combine(Drive.Name, Path);
        public long Size { get; set; }
        public ILogicalDrive Drive { get; set; }
        public void Copy(IFileSystemItem target)
        {
            File.Copy(FullPath, target.FullPath);
        }

        public void Move(IFileSystemItem target)
        {
            File.Move(FullPath, target.FullPath);
        }

        public void Delete()
        {
            File.Delete(FullPath);
        }

        public List<IFileSystemItem> Content { get; set; }
    }
}

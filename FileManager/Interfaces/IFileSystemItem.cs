using System.Collections.Generic;
using System.Net;

namespace CloudFileManager.Common.FileSystem.Interfaces
{
    public interface IFileSystemItem
    {
        string Name { get; set; }
        string Path { get; set; }
        string FullPath { get; }
        long Size { get; set; }
        ILogicalDrive Drive { get; set; }
        void Copy(IFileSystemItem target);
        void Move(IFileSystemItem target);
        void Delete();
        List<IFileSystemItem> Content { get; set; }
    }
}
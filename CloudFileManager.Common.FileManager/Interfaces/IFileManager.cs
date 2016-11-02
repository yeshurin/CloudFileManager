using System.Collections.Generic;
using CloudFileManager.Common.FileSystem.Interfaces;

namespace CloudFileManager.Common.FileManager.Interfaces
{
    public interface IFileManager
    {
        List<IFileSystemItem> GetContent(ILogicalDrive drive);
        List<IFileSystemItem> GetContent(ILogicalDrive drive, string directoryPath);
        void Copy(IFileSystemItem source, IFileSystemItem target);
        void Move(IFileSystemItem source, IFileSystemItem target);
        void Delete(IFileSystemItem target);
        void Create(IFileSystemItem target);
        List<IFileSystemItem> Search(string searchPattern);
    }
}

using System.Collections.Generic;
using CloudFileManager.Common.FileSystem.Enumerations;

namespace CloudFileManager.Common.FileSystem.Interfaces
{
    public interface IFileSystem
    {
        List<IFileSystemItem> GetContent(string directoryPath); 
        byte[] Read(string sourcePath); 
        void Write(string destinationPath, byte[] contentBytes); 
        void Delete(string targetPath); 
        void Create(string targetPath);
        void Create(string targetPath, byte[] contentBytes);
        void Copy(IFileSystemItem sourceItem, IFileSystemItem targetItem);
        void Move(IFileSystemItem sourceItem, IFileSystemItem targetItem);
        List<IFileSystemItem> Search(string searchPattern);
        FileSystemType FileSystemType { get; set; }
    }
}

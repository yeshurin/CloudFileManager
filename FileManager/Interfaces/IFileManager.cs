using System.Collections.Generic;
using FileManager.Interfaces;

namespace CloudFileManager.Common.FileManager.Interfaces
{
    public interface IFileManager
    {
        List<IFileManagerItem> GetContent(string directoryPath); //Add to Directory
        void Copy(string sourcePath, string destinationPath); //Add to IFileManagerItem
        void Move(string sourcePath, string destinationPath); //Add to IFileManagerItem
        void Delete(string targetPath); //Add to IFileManagerItem
        void Create(string targetPath); //Add to IFileManagerItem
        List<IFileManagerItem> Search(string searchPattern);
    }
}

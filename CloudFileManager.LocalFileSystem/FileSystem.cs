using System;
using System.Collections.Generic;
using CloudFileManager.Common.FileManager.Interfaces;
using FileManager.Interfaces;

namespace CloudFileManager.Plugins.LocalFileSystem
{
    public class FileSystem : IFileManager
    {
        public List<IFileManagerItem> GetContent(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public void Copy(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        public void Move(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        public void Delete(string targetPath)
        {
            throw new NotImplementedException();
        }

        public void Create(string targetPath)
        {
            throw new NotImplementedException();
        }

        public List<IFileManagerItem> Search(string searchPattern)
        {
            throw new NotImplementedException();
        }
    }
}

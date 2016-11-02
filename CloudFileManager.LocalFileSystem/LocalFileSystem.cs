using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CloudFileManager.Common.FileSystem.Enumerations;
using CloudFileManager.Common.FileSystem.Interfaces;

namespace CloudFileManager.Plugins.LocalFileSystem
{
    public class LocalFileSystem : IFileSystem
    {
        public void Write(string destinationPath, byte[] contentBytes)
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

        public void Create(string targetPath, byte[] contentBytes)
        {
            throw new NotImplementedException();
        }

        public void Copy(IFileSystemItem sourceItem, IFileSystemItem targetItem)
        {
            sourceItem.Copy(targetItem);
        }

        public void Move(IFileSystemItem sourceItem, IFileSystemItem targetItem)
        {
            sourceItem.Move(targetItem);
        }

        public List<IFileSystemItem> GetContent(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public byte[] Read(string sourcePath)
        {
            throw new NotImplementedException();
        }

        public List<IFileSystemItem> Search(string searchPattern)
        {
            throw new NotImplementedException();
        }

        public FileSystemType FileSystemType { get; set; }
    }
}

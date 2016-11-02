using System.Collections.Generic;
using CloudFileManager.Common.FileManager.Interfaces;
using CloudFileManager.Common.FileSystem.Interfaces;

namespace CloudFileManager.Common.FileManager.Implementation
{
    public abstract class FileManager : IFileManager
    {
        public abstract List<IFileSystemItem> GetContent(ILogicalDrive drive);

        public abstract List<IFileSystemItem> GetContent(ILogicalDrive drive, string directoryPath);

        public virtual void Copy(IFileSystemItem source, IFileSystemItem target)
        {
            if (source.Drive.FileSystemType.Equals(target.Drive.FileSystemType))
            {
                source.Copy(target);
            }
        }

        public virtual void Move(IFileSystemItem source, IFileSystemItem target)
        {
            if (source.Drive.FileSystemType.Equals(target.Drive.FileSystemType))
            {
                source.Move(target);
            }
        }

        public virtual void Delete(IFileSystemItem target)
        {
            target.Delete();
        }

        public void Create(IFileSystemItem target)
        {
            target.Drive.FileSystem.Create(target.FullPath);
        }

        public List<IFileSystemItem> Search(string searchPattern)
        {
            throw new System.NotImplementedException();
        }
    }
}
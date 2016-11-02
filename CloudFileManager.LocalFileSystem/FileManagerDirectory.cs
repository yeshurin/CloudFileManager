using System.Collections.Generic;
using System.IO;
using CloudFileManager.Common.FileSystem.Interfaces;

namespace CloudFileManager.Plugins.LocalFileSystem
{
    public class FileManagerDirectory : IFileSystemItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullPath => System.IO.Path.Combine(Drive.Name, Path);
        public long Size { get; set; }
        public ILogicalDrive Drive { get; set; }

        /// <summary>
        /// Copies entire directory with all contents to destination
        /// </summary>
        /// <param name="target"></param>
        public void Copy(IFileSystemItem target)
        {
            EnsureDirectoryExistance(target.FullPath);
        }

        /// <summary>
        /// Moves entire directory with all contents to destination
        /// </summary>
        /// <param name="target"></param>
        public void Move(IFileSystemItem target)
        {
            Directory.Move(FullPath, target.FullPath);
        }

        /// <summary>
        /// Deletes entrire directory with all it's contents
        /// </summary>
        public void Delete()
        {
            Directory.Delete(FullPath);
        }

        public List<IFileSystemItem> Content { get; set; }

        private void EnsureDirectoryExistance(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}

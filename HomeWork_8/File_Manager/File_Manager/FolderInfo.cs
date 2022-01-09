using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace File_Manager
{
    /// <summary>
    /// Информация о папке
    /// </summary>
    public class FolderInfo : Info
    {
        public int FilesNumberInFolder { get; set; }
        public int FolderNumber { get; set; }

        /// <summary>
        /// список файлов
        /// </summary>
        private List<FileInformation> _fileList;

        /// <summary>
        /// Список папок
        /// </summary>
        private List<FolderInfo> _foldersList;
        protected DirectoryInfo _directoryInfo;

        /// <summary>
        /// Узнаем размер папки
        /// </summary>
        /// <returns></returns>
        private long FolderSize()
        {
            long s = 0;

            if (_directoryInfo != null)
            {
                foreach (var item in _directoryInfo.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    s += item.Length;
                }
            }
            return s;
        }
        
        /// <summary>
        /// Информация о папке
        /// </summary>
        /// <param name="path">Путь к папке</param>
        /// <returns></returns>
        public FolderInfo Info(string path)
        {
            _directoryInfo = new DirectoryInfo(path);
            if (PresenceFolder(path))
            {
                return new FolderInfo
                {
                    Name = _directoryInfo.Name,
                    Location = _directoryInfo.FullName,
                    Size = FolderSize(),
                    CreateTime = _directoryInfo.CreationTime,
                    FilesNumberInFolder = _directoryInfo.GetFiles("*.*", SearchOption.AllDirectories).Length,
                    FolderNumber = _directoryInfo.GetDirectories("*.*", SearchOption.AllDirectories).Length
                };
            }
            return null;
        }

        /// <summary>
        /// Список файлов в папке
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<FileInformation> FilesInFoldersList(string path)
        {
            _directoryInfo = new DirectoryInfo(path);
            _fileList = new List<FileInformation>();
            if (PresenceFolder(path))
            {
                var filtered = FilteredFiles();
                foreach (var item in filtered)
                {
                    _fileList.Add(new FileInformation{ Name = item.Name, Extension = item.Extension});
                }
                return _fileList;
            }
            return null;
        }

        /// <summary>
        /// Список папок в папке
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<FolderInfo> FoldersList(string path)
        {
            _directoryInfo = new DirectoryInfo(path);
            _foldersList = new List<FolderInfo>();
            if (PresenceFolder(path))
            {
                var filtered = FilteredDirectory();
                foreach (var item in filtered)
                {
                   _foldersList.Add(new FolderInfo { Name = item.Name});
                }
                return _foldersList;
            }
            return null;
        }

        /// <summary>
        /// Фильтруем скрытые файлы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FileInfo> FilteredFiles()
        {
            return _directoryInfo.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
        }

        /// <summary>
        /// Фильтруем скрытые папки
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DirectoryInfo> FilteredDirectory()
        {
            return _directoryInfo.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
        }

        /// <summary>
        /// Проверка наличия папки
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool PresenceFolder(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            return false;
        }
    }
}

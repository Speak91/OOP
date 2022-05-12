using System.IO;
namespace File_Manager
{
    public sealed class FileOperation : FileInformation
    {
        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool DeleteFile (string path)
        {
            _file = new FileInfo(path);
            if (FileExists())
            {
                _file.Delete();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Копируем файл
        /// </summary>
        /// <param name="pathFrom"></param>
        /// <param name="pathTo"></param>
        /// <returns></returns>
        public bool CopyFile(string pathFrom, string pathTo)
        {
            FolderOperation folderOperation = new FolderOperation();
            _file = new FileInfo(pathFrom);

            if (FileExists() && folderOperation.PresenceFolder(pathTo))
            {
                string a = pathTo + '\\' +_file.Name;
                    File.Copy(pathFrom,a);
                    return true;
            }
            return false;
        }
       
    }

}

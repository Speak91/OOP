using System.IO;
namespace File_Manager
{
    /// <summary>
    /// Операции с файлом
    /// </summary>
    public sealed class FolderOperation : FolderInfo
    {
        public bool DeleteFolder(string path)
        {
            _directoryInfo = new DirectoryInfo(path);
            if (_directoryInfo.Exists)
            {
                _directoryInfo.Delete(true);
                return true;
            }
            return false;
        }
    }

}

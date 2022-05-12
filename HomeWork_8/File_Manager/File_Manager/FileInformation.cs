using System.IO;

namespace File_Manager
{
    public class FileInformation : Info
    {
        protected FileInfo _file;
        public FileInformation Info(string path)
        {
            _file = new FileInfo(path);
            if (FileExists())
            {
                return new FileInformation
                {
                    Name = _file.Name,
                    Location = _file.DirectoryName,
                    Size = _file.Length,
                    CreateTime = _file.CreationTime,
                    Extension = _file.Extension
                };
            }
            return null;
        }

        public bool FileExists()
        {
            if (_file.Exists)
            {
                return true;
            }
            return false;
        }
    }
}

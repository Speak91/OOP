using System;
using System.Collections.Generic;

namespace File_Manager
{
    /// <summary>
    /// Промежуточный класс выводящий информацию
    /// </summary>
    public class Print
    {
        private FolderInfo _folderInfo;
        private FileOperation _fileOperation;
        private List<FolderInfo> _foldersList;
        private FileInformation _fileInformation;
        private List<FileInformation> _filesList;
        private LogicalDiskInfo _logicalDiskInfo;
        private List<LogicalDiskInfo> _ld;
        private FolderOperation _folderOperation; 
        public Print()
        {
            _folderInfo = new FolderInfo();
            _foldersList = new List<FolderInfo>();
            _fileInformation = new FileInformation();
            _filesList = new List<FileInformation>();
            _ld = new List<LogicalDiskInfo>();
            _logicalDiskInfo = new LogicalDiskInfo();
            _fileOperation = new FileOperation();
            _folderOperation = new FolderOperation();
        }

        /// <summary>
        /// Вывод информации о файле
        /// </summary>
        /// <param name="path"></param>
        public void FileInformationPrint(string path)
        {
            _fileInformation = _fileInformation.Info(path);
            if (_fileInformation is null)
            {
                Console.WriteLine("Такой файл не найден, проверьте правильность написания пути");
                return;
            }
            Console.WriteLine($"Название файла {_fileInformation.Name}\n" +
            $"Дата создания папки: {_fileInformation.CreateTime}\n" +
            $"Местоположение: {_fileInformation.Location}\n" +
            $"Размер файла{_fileInformation.Size}\n" +
            $"Тип файла: {_fileInformation}");
        }

        /// <summary>
        /// Иформация об Удалении файла
        /// </summary>
        /// <param name="path"></param>
        public void FileDelete(string path)
        {
            if (_fileOperation.DeleteFile(path))
            {
                Console.WriteLine("Успешно удалено");
                return;
            }
            Console.WriteLine("Файл не найден, или что то пошло не так");
            
        }

        public void FileCopy(string pathFrom, string pathTo)
        {
            
            if (_fileOperation.CopyFile(pathFrom, pathTo))
            {
                Console.WriteLine("Файл успешно скопирован");
                return;
            }
            Console.WriteLine("Что пошло не так повторите попытку");
        }

        /// <summary>
        /// Информация об удалении папки
        /// </summary>
        /// <param name="path"></param>
        public void FolderDelete(string path)
        {
            if (_folderOperation.DeleteFolder(path))
            {
                Console.WriteLine("Удаление прошло успешно");
                return;
            }
            Console.WriteLine("Что то пошло не так");
        }

        /// <summary>
        /// Вывод списка папок
        /// </summary>
        /// <param name="path"></param>
        public void FoldersPrint(string path)
        {
            _foldersList = _folderInfo.FoldersList(path);
            if (_foldersList== null)
            {
                Console.WriteLine("Указанного пути не существует, проверьте правильность написания");
            }
            else
            {
                foreach (var item in _foldersList)
                {
                    Console.WriteLine($"{item.Name, -30} \t {"Папка", -1}");
                }
            }
        }

        /// <summary>
        /// Вывод списка файлов
        /// </summary>
        /// <param name="path"></param>
        public void FilesInFolderPrint(string path)
        {
            _filesList = _folderInfo.FilesInFoldersList(path);
            if (_filesList == null)
            {
                Console.WriteLine("Указанного пути не существует, проверьте правильность написания");
            }
            else
            {
                Console.WriteLine($"{"Название", -31}  {"Тип", -8}");
                Console.WriteLine(new string('-', 50));
                foreach (var item in _filesList)
                {
                    Console.WriteLine($"{item.Name, -28}  \t {"Файл", -1}");
                }
            }
            
        }

        /// <summary>
        /// Вывод информации о папке
        /// </summary>
        /// <param name="path"></param>
        public void FolderInfoPrint(string path)
        {
            _folderInfo = _folderInfo.Info(path);
            if (_folderInfo is null)
            {
                Console.WriteLine("Данной папки не существует, либо проверьте правильность ввода");
                return;
            }
            Console.WriteLine($"Название папки: {_folderInfo.Name}\n" +
                 $"Дата создания папки: {_folderInfo.CreateTime} \n" +
                 $"Количество файлов: {_folderInfo.FilesNumberInFolder} \n" +
                 $"Количество папок: {_folderInfo.FolderNumber}  \n" +
                 $"Размер: {_folderInfo.Size / 1024} КБайт ({_folderInfo.Size} байт)");
        }

        /// <summary>
        /// Вывод списка дисков и информации о них
        /// </summary>
        public void DiskInfoPrint()
        {
            _ld = _logicalDiskInfo.DiscInfo();
            foreach (var disc in _ld)
            {
                Console.WriteLine($"Наименование диска: {disc.Name}\n" +
                    $"Тип диска: {disc.DiskType}\n" +
                    $"Общий объем: {disc.Size} Гб.\n" +
                    $"-----------------------");
            }
        }

        /// <summary>
        /// Список команд доступных пользователю
        /// </summary>
        public void Help()
        {
            Console.WriteLine("Введите команду из списка предложенных, для выхода нажмите quit");
            Console.WriteLine("ВНИМАНИЕ ВСЕ КОМАНДЫ ПИШУТСЯ НА ЛАТИНИЦЕ (АНГЛИЙСКОМ)");
            Console.WriteLine(@"Вывести список дисков ld");
            Console.WriteLine(@"Переход на диск: C:\ где С буква диска");
            Console.WriteLine(@"Копирование каталога: ls C:\folder где ls команда, C буква диска, а folder наименование папки");
            Console.WriteLine(@"Копирование файла: cp C:\source.txt ");
            Console.WriteLine(@"Переход по папкам: C:\folder где C буква диска, а folder наименование папки");
            Console.WriteLine(@"Удаление файла: rm C:\source.txt");
            Console.WriteLine(@"Удаление каталога: rd C:\folder где rd команда,C буква диска, а folder наименование папки");
            Console.WriteLine(@"Информация о файле: file C:\source.txt");
            Console.WriteLine(@"Информация о папке: dirinfo C:\folder где dirinfo команда C:\ буква диска, а folder наименование папки");
        }
    }

}

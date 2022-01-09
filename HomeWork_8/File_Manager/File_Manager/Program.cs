using System;

namespace File_Manager
{
    class Program
    {
        static void Main(string[] args)
        {

            Print print = new Print();
            string command = string.Empty;
            string path = string.Empty;
            Console.WriteLine("Добро пожаловать в файловый менеджер");
            while (command != "quit")
            {
                Console.WriteLine("Введите команду или введите help Для вызова помощи");
                command = TestIsEmpty(Console.ReadLine().ToLower());
                Console.Clear();
                string[] commands = command.Split(' ');
                switch (commands[0])
                {
                    case "rd":
                        print.FolderDelete(commands[1]);
                        break;
                    case "rm":
                        print.FileDelete(commands[2]);
                        break;
                    case "cp":
                        Console.WriteLine("Введите путь куда необходимо скопировать файл");
                        string PathTo = TestIsEmpty(Console.ReadLine());
                        print.FileCopy(commands[1], PathTo);
                        break;
                    case "file":
                        print.FileInformationPrint(commands[1]);
                        break;
                    case "dirinfo":
                        print.FolderInfoPrint(commands[1]);
                        break;
                    case "ld":
                        print.DiskInfoPrint();
                        break;
                    case "help":
                        print.Help();
                        break;
                    case "quit":
                        Console.WriteLine("Спасибо что воспользовались программой");
                        break;
                    default:
                        print.FilesInFolderPrint(commands[0]);
                        print.FoldersPrint(commands[0]);
                        break;
                }
            }
        }
        static string TestIsEmpty(string command)
        {
            while (string.IsNullOrEmpty(command))
            {
                Console.WriteLine("Вы ввели пустую строку, повторите попытку, либо введите Help для вызова помощи");
                command = Console.ReadLine().ToLower();
            }
            return command;
        }

    }
}

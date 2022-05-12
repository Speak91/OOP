using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW3_3
{
    /// <summary>
    /// Класс для работы с файлом
    /// </summary>
    class WorkingWithFile
    {
        private List<Person> ListOfEmailAddresses;
        public WorkingWithFile()
        {
            ListOfEmailAddresses = new List<Person>();
        }

        /// <summary>
        /// Считываем файл по пути страхуемся от возможных ошибок
        /// </summary>
        public void ReadingEmailFromFile()
        {
            try
            {
                using (StreamReader str = new StreamReader(@"123.txt"))
                {
                    while (!str.EndOfStream)
                    {
                        string line = str.ReadLine();
                        string[] data = line.Split(" & ");
                        ListOfEmailAddresses.Add(new Person(data[0].ToString(), data[1].ToString()));
                    }
                }

                if (ListOfEmailAddresses.Count == 0)
                {
                    Console.WriteLine("Файл пуст");
                }
                else
                {
                    Console.WriteLine("Файл успешно считан");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка чтения файла");
            }
           
        }

        /// <summary>
        /// Записываем email адреса в отдельный файл попутно страхуясь от возможных ошибок
        /// </summary>
        /// <param name="fileName">Название файла куда нужно сохранить</param>
        public void WriteEmailInTxtFile(string fileName)
        {
            try
            {
                string input = string.Empty;
                if (ListOfEmailAddresses.Count != 0)
                {
                    using (StreamWriter str = new StreamWriter(fileName + ".txt", true, Encoding.Unicode))
                    {
                        foreach (var item in ListOfEmailAddresses)
                        {
                            str.WriteLine(item.Email);
                        }
                    }
                    Console.WriteLine("Запись файла успешно произведена");
                }
                else
                {
                    Console.WriteLine("Записывать нечего");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Произошла ошибка при записи файла");
            }
            
          
        }
    }
}

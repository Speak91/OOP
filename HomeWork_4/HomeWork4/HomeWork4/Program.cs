using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork4
{

    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.NumberOfFloors = 3;
            house.NumberOfApartments = 12;
            house.NumberOfEntrances = 4;
            house.Height = 8;

            House house1 = new House();
            Creator.AddHouse(house);
            Creator.AddHouse(house1);

            foreach (DictionaryEntry item in Creator.Houses)
            {
                Console.WriteLine(item.Value);    
            }

            Creator.DeleteByNumberHouse(1);
            Console.WriteLine();
            Console.WriteLine("После удаления убеждаемся что в таблице одна запись");
            foreach (DictionaryEntry item in Creator.Houses)
            {
                Console.WriteLine(item.Value);
            }



        }
    }
}

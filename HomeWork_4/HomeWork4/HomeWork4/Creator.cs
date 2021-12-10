using System.Collections;

namespace HomeWork4
{
    class Creator : House
    {
        public static Hashtable Houses = new Hashtable();
        private Creator()
        {

        }

        public static void AddHouse (House house)
        {
            if (house is null)
            {
                house = new House();
                Houses.Add(house.Number, house);
            }
            else
            {
                Houses.Add(house.Number, house);
            }
          
        }

        public static int ApartmentsAtTheEntrance(House house)
        {
            if (house is null)
            {
                return 0;
            }
            else
            {
                return house.ApartmentsAtTheEntrance();
            }
           
        }

        public static float FloorAtTheHeight(House house)
        {
            if (house is null)
            {
                return 0;
            }
            else
            {
                return house.FloorAtTheHeight();
            }
        }
        public static void DeleteByNumberHouse(int number)
        {
            if (Houses.ContainsKey(number))
            {
                Houses.Remove(number);
            }
            else
            {
                System.Console.WriteLine("такого номера нету");
            }
        }
    }
}

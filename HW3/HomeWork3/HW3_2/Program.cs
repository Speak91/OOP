using System;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverseString = FlipTheLine("ABCDEFGH");
            Console.WriteLine(reverseString);
        }

        static string FlipTheLine(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            string reverseString = new string(array);
            return reverseString;
        }
    }
}

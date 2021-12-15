using System;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers rationalNumbers = new RationalNumbers(37,115);
            RationalNumbers rationalNumbers1 = new RationalNumbers(38, 175);
            Console.WriteLine(rationalNumbers + rationalNumbers1);
            Console.WriteLine(rationalNumbers - rationalNumbers1);
            Console.WriteLine(rationalNumbers * rationalNumbers1);
            Console.WriteLine(rationalNumbers / rationalNumbers1);
            Console.WriteLine(rationalNumbers > rationalNumbers1);
            Console.WriteLine(rationalNumbers < rationalNumbers1);
            Console.WriteLine(rationalNumbers == rationalNumbers1);
            Console.WriteLine(rationalNumbers != rationalNumbers1);
            Console.WriteLine(rationalNumbers + " To.Doubie " + (double)(rationalNumbers));
        }
    }
}

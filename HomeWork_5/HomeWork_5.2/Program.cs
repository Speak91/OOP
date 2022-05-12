using System;

namespace HomeWork_5._2
{
    class ComplexNumbers
    {
        /// <summary>
        /// Вещественное число
        /// </summary>
        private double _realNumber;

        /// <summary>
        /// Мнимое число
        /// </summary>
        private double _imaginaryNumber;

        public ComplexNumbers(double realNumber, double imaginaryNumber)
        {
            _realNumber = realNumber;
            _imaginaryNumber = imaginaryNumber;
        }

        public static ComplexNumbers operator+(ComplexNumbers first, ComplexNumbers second)
        {
            return new ComplexNumbers(first._realNumber + second._realNumber, first._imaginaryNumber + second._imaginaryNumber);
        }

        public static ComplexNumbers operator-(ComplexNumbers first, ComplexNumbers second)
        {
            return new ComplexNumbers(first._realNumber - second._realNumber, first._imaginaryNumber - second._imaginaryNumber);
        }

        public static ComplexNumbers operator*(ComplexNumbers first, ComplexNumbers second)
        {
            return new ComplexNumbers(first._realNumber * second._realNumber - first._imaginaryNumber * second._imaginaryNumber,
                first._imaginaryNumber * second._realNumber + first._realNumber * second._imaginaryNumber);
        }

        public override string ToString()
        {
            return $"{_realNumber}+{_imaginaryNumber}i";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers complex1 = new ComplexNumbers(1, 3);
            ComplexNumbers complex2 = new ComplexNumbers(2, 1);

            Console.WriteLine(complex1);
            Console.WriteLine(complex2);
            Console.WriteLine();

            Console.WriteLine(complex1 + complex2);
            Console.WriteLine(complex1 - complex2);
            Console.WriteLine(complex1 * complex2);
        }
    }
}

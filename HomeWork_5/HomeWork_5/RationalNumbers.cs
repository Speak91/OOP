using System;

namespace HomeWork_5
{
    class RationalNumbers
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int _numerator;

        /// <summary>
        /// Знаменатель
        /// </summary>
        private int _denominator;

        public int Denominator { get { return _denominator; } set { _denominator = value; } }
        public int Numerator { get { return _numerator; } set { _numerator = value; } }

        public RationalNumbers(int numerator, int denominator)
        {
            if (numerator == 0 || denominator == 0)
            {
                throw new ArgumentException("Числитель или знаменатель не может быть равен нулю");
            }
            else
            {
                _numerator = numerator;
                _denominator = denominator;
            }
            
        }

        public static RationalNumbers operator +(RationalNumbers r1, RationalNumbers r2)
        {
            if (r1._denominator == r2._denominator)
            {
                return new RationalNumbers(r1._numerator + r2._numerator, r1._denominator);
            }
            else
            {
                return AdditionOfFractions(r1, r2);
            }
        }

        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
        {
            if (r1._denominator == r2._denominator)
            {
                return new RationalNumbers(r1._numerator - r2._numerator, r1._denominator);
            }
            else
            {
                return SubtractionOfFractions(r1, r2);
            }
        }

        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2)
        {
            int LCF = LeastCommonFactor(r1._numerator * r2._numerator, r1._denominator * r2._denominator);
            return new RationalNumbers(r1._numerator * r2._numerator / LCF, r1._denominator * r2._denominator / LCF);
        }

        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2)
        {
            if (r1._numerator == 0 || r2._numerator == 0)
            {
                return new RationalNumbers(0, 0);
            }
            else
            {
                int LCF = LeastCommonFactor(r1._numerator * r2._denominator, r1._denominator * r2._numerator);
                return new RationalNumbers(r1._numerator * r2._denominator / LCF, r1._denominator * r2._numerator / LCF);
            }
           
        }

        public static bool operator >(RationalNumbers r1, RationalNumbers r2)
        {
            int LCM = LeastСommonMultiple (r1._denominator, r2._denominator);
            return r1.Numerator * (LCM / r1._denominator) > r2._numerator * (LCM/r2._denominator);
        }

        public static bool operator <(RationalNumbers r1, RationalNumbers r2)
        {
            int LCM = LeastСommonMultiple(r1._denominator, r2._denominator);
            return r1._numerator * (LCM / r1._denominator) < r2._numerator * (LCM / r2._denominator);
        }

        public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
        {
            int LCM = LeastСommonMultiple(r1._denominator, r2._denominator);
            return r1.Numerator * (LCM / r1._denominator) <= r2._numerator * (LCM / r2._denominator);
        }

        public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
        {
            int LCM = LeastСommonMultiple(r1._denominator, r2._denominator);
            return r1._numerator * (LCM / r1._denominator) <= r2._numerator * (LCM / r2._denominator);
        }

        public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
        {
            int LCM = LeastСommonMultiple(r1._denominator, r2._denominator);
            return r1._numerator * (LCM / r1._denominator) != r2._numerator * (LCM / r2._denominator);
        }

        public static bool operator ==(RationalNumbers r1, RationalNumbers r2)
        {
            int LCM = LeastСommonMultiple(r1._denominator, r2._denominator);
            return r1._numerator * (LCM / r1._denominator) == r2._numerator * (LCM / r2._denominator);
        }

        public static explicit operator double(RationalNumbers r)
        {
            return (double)r._numerator / r._denominator;
        }

        public static explicit operator int(RationalNumbers r)
        {
            return r._numerator / r._denominator;
        }

        /// <summary>
        /// Нахождение наименьшего общего кратного
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int LeastСommonMultiple(int num1, int num2)
        {
            int a = 1;
            while (true)
            {
                if (a % num1  == 0 & a % num2 == 0)
                {
                    return a;
                }
                else
                {
                    a++;
                }
            }
        }

        /// <summary>
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <returns></returns>
        public static int LeastCommonFactor(int numerator, int denominator)
        {
            while (denominator != 0)
            {
                var t = denominator;
                denominator = numerator % denominator;
                numerator = t;
            }
            return numerator;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static RationalNumbers AdditionOfFractions (RationalNumbers r1, RationalNumbers r2)
        {
            int a = LeastСommonMultiple(r1._denominator, r2._denominator);
            if (a == r1._denominator)
            {
                return new RationalNumbers((r2._numerator * (a/r2._denominator)) +(r1._numerator), a);
            }
            else if (a == r2._denominator)
            {
                return new RationalNumbers((r1._numerator * (a / r1._denominator)) + (r2._numerator), a);
            }
            else
            {
                return new RationalNumbers((r1._numerator*(a / r1._denominator)) + (r2._numerator *(a / r2._denominator)), a);
            }
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static RationalNumbers SubtractionOfFractions(RationalNumbers r1, RationalNumbers r2)
        {
            int a = LeastСommonMultiple(r1._denominator, r2._denominator);
            if (a == r1._denominator)
            {
                return new RationalNumbers((r1._numerator) - (r2._numerator * (a / r2.Denominator)), a);
            }
            else if (a == r2._denominator)
            {
                return new RationalNumbers((r1._numerator * (a / r1.Denominator)) - (r2._numerator), a);
            }
            else
            {
                return new RationalNumbers((r1._numerator * (a / r1.Denominator)) - (r2._numerator * (a / r2._denominator)), a);
            }
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public override bool Equals(object obj)
        {
            return obj is RationalNumbers other && Equals(other);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

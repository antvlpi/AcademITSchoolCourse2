using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range1 = new Range(GetStartNumber(), GetFinalNimber());

            Console.WriteLine();
            if (range1.IsInside(GetCheckNumber()))
            {
                Console.WriteLine("Число лежит в диапазоне введенных чисел.");
            }
            else
            {
                Console.WriteLine("Число не лежит в диапазоне введенных чисел.");
            }
        }

        public static double GetStartNumber()
        {
            Console.WriteLine("Введите первое число диапазона:");

            return Convert.ToDouble(Console.ReadLine());
        }

        public static double GetFinalNimber()
        {
            Console.WriteLine("Введите конечно число диапазона, больше начального:");

            return Convert.ToDouble(Console.ReadLine());
        }

        public static double GetCheckNumber()
        {
            Console.WriteLine("Введите число, чтобы проверить находится ли оно в диапазоне:");

            return Convert.ToDouble(Console.ReadLine());
        }
    }
}

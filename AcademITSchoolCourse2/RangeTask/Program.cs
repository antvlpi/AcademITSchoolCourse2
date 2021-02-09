using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstNumberEntering = "Введите первое число диапазона:";
            const string secondNumberEntering = "Введите второе число диапазона:";

            Range range1 = new Range(GetNumber(firstNumberEntering), GetNumber(secondNumberEntering));

            // Длина диапазона и проверка числа в диапазоне
            Console.WriteLine("Длина диапазона: = " + range1.GetLength());

            const string checkNumberEntering = "Введите число, которое нужно проверить находится ли оно в диапазоне:";

            if (range1.IsInside(GetNumber(checkNumberEntering)))
            {
                Console.WriteLine("Введенное число принадлежит данному диапазону.");
            }
            else
            {
                Console.WriteLine("Введенное число принадлежит данному не принадлежит диапазнону.");
            }

            Console.WriteLine();
            Console.WriteLine("Задайте второй диапазон.");
            Range range2 = new Range(GetNumber(firstNumberEntering), GetNumber(secondNumberEntering));

            // Часть2 задания
            // Интервал-пересечение
            Console.WriteLine();
            Range rangeIntersection = new Range(range1.From, range1.To).GetIntersection(range2);

            if (rangeIntersection == null)
            {
                Console.WriteLine("Пересечений нет.");
            }
            else
            {
                Console.WriteLine(rangeIntersection.ToString());
            }

            // Интервал-объединение
            Console.WriteLine();
            Range[] rangesUnion = new Range(range1.From, range1.To).GetUnion(range2);

            Range.ToString("Объединение ", rangesUnion);

            //Разность интервалов
            Console.WriteLine();
            Range[] rangesAsymmetricalDifference = new Range(range1.From, range1.To).GetAsymmetricalDifference(range2);

            Range.ToString("Разность ", rangesAsymmetricalDifference);

            Console.ReadKey();
        }

        public static double GetNumber(string inputInvitation)
        {
            Console.WriteLine(inputInvitation);

            return Convert.ToDouble(Console.ReadLine());
        }
    }
}

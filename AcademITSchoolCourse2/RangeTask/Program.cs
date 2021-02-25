using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const string numberEntering1 = "Введите первое число диапазона:";
            const string numberEntering2 = "Введите второе число диапазона:";

            Range range1 = new Range(GetNumber(numberEntering1), GetNumber(numberEntering2));

            // Длина диапазона и проверка числа в диапазоне
            Console.WriteLine("Длина диапазона: = " + range1.GetLength());

            Console.WriteLine("Введите число, которое нужно проверить находится ли оно в диапазоне:");

            if (range1.IsInside(Convert.ToDouble(Console.ReadLine())))
            {
                Console.WriteLine("Введенное число принадлежит данному диапазону.");
            }
            else
            {
                Console.WriteLine("Введенное число принадлежит данному не принадлежит диапазнону.");
            }

            Console.WriteLine();
            Console.WriteLine("Задайте второй диапазон.");
            Range range2 = new Range(GetNumber(numberEntering1), GetNumber(numberEntering2));

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
                Console.WriteLine(rangeIntersection);
            }

            // Интервал-объединение
            Console.WriteLine();
            Range[] rangesUnion = new Range(range1.From, range1.To).GetUnion(range2);

            Console.WriteLine(Range.ToString("Объединение ", rangesUnion));

            //Разность интервалов
            Console.WriteLine();
            Range[] rangesAsymmetricalDifference = new Range(range1.From, range1.To).GetDifference(range2);

            Console.WriteLine(Range.ToString("Разность ", rangesAsymmetricalDifference));

            Console.ReadKey();
        }

        public static double GetNumber(string inputInvitation)
        {
            Console.WriteLine(inputInvitation);

            return Convert.ToDouble(Console.ReadLine());
        }
    }
}

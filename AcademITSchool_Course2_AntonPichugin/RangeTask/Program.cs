using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const int startNumber = 1;
            const int endNumber = 2;

            Range range1 = new Range(GetNumber(startNumber), GetNumber(endNumber));
            
            Console.WriteLine("Длина диапазона: = " + range1.GetLength());

            const int checkNumber = 3;

            if (range1.IsInside(GetNumber(checkNumber)))
            {
                Console.WriteLine("Введенное число принадлежит данному диапазону.");
            }
            else
            {
                Console.WriteLine("Введенное число принадлежит данному не принадлежит диапазнону.");
            }
            
            Console.WriteLine();
            Console.WriteLine("Задайте второй диапазон.");
            Range range2 = new Range(GetNumber(1), GetNumber(2));

            // Часть2 задания
            // Интервал-пересечение
            Console.WriteLine();
            Range interval_Intersection = new Range(0, 0).GetIntervalsIntersection(range1, range2);

            if (interval_Intersection == null)
            {
                Console.WriteLine("Пересечений нет.");
            }
            else
            {
                Console.WriteLine("Новый диапазон от интервал-пересечения: от {0} до {1}.", interval_Intersection.From, interval_Intersection.To);
            }

            // Интервал-объединение
            Console.WriteLine();
            Range[] intervalsCombining = new Range(range1.From, range1.To).GetIntervalsCombining(range1, range2);
            intervalsCombining[0] = new Range(intervalsCombining[0].From, intervalsCombining[0].To);

            if (intervalsCombining.Length == 2)
            {
                intervalsCombining[1] = new Range(range2.From, range2.To);
                Console.WriteLine("Объединение интервалов имеет два куска:");
                Console.WriteLine("1 интервал: от {0} до {1}", intervalsCombining[0].From, intervalsCombining[0].To);
                Console.WriteLine("2 интервал: от {0} до {1}", intervalsCombining[1].From, intervalsCombining[1].To);
            }
            else
            {
                Console.WriteLine("Объединение интервалов выплнено:");
                Console.WriteLine("Новый интервал: от {0} до {1}", intervalsCombining[0].From, intervalsCombining[0].To);
            }

            //Разность интервалов
            Console.WriteLine();
            Range[] asymmetricalIntervalsDifference = new Range(range1.From, range1.To).GetAsymmetricalIntervalsDifference(range1, range2);

            if (asymmetricalIntervalsDifference == null)
            {
                Console.WriteLine("Разность интервалов равно 0. Вычислить диапазон нет возможности");
            }
            else if (asymmetricalIntervalsDifference.Length == 2)
            {
                Console.WriteLine("Разность выполнена и имеет два куска:");
                Console.WriteLine("1 интервал: от {0} до {1}", asymmetricalIntervalsDifference[0].From, asymmetricalIntervalsDifference[0].To);
                Console.WriteLine("2 интервал: от {0} до {1}", asymmetricalIntervalsDifference[1].From, asymmetricalIntervalsDifference[1].To);
            }
            else
            {
                Console.WriteLine("Разность выполнена:");
                Console.WriteLine("Интервал: от {0} до {1}", asymmetricalIntervalsDifference[0].From, asymmetricalIntervalsDifference[0].To);
            }

            Console.ReadKey();
        }

        public static double GetNumber(int key)
        {
            double number = 0.0;

            switch (key)
            {
                case 1:
                    Console.WriteLine("Введите первое число диапазона:");
                    number = Convert.ToDouble(Console.ReadLine());

                    break;
                case 2:
                    Console.WriteLine("Введите конечноe число диапазона, больше начального:");
                    number = Convert.ToDouble(Console.ReadLine());

                    break;
                case 3:

                    Console.WriteLine("Введите число, которое нужно проверить находится ли оно в диапазоне:");
                    number = Convert.ToDouble(Console.ReadLine());

                    break;
            }

            return number;
        }
    }
}

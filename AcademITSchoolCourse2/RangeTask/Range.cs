using System;

namespace RangeTask
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return From <= number && number <= To;
        }

        public Range GetIntersection(Range range2)
        {
            if ((From <= range2.From && To >= range2.To) || (From >= range2.From && To <= range2.To))
            {
                return new Range(Math.Max(From, range2.From), Math.Min(To, range2.To));
            }

            return null;
        }

        public Range[] GetUnion(Range range2)
        {
            if (To < range2.From || From > range2.To)
            {
                return new Range[] { new Range(From, To), new Range(range2.From, range2.To) };
            }

            return new Range[] { new Range(Math.Min(From, range2.From), Math.Max(To, range2.To)) };
        }

        public Range[] GetDifference(Range range2)
        {
            if ((From >= range2.From && To <= range2.To) || (From < range2.From && To < range2.To) || (From > range2.From && To > range2.To))
            {
                return new Range[0];
            }

            if (To < range2.From || From > range2.To)
            {
                return new Range[] { new Range(From, To) };
            }

            if (From < range2.From && To > range2.To)
            {
                return new Range[] { new Range(From, range2.From), new Range(range2.To, To) };
            }

            return new Range[] { new Range(From, range2.From) };
        }

        public override string ToString()
        {
            return $"Получение нового диапазона выполнено: ({From}; {To})";
        }

        public static string ToString(string operationType, Range[] ranges)
        {
            if (ranges.Length == 2)
            {
                return operationType + $"интервалов имеет два куска: [({ranges[0].From}; {ranges[0].To}), ({ranges[1].From}; {ranges[1].To})]";
            }

            if (ranges.Length == 1)
            {
                return operationType + $"интервалов выполнено: [({ranges[0].From}; {ranges[0].To})]";
            }

            return operationType + "интервалов выполнено: []";
        }
    }
}

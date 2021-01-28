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

        public Range GetIntervalsIntersection(Range range1, Range range2)
        {
            if (range1.To <= range2.From || range1.From >= range2.To)
            {
                return null;
            }

            if (range1.From < range2.From)
            {
                this.From = range2.From;
            }
            else
            {
                this.From = range1.From;
            }

            if (range1.To < range2.To)
            {
                this.To = range1.To;
            }
            else
            {
                this.To = range2.To;
            }

            return new Range(this.From, this.To);
        }

        public Range[] GetIntervalsCombining(Range range1, Range range2)
        {
            Range[] rangeArray = new Range[1];
            rangeArray[0] = new Range(range1.From, range1.To);
            rangeArray[0].From = range1.From;
            rangeArray[0].To = range1.To;

            if (range1.To < range2.From || range1.From > range2.To)
            {
                rangeArray = new Range[2];
                rangeArray[1] = new Range(range2.From, range2.To);
                rangeArray[1].From = range2.From;
                rangeArray[1].To = range2.To;

                return rangeArray;
            }

            if (range1.From >= range2.From)
            {
                rangeArray[0].From = range2.From;
            }

            if (range1.To <= range2.To)
            {
                rangeArray[0].To = range2.To;
            }

            return rangeArray;
        }

        public Range[] GetAsymmetricalIntervalsDifference(Range range1, Range range2)
        {
            Range[] rangeArray = new Range[1];
            rangeArray[0] = new Range(range1.From, range1.To);
            rangeArray[0].From = range1.From;
            rangeArray[0].To = range1.To;

            if (range1.To <= range2.From || range1.From >= range2.To)
            {
                rangeArray = new Range[2];
                rangeArray[1] = new Range(range2.From, range2.To);
                rangeArray[1].From = range2.From;
                rangeArray[1].To = range2.To;

                return rangeArray;
            }

            if (range1.From == range2.From && range1.To == range2.To)
            {
                return null;
            }

            rangeArray[0].To = range2.From;

            return rangeArray;
        }
    }
}

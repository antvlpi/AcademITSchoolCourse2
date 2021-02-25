using System;

namespace ShapesTask
{
    class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double GetWidth()
        {
            return SideLength;
        }

        public double GetHeight()
        {
            return SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public string GetShapeName()
        {
            return typeof(Square).Name;
        }

        public override string ToString()
        {
            return "квадрат c размером стороны = " + SideLength;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != GetType())
            {
                return false;
            }

            Square newObj = (Square)obj;

            return SideLength == newObj.SideLength;
        }

        public override int GetHashCode()
        {
            const int prime = 37;
            int hash = 1;
            hash = prime * hash + Convert.ToInt32(SideLength);

            return hash;
        }
    }
}

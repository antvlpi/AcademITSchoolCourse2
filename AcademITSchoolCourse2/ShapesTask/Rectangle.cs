using System;

namespace ShapesTask
{
    class Rectangle : IShape
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double GetWidth()
        {
            return Side1;
        }

        public double GetHeight()
        {
            return Side2;
        }

        public double GetArea()
        {
            return Side1 * Side2;
        }

        public double GetPerimeter()
        {
            return (Side1 + Side2) * 2;
        }

        public int CompareTo(IShape circle)
        {
            if (GetArea() > circle.GetArea())
            {
                return 1;
            }

            if (GetArea() < circle.GetArea())
            {
                return -1;
            }

            return 0;
        }

        public string GetShapeName()
        {
            return typeof(Rectangle).Name;
        }

        public override string ToString()
        {
            return "прямоугольник c размером сторон = " + Side1 + " и " + Side2;
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

            Rectangle newObj = (Rectangle)obj;

            return Side1 == newObj.Side1 && Side2 == newObj.Side2;
        }

        public override int GetHashCode()
        {
            const int prime = 37;
            int hash = 1;
            hash = prime * hash + Convert.ToInt32(Side1);
            hash = prime * hash + Convert.ToInt32(Side2);

            return hash;
        }
    }
}

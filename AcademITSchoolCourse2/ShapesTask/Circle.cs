using System;

namespace ShapesTask
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetWidth()
        {
            return Radius * 2;
        }

        public double GetHeight()
        {
            return Radius * 2;
        }

        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public double GetPerimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
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
            return typeof(Circle).Name;
        }

        public override string ToString()
        {
            return "круг c радиусом окружности = " + Radius;
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

            Circle newObj = (Circle)obj;

            return Radius == newObj.Radius;
        }

        public override int GetHashCode()
        {
            const int prime = 37;
            int hash = 1;
            hash = prime * hash + Convert.ToInt32(Radius);

            return hash;
        }
    }
}
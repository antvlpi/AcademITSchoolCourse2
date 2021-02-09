using System.Text;

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
            return (Side1 * Side2) * 2;
        }

    }
}

using System;

namespace ShapesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Square(2);
            //shapes[1] = new Triangle(1, 2, 5, 2, 4, 7);
            shapes[1] = new Circle(5);
            shapes[2] = new Rectangle(2, 5);
            /*
            ShapesComparer[] shapes = new ShapesComparer[3];
            shapes[0] = new Square(5);
            //shapes[1] = new Triangle(1, 2, 5, 2, 4, 7);
            shapes[1] = new Circle(5);
            shapes[2] = new Rectangle(2, 5);
            */
            Console.WriteLine(shapes[0].GetArea());


            Console.ReadKey();
            //Array.Sort

        }
    }
}

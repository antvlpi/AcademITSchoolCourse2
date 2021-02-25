using System;

namespace ShapesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[6] { new Square(4), new Square(2), new Circle(4), new Rectangle(5, 6), new Rectangle(2, 8), new Triangle(100, 200, 300, 600, 700, 800) };

            IShape[] areasArray = new IShape[shapes.Length];
            Array.Copy(shapes, areasArray, shapes.Length);
            Array.Sort(areasArray, new AreasComparer());

            IShape[] perimetersArray = new IShape[shapes.Length];
            Array.Copy(shapes, perimetersArray, shapes.Length);
            Array.Sort(perimetersArray, new PerimeterComparer());

            // GetMaxAreaAndPerimeter(areasArray, perimetersArray);

            Console.WriteLine("Максимальную площадью равную " + areasArray[areasArray.Length - 1].GetArea() + ", имеет фигура: " + areasArray[areasArray.Length - 1]);
            Console.WriteLine("Второй по величине периметр равный " + areasArray[areasArray.Length - 2].GetArea() + ", имеет фигура: " + areasArray[areasArray.Length - 2]);

            Console.WriteLine("Сравнние фигур через Хеш-код выполнено и имеют результат: " + areasArray[areasArray.Length - 1].GetHashCode().Equals(areasArray[areasArray.Length - 2].GetHashCode()));

            Console.ReadKey();
        }

        public static void GetMaxAreaAndPerimeter(IShape[] areaArray, IShape[] perimeterArray)
        {
            Console.WriteLine("Фигура {0} имеет максимальную площадь равную {1}", areaArray[areaArray.Length - 1].GetShapeName(), areaArray[areaArray.Length - 1].GetArea());
            Console.WriteLine();
            Console.WriteLine("Фигура {0} имеет второй по величине периметр равный {1}", perimeterArray[perimeterArray.Length - 2].GetShapeName(), perimeterArray[perimeterArray.Length - 2].GetPerimeter());
        }
    }
}

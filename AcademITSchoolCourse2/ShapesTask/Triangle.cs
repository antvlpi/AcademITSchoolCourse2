using System;

namespace ShapesTask
{
    class Triangle : IShape
    {
        public double X1 { get; set; }

        public double X2 { get; set; }

        public double X3 { get; set; }

        public double Y1 { get; set; }

        public double Y2 { get; set; }

        public double Y3 { get; set; }

        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public Triangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;

            SideA = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            SideB = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            SideC = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));

        }

        public double GetWidth()
        {
            double maxX = X1;
            double minX = X1;

            if (X1 < X2 && X2 > X3)
            {
                maxX = X2;

                if (X1 > X3)
                {
                    minX = X3;
                }

                return maxX - minX;
            }

            if (X1 < X3)
            {
                maxX = X3;

                if (X1 > X2)
                {
                    minX = X2;
                }

                return maxX - minX;
            }

            return maxX - minX; ;
        }

        public double GetHeight()
        {
            double maxY = Y1;
            double minY = Y1;

            if (Y1 < Y2 && Y2 > Y3)
            {
                maxY = Y2;

                if (Y1 > Y3)
                {
                    minY = Y3;
                }

                return maxY - minY;
            }

            if (Y1 < Y3)
            {
                maxY = Y3;

                if (Y1 > Y2)
                {
                    minY = Y2;
                }

                return maxY - minY;
            }

            return maxY - minY;
        }

        public double GetArea()
        {
            return Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - SideA) * (GetPerimeter() / 2 - SideB) * (GetPerimeter() / 2 - SideC));
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public string GetShapeName()
        {
            return typeof(Triangle).Name;
        }

        public override string ToString()
        {
            return "треугольник";
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

            Triangle newObj = (Triangle)obj;

            return X1 == newObj.X1 && X2 == newObj.X2 && X3 == newObj.X3 && Y1 == newObj.Y1 && Y2 == newObj.Y2 && Y3 == newObj.Y3 &&
                   SideA == newObj.SideA && SideB == newObj.SideB && SideC == newObj.SideC;
        }

        public override int GetHashCode()
        {
            const int prime = 37;
            int hash = 1;
            hash = prime * hash + Convert.ToInt32(X1);
            hash = prime * hash + Convert.ToInt32(X2);
            hash = prime * hash + Convert.ToInt32(X3);
            hash = prime * hash + Convert.ToInt32(Y1);
            hash = prime * hash + Convert.ToInt32(Y2);
            hash = prime * hash + Convert.ToInt32(Y3);
            hash = prime * hash + Convert.ToInt32(SideA);
            hash = prime * hash + Convert.ToInt32(SideB);
            hash = prime * hash + Convert.ToInt32(SideC);

            return hash;
        }
    }
}



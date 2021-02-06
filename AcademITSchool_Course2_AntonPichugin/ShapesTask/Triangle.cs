using System;
using System.Collections.Generic;
using System.Text;

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

        public Triangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
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
            return GetHeight() * GetWidth();
        }

        public double GetPerimeter()
        {
            return 1;
        }
    }
}



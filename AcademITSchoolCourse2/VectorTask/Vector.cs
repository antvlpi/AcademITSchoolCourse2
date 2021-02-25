using System;
using System.Collections.Generic;
using System.Text;

namespace VectorTask
{
    class Vector
    {
        public double VectorSize { get; set; }

        public Vector(double n)
        {
            if (n <= 0) throw new ArgumentException("Размерность вектора не может быть меньше или равно 0.");
            VectorSize = n;


        }

        public Vector(Vector vec)
        {

        }

        public Vector(double[] array)
        {

        }

        public Vector(double n, Vector vec)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTask
{
    class PerimeterComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            double shape1Perimeter = shape1.GetPerimeter();
            double shape2Perimeter = shape2.GetPerimeter();

            if (shape1Perimeter > shape2Perimeter)
            {
                return 1;
            }

            if (shape1Perimeter < shape2Perimeter)
            {
                return -1;
            }

            return 0;
        }
    }
}

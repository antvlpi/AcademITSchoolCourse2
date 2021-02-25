using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTask
{
    class AreasComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            double shape1Area = shape1.GetArea();
            double shape2Area = shape2.GetArea();

            if (shape1Area > shape2Area)
            {
                return 1;
            }

            if (shape1Area < shape2Area)
            {
                return -1;
            }

            return 0;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace ShapesTask
{
    public interface IShape
    {
        double GetWidth();

        double GetHeight();

        double GetArea();

        double GetPerimeter();

        string GetShapeName();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EquilateralPolygon
{
    class EquilateralPolygon
    {

        public int NumSides { get; set; }
        public double SideLength { get; set; }

        public EquilateralPolygon(int numSides, double sideLength)
        {
            NumSides = numSides;
            SideLength = sideLength;
        }

    }
}

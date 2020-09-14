using System;
using System.Collections.Generic;
using System.Text;

namespace EquilateralPolygon
{
    class Square : EquilateralPolygon
    {

        public double Area
        {
            get
            {
                return SideLength * SideLength;
            }
        }

        public double Perimeter
        {
            get
            {
                return 4.0 * SideLength;
            }
        }

        public Square(double sideLength)
            : base(4, sideLength)
        {

        }

        public override string ToString()
        {
            return String.Format("Number of Sides: {0}, Side Length: {1}, Area: {2}, Perimeter: {3}", NumSides, SideLength, Area, Perimeter);
        }

    }
}

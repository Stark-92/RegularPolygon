using System;

namespace RegularPolygon
{
    public class Triangle:Polygon
    {
        public Triangle(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double calculateArea()
        {
            return sideLength * sideLength * Math.Sqrt(3) / 4 ;
        }

    }
}

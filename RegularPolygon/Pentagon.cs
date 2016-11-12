using System;

namespace RegularPolygon
{
    public class Pentagon:Polygon
    {
        public Pentagon(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double calculateArea()
        {
            return  0.25 * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) * sideLength * sideLength;
        }
    }
}

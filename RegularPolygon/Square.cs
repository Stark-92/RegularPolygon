using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygon
{
    class Square : Polygon
    {
        private float sideLength;

        public Square(float sideLength)
        {
            this.sideLength = sideLength;
        }

        public override float calculateArea()
        {
            return sideLength * sideLength;
        }
    }
}

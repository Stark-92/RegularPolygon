using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygon
{
    class Triangle:Polygon
    {
        private float sideLength;

        public Triangle(float sideLength)
        {
            this.sideLength = sideLength;
        }

        public override float calculateArea()
        {
            return (float) (sideLength * sideLength * Math.Sqrt(3) / 4 );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygon
{
    class Pentagon:Polygon
    {
        private float sideLength;

        public Pentagon(float sideLength)
        {
            this.sideLength = sideLength;
        }

        public override float calculateArea()
        {
            return (float)( 0.25 * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) * sideLength * sideLength);
        }
    }
}

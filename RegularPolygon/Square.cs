namespace RegularPolygon
{
    public class Square : Polygon
    {
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double calculateArea()
        {
            return sideLength * sideLength;
        }
    }
}

using System;

namespace RegularPolygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Polygon area calculator application");
            Console.WriteLine("Please enter the regular polygon side length :");
            Console.WriteLine();
            double sideLength = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Triangle triangle = new Triangle(sideLength);
            Square square = new Square(sideLength);
            Pentagon pentagon = new Pentagon(sideLength);

            Console.WriteLine("The Triangle's area is : " + Math.Round(triangle.calculateArea(),2));
            Console.WriteLine("The Square's area is : " + Math.Round(square.calculateArea(), 2));
            Console.WriteLine("The Pentagon's area is : " + Math.Round(pentagon.calculateArea(), 2));

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit ...");
            Console.ReadKey();
        }
    }
}

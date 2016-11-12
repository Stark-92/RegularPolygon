using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Polygon area calculator");
            Console.WriteLine("Please enter the regular polygon side length");

            float sideLength = float.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(sideLength);
            Square square = new Square(sideLength);
            Pentagon pentagon = new Pentagon(sideLength);

            Console.WriteLine("The Triangle's area is : " + triangle.calculateArea());
            Console.WriteLine("The Square's area is : " + square.calculateArea());
            Console.WriteLine("The Pentagon's area is : " + pentagon.calculateArea());

            Console.ReadKey();
        }
    }
}

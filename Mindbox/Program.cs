using System;
using SquareLib;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(5, 10, 1);
            double square = tr.GetSquare();
            Console.WriteLine(square);
            Console.WriteLine(tr.IsRectangular());

            Circle c = new Circle(12);
            Console.WriteLine(c.GetSquare());

            Console.ReadLine();
            
        }
    }
}

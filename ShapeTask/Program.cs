using System;

namespace ShapeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Triangle triangle=new Triangle(10,11);
           Circle circle=new Circle(10);

            Square square=new Square(3.1);
            Console.WriteLine(triangle.CaculateArea());
            Console.WriteLine(circle.CaculateArea());
            Console.WriteLine(square.CaculateArea());
        }
    }
}

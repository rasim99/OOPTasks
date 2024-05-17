using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTask
{
    internal class Triangle : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public Triangle(double side,double height)
        {
            Side = side;
            Height = height;
        }
        public override double CaculateArea()
        {
            return Math.Round(Side*Height,2);
        }
    }
}

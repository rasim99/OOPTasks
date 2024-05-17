using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTask
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle( double radius)
        {
             Radius = radius;
        }
        public override double CaculateArea()
        {
            return Math.Round( 2 * Math.PI * Radius,2);
        }
    }
}

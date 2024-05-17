using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTask
{
    internal class Square : Shape
    {
        public double Side { get; set; }
        public Square( double side)
        {
            Side = side;
        }
        public override double CaculateArea()
        {
            return Math.Round(4*Side,2);
        }
    }
}

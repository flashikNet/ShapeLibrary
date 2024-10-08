using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMath.Shapes
{
    public class Circle : ShapeBase
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Radius should be greater than zero");
            }
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

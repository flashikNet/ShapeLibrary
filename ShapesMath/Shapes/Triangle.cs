using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMath.Shapes
{
    public class Triangle : ShapeBase
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRightTriangle
        {
            get
            {
                var sides = new double[] { SideA, SideB, SideC };
                Array.Sort(sides);
                return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < double.Epsilon;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be greater than zero");
            }
            var sides = new double[] { sideA, sideB, sideC };
            Array.Sort(sides);
            if (sides[0] + sides[1] <= sides[2])
            {
                throw new ArgumentException("Does not satisfy the triangle inequality");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

    }
}

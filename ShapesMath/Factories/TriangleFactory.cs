using ShapesMath.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMath.Factories
{
    public class TriangleFactory : ShapeFactoryBase
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        public TriangleFactory(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override ShapeBase CreateShape()
        {
            return new Triangle(_sideA, _sideB, _sideC);
        }
    }
}

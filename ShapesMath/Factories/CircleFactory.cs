using ShapesMath.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMath.Factories
{
    public class CircleFactory : ShapeFactoryBase
    {
        private readonly double _radius;
        public CircleFactory(double radius)
        {
            _radius = radius;
        }
        public override ShapeBase CreateShape()
        {
            return new Circle(_radius);
        }
    }
}

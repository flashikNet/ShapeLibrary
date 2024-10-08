using ShapesMath.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMath.Factories
{
    public abstract class ShapeFactoryBase
    {
        public abstract ShapeBase CreateShape();
    }
}

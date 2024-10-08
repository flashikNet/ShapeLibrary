using ShapesMath.Factories;
using ShapesMath.Shapes;

namespace Tests
{
    internal class FactoryTests
    {
        [TestCase(typeof(CircleFactory), typeof(Circle), 1)]
        [TestCase(typeof(TriangleFactory), typeof(Triangle), 3, 4, 5)]
        public void ShouldCreateRightType
            (Type factoryType, Type expectedShapeType, params double[] parametres)
        {
            ShapeFactoryBase factory = (ShapeFactoryBase)
                Activator.CreateInstance(factoryType,
                parametres.Cast<object>().ToArray());
            ShapeBase shape = factory.CreateShape();
            Assert.IsInstanceOf(expectedShapeType, shape);
        }
    }
}
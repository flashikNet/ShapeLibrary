using ShapesMath.Shapes;

namespace Tests
{
    internal class ShapeTests
    {
        [TestCase(6, typeof(Triangle), 3, 4, 5)]
        [TestCase(6, typeof(Triangle), 4, 5, 3)]
        [TestCase(12, typeof(Triangle), 6, 5, 5)]
        [TestCase(Math.PI * 100, typeof(Circle), 10)]
        public void CalculateAreaRight(double expectedArea,
            Type shapeType, params double[] parametres)
        {
            ShapeBase shape = (ShapeBase)
                Activator.CreateInstance(shapeType,
                parametres.Cast<object>().ToArray());
            var area = shape.CalculateArea();
            Assert.AreEqual(expectedArea, area);

        }

        [Test]
        public void TriangleIsRightTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [Test]
        public void TriangleIsNotRightTest()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle);
        }

        [TestCase(0, 4, 5)]
        [TestCase(3, 0, 5)]
        [TestCase(3, 4, 0)]
        [TestCase(-1, 4, 5)]
        [TestCase(3, -1, 5)]
        [TestCase(3, 4, -1)]
        public void TriangleThrowsExceptionOnNotPositiveNumber
            (double sideA, double sideB, double sideC) 
        {
            Assert.Throws<ArgumentException>(() =>
            new Triangle(sideA,sideB, sideC),
            "Sides should be greater than zero");

        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CircleThrowsExceptionOnNotPositiveNumber
            (double radius)
        {
            Assert.Throws<ArgumentException>(() =>
            new Circle(radius),
            "Radius should be greater than zero");
        }

        [TestCase(3, 3, 6)]
        [TestCase(3, 6, 3)]
        [TestCase(6, 3, 3)]
        [TestCase(3, 3, 9)]
        [TestCase(3, 9, 3)]
        [TestCase(9, 3, 3)]
        public void TriangleThrowsExceptionOnTriangleInequality
            (double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() =>
            new Triangle(sideA, sideB, sideC),
            "Does not satisfy the triangle inequality");

        }
    }
}

using Figures.Implementations;

namespace FiguresTests
{
    public class TriangleTests
    {
        [Test]
        public void CreateTriangle_CorrectSides_TriangleCreated()
        {
            var triangle = new Triangle(3, 5, 7);

            Assert.That(triangle, Is.Not.Null, "Triangle wasn't created!");
        }

        [TestCase(10, -5, 2)]
        [TestCase(5, -2, -2)]
        [TestCase(-5, -2, -2)]
        [TestCase(-5, 2, 2)]
        [TestCase(1, 1, -1)]
        public void CreateTriangle_IncorrectSides_TriangleNotCreated(double x, double y, double z)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(x, y, z));

            Assert.That(exception.Message, Is.EqualTo("Incorrect triangle sides!"), "Trianle sides check wasn't made!");
        }

        [Test]
        public void CreateTriangle_CalculateArea_CorrectOutput()
        {
            var circle = new Triangle(2, 5, 4);

            var area = circle.CalculateArea();

            Assert.That(area, Is.EqualTo(3.799671038392666));
        }

        [Test]
        public void CreateTriangle_CalculateArea_NaNOutput()
        {
            var circle = new Triangle(0, 5, 10);

            var area = circle.CalculateArea();

            Assert.That(area, Is.EqualTo(double.NaN));
        }

        [Test]
        public void CreateTriangle_IsSquare_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            var isSquare = triangle.IsSquareTriangle();

            Assert.That(isSquare, Is.True, "Triangle must be square, but was not!");
        }

        [Test]
        public void CreateTriangle_IsSquare_ReturnsFalse()
        {
            var triangle = new Triangle(2, 5, 10);

            var isSquare = triangle.IsSquareTriangle();

            Assert.That(isSquare, Is.False, "Triangle mustn't be square, but was square!");
        }
    }
}

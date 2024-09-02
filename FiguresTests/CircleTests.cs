using Figures.Implementations;

namespace FiguresTests
{
    public class CircleTests
    {
        [Test]
        public void CreateCircle_CorrectRadius_CircleCreated()
        {
            var circle = new Circle(10);

            Assert.That(circle, Is.Not.Null, "Circle wasn't created!");
        }

        [Test]
        public void CreateCircle_IncorrectRadius_CircleNotCreated()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(-10));

            Assert.That(exception.Message, Is.EqualTo("Incorrect radius value!"), "Radius check wasn't made!");
        }

        [Test]
        public void CreateCircle_CalculateArea_CorrectOutput()
        {
            var circle = new Circle(10);

            var area = circle.CalculateArea();

            Assert.That(area, Is.EqualTo(314.15926535897933));
        }

        [Test]
        public void CreateCircle_CalculateArea_ZeroOutput()
        {
            var circle = new Circle(0);

            var area = circle.CalculateArea();

            Assert.That(area, Is.EqualTo(0));
        }
    }
}
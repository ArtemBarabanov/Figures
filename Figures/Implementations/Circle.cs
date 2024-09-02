using Figures.Abstractions;

namespace Figures.Implementations
{
    /// <summary>
    /// Модель круга
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private readonly double _radius;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            if (radius < 0) 
            {
                throw new ArgumentException("Incorrect radius value!");
            }
            _radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        /// <summary>
        /// Переопределение метода для строкового описания экземпляра круга
        /// </summary>
        /// <returns>Строковое описание экземпляра круга</returns>
        public override string ToString()
        {
            return $"Круг с радиусом {_radius}";
        }
    }
}

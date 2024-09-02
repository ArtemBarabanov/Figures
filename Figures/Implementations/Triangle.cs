using Figures.Abstractions;

namespace Figures.Implementations
{
    /// <summary>
    /// Модель треугольника
    /// </summary>
    public class Triangle : Figure
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x">Сторона x</param>
        /// <param name="y">Сторона y</param>
        /// <param name="z">Сторона z</param>
        public Triangle(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0) 
            {
                throw new ArgumentException("Incorrect triangle sides!");
            }
            _x = x;
            _y = y;
            _z = z;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double CalculateArea()
        {
            var halfPerimeter = (_x + _y + _z) / 2;
            return Math.Pow(halfPerimeter * (halfPerimeter - _x) * (halfPerimeter - _y) * (halfPerimeter - _z), 0.5);
        }

        /// <summary>
        /// Определяет, явялется ли треугольник прямоугольным
        /// </summary>
        public bool IsSquareTriangle()
        {
            return Math.Pow(_x, 2) == Math.Pow(_y, 2) + Math.Pow(_z, 2)
                || Math.Pow(_y, 2) == Math.Pow(_x, 2) + Math.Pow(_z, 2)
                || Math.Pow(_z, 2) == Math.Pow(_x, 2) + Math.Pow(_y, 2);
        }

        /// <summary>
        /// Переопределение метода для строкового описания экземпляра треугольника
        /// </summary>
        /// <returns>Строковое описание экземпляра треугольника</returns>
        public override string ToString()
        {
            return $"Треугольник со сторонами x - {_x}, y - {_y}, z - {_z}";
        }
    }
}

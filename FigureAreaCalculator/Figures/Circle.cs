namespace FigureAreaCalculator.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга отрицательный</exception>
        public Circle(double radius)
        {
            if (radius < 0) { throw new ArgumentOutOfRangeException("Радиус круга не может быть < 0"); }

            Radius = radius;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        protected override double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

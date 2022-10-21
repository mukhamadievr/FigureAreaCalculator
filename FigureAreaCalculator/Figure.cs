namespace FigureAreaCalculator
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;
        
        protected Figure()
        {
            _area = new Lazy<double>(CalcArea);
        }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area => _area.Value;

        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        protected abstract double CalcArea();
    }
}

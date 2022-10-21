namespace FigureAreaCalculator.Figures
{
    public class Triangle : Figure
    {
        private const double Tolerance = 0.000000001;

        private readonly Lazy<bool> _isRight;
        
        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <exception cref="ArgumentOutOfRangeException">Если некорректно заданы стороны треугольника</exception>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException("Сторона треугольника не может быть < 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("Сторона треугольника не может быть больше суммы двух других");
            }

            A = a;
            B = b;
            C = c;

            _isRight = new Lazy<bool>(CheckIsRight);
        }

        /// <summary>
        /// Сторона A
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; }
        
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight => _isRight.Value;

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        protected override double CalcArea()
        {
            var halfPerimeter = (A + B + C) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        private bool CheckIsRight()
        {
            var maxSide = Math.Max(Math.Max(A, B), C);

            return Math.Abs(2 * maxSide * maxSide - (A * A + B * B + C * C)) < Tolerance;
        }
    }
}

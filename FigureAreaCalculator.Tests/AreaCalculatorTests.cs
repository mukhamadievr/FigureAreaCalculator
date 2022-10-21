using FigureAreaCalculator.Figures;
using NUnit.Framework;

namespace FigureAreaCalculator.Tests
{
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Тест круга с отрицательным радиусом.
        /// </summary>
        [Test]
        public void CircleRadiusIsNegativeTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        /// <summary>
        /// Тест треугольника с отрицательной стороной.
        /// </summary>
        [Test]
        public void TriangleSidesIsNegativeTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }

        /// <summary>
        /// Тест треугольника с некорректными размерами сторон.
        /// </summary>
        [Test]
        public void TriangleSidesIsNotCorrectSizesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 1));
        }

        /// <summary>
        /// Тест вычисления площади круга.
        /// </summary>
        [Test]
        public void CalculateCircleAreaTest()
        {
            var circle = new Circle(10);
            var area = circle.Area;
            Assert.That(area, Is.EqualTo(314.159265).Within(.000001));
        }

        /// <summary>
        /// Тест вычисления площади треугольника.
        /// </summary>
        [Test]
        public void CalculateTriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.Area;
            Assert.That(area, Is.EqualTo(6));
        }

        /// <summary>
        /// Тест проверки треугльника на прямоугольность.
        /// </summary>
        [Test]
        public void TriangleIsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRight;
            Assert.That(isRight, Is.True);
        }

        /// <summary>
        /// Тест проверки треугльника на не прямоугольность.
        /// </summary>
        [Test]
        public void TriangleIsNotRightTest()
        {
            var triangle = new Triangle(4, 5, 6);
            var isRight = triangle.IsRight;
            Assert.That(isRight, Is.False);
        }
    }
}

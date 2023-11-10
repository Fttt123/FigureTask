using NUnit.Framework;

namespace figureLibrary
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void Square_CalculateSquare_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);

            float expectedSquare = 6;
            float actualSquare = triangle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [Test]
        public void RightTriangle_CheckRightTriangle_ReturnsTrueForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            bool isRightTriangle = triangle.RightTriangle();

            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void RightTriangle_CheckRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            var triangle = new Triangle(3, 4, 6);

            bool isRightTriangle = triangle.RightTriangle();

            Assert.IsFalse(isRightTriangle);
        }

        [Test]
        public void Square_CalculateCircleSquare_ReturnsCorrectValue()
        {
            var circle = new Сircle(2);

            float expectedSquare = (float)Math.PI * 4;
            float actualSquare = circle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}

using NUnit.Framework;

namespace figureLibrary
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void Triangle_Square_CorrectCalculation()
        {
            Triangle triangle = new Triangle { sideX = 3, sideY = 4, sideZ = 5 };
            float expectedSquare = 6f;

            float actualSquare = triangle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [Test]
        public void Circle_Square_CorrectCalculation()
        {
            Сircle circle = new Сircle { radius = 5 };
            float expectedSquare = (float)Math.PI*25;

            float actualSquare = circle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [Test]
        public void Triangle_RightTriangle_True()
        {
            Triangle triangle = new Triangle { sideX = 3, sideY = 4, sideZ = 5 };

            bool isRightTriangle = triangle.RightTriangle();

            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void Triangle_RightTriangle_False()
        {
            Triangle triangle = new Triangle { sideX = 3, sideY = 4, sideZ = 6 };

            bool isRightTriangle = triangle.RightTriangle();

            Assert.IsFalse(isRightTriangle);
        }
    }
}

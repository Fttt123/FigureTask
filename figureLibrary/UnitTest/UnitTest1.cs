using figureLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Square_CalculateSquare_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);

            float expectedSquare = 6;
            float actualSquare = triangle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void RightTriangle_CheckRightTriangle_ReturnsTrueForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            bool isRightTriangle = triangle.RightTriangle();

            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void RightTriangle_CheckRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            var triangle = new Triangle(3, 4, 6);

            bool isRightTriangle = triangle.RightTriangle();

            Assert.IsFalse(isRightTriangle);
        }

        [TestMethod]
        public void Square_CalculateCircleSquare_ReturnsCorrectValue()
        {
            var circle = new Ñircle(2);

            float expectedSquare = (float)Math.PI * 4;
            float actualSquare = circle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}
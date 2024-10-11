using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void AnalyzeTriangle_WhenSidesAreEqual_ReturnsEquilateral()
        {
            int side1 = 3, side2 = 3, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenTwoSidesAreEqual_ReturnsIsosceles1()
        {
            int side1 = 5, side2 = 5, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenTwoSidesAreEqual_ReturnsIsosceles2()
        {
            int side1 = 4, side2 = 3, side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenTwoSidesAreEqual_ReturnsIsosceles3()
        {
            int side1 = 6, side2 = 6, side3 = 10;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesAreDifferent_ReturnsScalene1()
        {
            int side1 = 3, side2 = 4, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesAreDifferent_ReturnsScalene2()
        {
            int side1 = 5, side2 = 7, side3 = 8;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesAreDifferent_ReturnsScalene3()
        {
            int side1 = 10, side2 = 12, side3 = 15;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesAreDifferent_ReturnsScalene4()
        {
            int side1 = 8, side2 = 15, side3 = 17;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesAreDifferent_ReturnsScalene5()
        {
            int side1 = 7, side2 = 24, side3 = 25;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_WhenOneSideIsZero_ReturnsInvalid1()
        {
            int side1 = 0, side2 = 3, side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void AnalyzeTriangle_WhenAnotherSideIsZero_ReturnsInvalid2()
        {
            int side1 = 3, side2 = 0, side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void AnalyzeTriangle_WhenThirdSideIsZero_ReturnsInvalid3()
        {
            int side1 = 3, side2 = 4, side3 = 0;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesDoNotFormTriangle_ReturnsInvalid1()
        {
            int side1 = 1, side2 = 2, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesDoNotFormTriangle_ReturnsInvalid2()
        {
            int side1 = 10, side2 = 1, side3 = 2;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void AnalyzeTriangle_WhenSidesDoNotFormTriangle_ReturnsInvalid3()
        {
            int side1 = 1, side2 = 10, side3 = 1;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }
    }
}

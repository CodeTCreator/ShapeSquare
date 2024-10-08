using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSquare.Figure;
using System;

namespace ShapeSquareLib_UnitTest.FigureTests
{
    [TestClass]
    public class TriangleUnitTest
    {
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void SideIsZero()
        {
            Triangle triangle = new Triangle(7, 5, 0);
        }

        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void SideIsIncorrect()
        {
            Triangle triangle = new Triangle(23, 3,-9);
        }

        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void UnexistTriangle()
        {
            Triangle triangle = new Triangle(101, 3, 5);
        }

        [TestMethod]
        public void TriangleIsRightAngled()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void TriangleIsNotRightAngled()
        {
            Triangle triangle = new Triangle(6, 8, 13);
            Assert.IsFalse(triangle.IsRightAngled());
        }
    }
}

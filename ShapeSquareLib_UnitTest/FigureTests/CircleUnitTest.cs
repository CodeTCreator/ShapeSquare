using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSquare.Figure;
using System;

namespace ShapeSquareLib_UnitTest.FigureTests
{
    [TestClass]
    public class CircleUnitTest
    {
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle circle = new Circle(0);
        }
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle circle = new Circle(-50);
        }
        [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle circle = new Circle(7);
            Assert.AreEqual(153.93804002589986, circle.Area, 1E-6, "Result out of range!");
        }
    }
}

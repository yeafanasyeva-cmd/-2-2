using Microsoft.VisualStudio.TestTools.UnitTesting;
using пр2_пис2;
using System;
using System.Collections.Generic;
namespace GeometryTests
{
    [TestClass]
    public class Point2DTests
    {
        [TestMethod]
        public void Point2D_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var point = new Point2D(1.5, 2.5, Point2D.Color.Red);

            // Assert
            Assert.AreEqual(1.5, point.X);
            Assert.AreEqual(2.5, point.Y);
            Assert.AreEqual(Point2D.Color.Red, point.PointColor);
        }

        [TestMethod]
        public void Point2D_ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var point = new Point2D(1.0, 2.0, Point2D.Color.Green);

            // Act
            var result = point.ToString();

            // Assert
            Assert.IsTrue(result.Contains("X: 1"));
            Assert.IsTrue(result.Contains("Y: 2"));
            Assert.IsTrue(result.Contains("Цвет: Green"));
        }
    }
}
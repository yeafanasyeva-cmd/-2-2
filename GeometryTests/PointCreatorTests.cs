using Microsoft.VisualStudio.TestTools.UnitTesting;
using пр2_пис2;
using System;
using System.Collections.Generic;
namespace GeometryTests;

[TestClass]
public class PointCreatorTests
{
    [TestMethod]
    public void CreatePointFromString_ValidInput_ShouldCreatePoint()
    {
        // Arrange
        string input = "1.5 2.5 red";

        // Act
        var point = PointCreator.CreatePointFromString(input);

        // Assert
        Assert.IsNotNull(point);
        Assert.AreEqual(1.5, point.X);
        Assert.AreEqual(2.5, point.Y);
        Assert.AreEqual(Point2D.Color.Red, point.PointColor);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CreatePointFromString_InvalidFormat_ShouldThrowException()
    {
        // Arrange
        string input = "invalid_data";

        // Act
        PointCreator.CreatePointFromString(input);
    }
}

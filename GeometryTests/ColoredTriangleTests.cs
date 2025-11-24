using Microsoft.VisualStudio.TestTools.UnitTesting;
using пр2_пис2;
using System;
using System.Collections.Generic;
namespace GeometryTests;

[TestClass]
public class ColoredTriangleTests
{
    [TestMethod]
    public void ColoredTriangle_HasUniformColor_AllSameColor_ShouldReturnTrue()
    {
        // Arrange
        var a = new Point2D(0, 0, Point2D.Color.Red);
        var b = new Point2D(1, 0, Point2D.Color.Red);
        var c = new Point2D(0, 1, Point2D.Color.Red);
        var coloredTriangle = new ColoredTriangle(a, b, c, "Тестовый");

        // Act
        bool result = coloredTriangle.HasUniformColor();

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ColoredTriangle_HasUniformColor_DifferentColors_ShouldReturnFalse()
    {
        // Arrange
        var a = new Point2D(0, 0, Point2D.Color.Red);
        var b = new Point2D(1, 0, Point2D.Color.Green);
        var c = new Point2D(0, 1, Point2D.Color.Blue);
        var coloredTriangle = new ColoredTriangle(a, b, c, "Тестовый");

        // Act
        bool result = coloredTriangle.HasUniformColor();

        // Assert
        Assert.IsFalse(result);
    }
}

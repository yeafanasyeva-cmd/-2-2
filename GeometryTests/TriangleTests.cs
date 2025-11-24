using Microsoft.VisualStudio.TestTools.UnitTesting;
using пр2_пис2;
using System;
using System.Collections.Generic;
namespace GeometryTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Triangle_Constructor_ShouldSetPoints()
    {
        // Arrange
        var a = new Point2D(0, 0, Point2D.Color.Red);
        var b = new Point2D(1, 0, Point2D.Color.Green);
        var c = new Point2D(0, 1, Point2D.Color.Blue);

        // Act
        var triangle = new Triangle(a, b, c);

        // Assert
        Assert.AreEqual(a, triangle.A);
        Assert.AreEqual(b, triangle.B);
        Assert.AreEqual(c, triangle.C);
    }

    [TestMethod]
    public void Triangle_Draw_ShouldReturnCorrectString()
    {
        // Arrange
        var a = new Point2D(0, 0, Point2D.Color.Red);
        var b = new Point2D(1, 0, Point2D.Color.Green);
        var c = new Point2D(0, 1, Point2D.Color.Blue);
        var triangle = new Triangle(a, b, c);

        // Act
        var result = triangle.Draw();

        // Assert
        Assert.IsTrue(result.Contains("A:"));
        Assert.IsTrue(result.Contains("B:"));
        Assert.IsTrue(result.Contains("C:"));
    }
}

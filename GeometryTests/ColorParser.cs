using Microsoft.VisualStudio.TestTools.UnitTesting;
using пр2_пис2;
using System;
using System.Collections.Generic;
namespace GeometryTests;

[TestClass]
public class ColorParserTestss
{
    [TestMethod]
    public void ParseColor_ValidColor_ShouldReturnCorrectEnum()
    {
        // Act & Assert
        Assert.AreEqual(Point2D.Color.Red, ColorParser.ParseColor("red"));
        Assert.AreEqual(Point2D.Color.Green, ColorParser.ParseColor("green"));
        Assert.AreEqual(Point2D.Color.Blue, ColorParser.ParseColor("blue"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ParseColor_InvalidColor_ShouldThrowException()
    {
        // Act
        ColorParser.ParseColor("invalid_color");
    }
}

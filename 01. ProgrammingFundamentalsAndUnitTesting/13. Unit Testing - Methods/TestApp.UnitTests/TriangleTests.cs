using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        var n = 0;

        // Act
        var actual = Triangle.PrintTriangle(n);
        var expected = string.Empty;

        // Assert
        Assert.AreEqual(expected, actual, "Triangle did not work properly.");
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        var n = 3;

        // Act
        var actual = Triangle.PrintTriangle(n);
        var expected = 
            "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        // Assert
        Assert.AreEqual(expected, actual, "Triangle did not work properly.");
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        var n = 5;

        // Act
        var actual = Triangle.PrintTriangle(n);
        var expected =
            "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        // Assert
        Assert.AreEqual(expected, actual, "Triangle did not work properly.");
    }
}

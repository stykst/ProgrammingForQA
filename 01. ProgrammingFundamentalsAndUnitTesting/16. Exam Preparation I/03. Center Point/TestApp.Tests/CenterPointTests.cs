using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        var x1 = 0.9;
        var y1 = 0.1;
        var x2 = 4.9;
        var y2 = 2.9;

        var expected = "(0.9, 0.1)";

        // Act
        var result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        var x1 = 5.9;
        var y1 = 7.1;
        var x2 = 4.9;
        var y2 = 2.9;

        var expected = "(4.9, 2.9)";

        // Act
        var result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        var x1 = 1;
        var y1 = 2;
        var x2 = 1;
        var y2 = 2;

        var expected = "(1, 2)";

        // Act
        var result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        var x1 = -1;
        var y1 = -2;
        var x2 = 1;
        var y2 = 2;

        var expected = "(-1, -2)";

        // Act
        var result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        var x1 = 1;
        var y1 = 2;
        var x2 = -1;
        var y2 = -2;

        var expected = "(-1, -2)";

        // Act
        var result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        var n = 0;

        // Act
        var actual = Factorial.CalculateFactorial(n);
        var expected = 1;

        // Assert
        Assert.AreEqual(expected, actual, "Factorial did not work properly.");
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        var n = 7;

        // Act
        var actual = Factorial.CalculateFactorial(n);
        var expected = 5040;

        // Assert
        Assert.AreEqual(expected, actual, "Factorial did not work properly.");
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        var n = -12;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(n); });
    }
}

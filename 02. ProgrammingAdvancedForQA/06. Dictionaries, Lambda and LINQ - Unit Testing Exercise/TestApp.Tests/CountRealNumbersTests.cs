using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        var input = Array.Empty<int>();

        // Act
        var result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        var input = new int[] { 1 };
        var expected = "1 -> 1";

        // Act
        var result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        var input = new int[] { 1, 1, 2, 2, 2, 3};

        var sb = new StringBuilder();
        sb.AppendLine("1 -> 2");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 1");

        var expected = sb.ToString().Trim();

        // Act
        var result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        var input = new int[] { -1, -1, -2, -2, -2, -3 };

        var sb = new StringBuilder();
        sb.AppendLine("-1 -> 2");
        sb.AppendLine("-2 -> 3");
        sb.AppendLine("-3 -> 1");

        var expected = sb.ToString().Trim();

        // Act
        var result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        var input = new int[] { 0, 0, 0, 0, 0, 0 };
        var expected = "0 -> 6";

        // Act
        var result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}

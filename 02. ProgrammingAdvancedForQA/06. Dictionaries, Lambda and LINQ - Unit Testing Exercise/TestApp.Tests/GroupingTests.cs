using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new();

        // Act
        var result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 4, 2, 30, 5, 1, 17 };

        var sb = new StringBuilder();
        sb.AppendLine("Even numbers: 4, 2, 30");
        sb.AppendLine("Odd numbers: 5, 1, 17");

        var expected = sb.ToString().Trim();

        // Act
        var result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 4, 2, 16 };
        var expected = "Even numbers: 4, 2, 16";

        // Act
        var result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 1, 23, 165 };
        var expected = "Odd numbers: 1, 23, 165";

        // Act
        var result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { -1, -1, -4, -2, -3, -5 };

        var sb = new StringBuilder();
        sb.AppendLine("Odd numbers: -1, -1, -3, -5");
        sb.AppendLine("Even numbers: -4, -2");

        var expected = sb.ToString().Trim();

        // Act
        var result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

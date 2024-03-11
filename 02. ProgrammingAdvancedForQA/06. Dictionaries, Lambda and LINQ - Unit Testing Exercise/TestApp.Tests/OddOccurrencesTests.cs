using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        var result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        var input = new string[] { "text", "text" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        var input = new string[] { "text", "text", "no" };
        var expected = "no";

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        var input = new string[] { "text", "text", "text", "no", "yes", "yes", "yes" };
        var expected = "text no yes";

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        var input = new string[] { "Text", "teXt", "tExt", "nO", "yEs", "yeS", "Yes" };
        var expected = "text no yes";

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

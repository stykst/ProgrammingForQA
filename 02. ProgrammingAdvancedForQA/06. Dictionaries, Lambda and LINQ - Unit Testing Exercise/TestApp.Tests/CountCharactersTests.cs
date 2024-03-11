using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "s", "ssss", "ss" };
        var expected = "s -> 7";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aabbc", "cc", "bbb" };

        var sb = new StringBuilder();
        sb.AppendLine("a -> 2");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 3");

        var expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a@@", "b!!!", "44$" };

        var sb = new StringBuilder();
        sb.AppendLine("a -> 1");
        sb.AppendLine("@ -> 2");
        sb.AppendLine("b -> 1");
        sb.AppendLine("! -> 3");
        sb.AppendLine("4 -> 2");
        sb.AppendLine("$ -> 1");

        var expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

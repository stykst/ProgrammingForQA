using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("Test", 1, "tEsT")]
    [TestCase("Test", 5, "tEsTtEsTtEsTtEsTtEsT")]
    [TestCase("Test Test", 3, "tEsT TeSttEsT TeSttEsT TeSt")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        var input = string.Empty;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, 5));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        var input = "Test Test";

        // Act + Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, -5));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        var input = "Test Test";

        // Act + Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, 0));
    }
}

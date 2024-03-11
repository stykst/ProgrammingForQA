using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        var input = 0;

        // Act
        var result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        var input = 5;

        // Act
        var result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.IsTrue(result.ContainsKey(5));
        Assert.That(result[5], Is.EqualTo(1));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        var input = 123445;
        var expected = new Dictionary<int, int>()
        { 
            { 1, 1 }, 
            { 2, 1 }, 
            { 3, 1 }, 
            { 4, 2 },
            { 5, 1 },
        };

        // Act
        var result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result.Count, Is.EqualTo(5));
        Assert.That(result[1], Is.EqualTo(1));
        Assert.That(result[2], Is.EqualTo(1));
        Assert.That(result[4], Is.EqualTo(2));
        Assert.That(result[5], Is.EqualTo(1));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        var input = -123454321;
        var expected = new Dictionary<int, int>()
        {
            { 1, 2 },
            { 2, 2 },
            { 3, 2 },
            { 4, 2 },
            { 5, 1 },
        };

        // Act
        var result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result.Count, Is.EqualTo(5));
        Assert.That(result[1], Is.EqualTo(2));
        Assert.That(result[2], Is.EqualTo(2));
        Assert.That(result[3], Is.EqualTo(2));
        Assert.That(result[4], Is.EqualTo(2));
        Assert.That(result[5], Is.EqualTo(1));
    }
}

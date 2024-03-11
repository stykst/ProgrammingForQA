using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        var input = new string[] { "gold 8", "silver 30" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        var input = new string[] { "gold 8", "silver 30", "coppeR 17", "cOpper 13", "Gold 18", "siLver 7" };

        var sb = new StringBuilder();
        sb.AppendLine("gold -> 26");
        sb.AppendLine("silver -> 37");
        sb.AppendLine("copper -> 30");

        var expected = sb.ToString().Trim();

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

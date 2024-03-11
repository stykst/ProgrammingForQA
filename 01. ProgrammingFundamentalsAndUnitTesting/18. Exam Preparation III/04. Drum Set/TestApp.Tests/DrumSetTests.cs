using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        // Arrange
        var money = 50.00M;
        var initialQuality = new List<int>() { 1, 6, 7 };
        var commands = new List<string> { };

        // Act + Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands));
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // Arrange
        var money = 50.00M;
        var initialQuality = new List<int>() { 1, 6, 7 };
        var commands = new List<string> { "ouoiuo" };

        // Act + Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        var money = 50.00M;
        var initialQuality = new List<int>() { 1, 6, 7 };
        var commands = new List<string> { "1", "2", "Hit it again, Gabsy!" };
        var expected = "1 3 4\nGabsy has 44.00lv.";

        // Act
        var result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        var money = 0M;
        var initialQuality = new List<int>() { 1, 6, 7 };
        var commands = new List<string> { "1", "2", "3", "Hit it again, Gabsy!" };
        var expected = "1\nGabsy has 0.00lv.";

        // Act
        var result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        var money = 1M;
        var initialQuality = new List<int>() { 1, 6, 7 };
        var commands = new List<string> { "1", "2", "3", "3", "3", "Hit it again, Gabsy!" };
        var expected = "\nGabsy has 1.00lv.";

        // Act
        var result = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

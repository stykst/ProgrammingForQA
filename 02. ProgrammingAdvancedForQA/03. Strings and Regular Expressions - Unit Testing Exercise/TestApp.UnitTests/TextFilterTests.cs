using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        var text = "Test a given method which takes in an array of strings";
        var bannedWords = new string[] { "no", "yes", "banned words"};

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        var text = "Test a given method which takes in an array of strings";
        var bannedWords = new string[] { "given", "an", "strings" };
        var expected = "Test a ***** method which takes in ** array of *******";

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        var text = "Test a given method which takes in an array of strings";
        var bannedWords = new string[] { };
        var expected = text;

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        var text = "Test a given method which takes in an array of strings";
        var bannedWords = new string[] { "Test a given", "an", "strings" };
        var expected = "************ method which takes in ** array of *******";

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

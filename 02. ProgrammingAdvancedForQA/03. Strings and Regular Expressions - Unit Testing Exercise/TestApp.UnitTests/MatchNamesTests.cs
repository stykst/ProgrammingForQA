﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [Test]
    public void Test_Match_ValidNames_ReturnsMatchedNames()
    {
        // Arrange
        string names = "John Smith and Alice Johnson";
        string expected = "John Smith Alice Johnson";

        // Act
        string result = MatchNames.Match(names);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        // Arrange
        string names = "J0hn Sm1th @nd Al!ce J0hnson";

        // Act
        string result = MatchNames.Match(names);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string names = string.Empty;

        // Act
        string result = MatchNames.Match(names);

        // Assert
        Assert.IsEmpty(result);
    }
}

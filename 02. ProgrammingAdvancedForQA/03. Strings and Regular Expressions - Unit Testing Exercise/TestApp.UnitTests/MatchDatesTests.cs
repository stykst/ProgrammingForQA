using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        var input = "31/Dec/2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "23/09/1973, 1/Feb/2016";

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.IsEmpty(result); 
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        var input = "03-Mar-1878, 25/Apr/1915, 31-May-1916, 22/Jun-1941, 25.Dec.1937, 23/09/1973";
        string expected = "Day: 03, Month: Mar, Year: 1878";

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
    }
}

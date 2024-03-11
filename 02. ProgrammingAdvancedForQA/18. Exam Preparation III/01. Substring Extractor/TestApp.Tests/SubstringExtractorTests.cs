using NUnit.Framework;
using System.Data.SqlTypes;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        var input = "The quick brown fox jumps over the lazy dog";
        var start = "The ";
        var end = " dog";
        var expected = "quick brown fox jumps over the lazy";

        // Act
        var result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        var input = "The quick brown fox jumps over the lazy dog";
        var start = "There ";
        var end = " dog";
        var expected = "Substring not found";

        // Act
        var result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        var input = "The quick brown fox jumps over the lazy dog";
        var start = "The ";
        var end = " dogy";
        var expected = "Substring not found";

        // Act
        var result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        var input = "The quick brown fox jumps over the lazy dog";
        var start = "There ";
        var end = " dogy";
        var expected = "Substring not found";

        // Act
        var result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        var input = string.Empty;
        var start = "The ";
        var end = " dog";
        var expected = "Substring not found";

        // Act
        var result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        var input = "The quick brown";
        var start = "The quick ";
        var end = " quick brown";
        var expected = "Substring not found";

        // Act
        var result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

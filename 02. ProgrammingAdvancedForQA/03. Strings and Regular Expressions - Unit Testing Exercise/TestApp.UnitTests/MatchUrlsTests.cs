using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "https://softuni.bg";
        var expexted = new List<string>() { "https://softuni.bg" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "https://softuni.bg https://istyle.bg";
        var expexted = new List<string>() { "https://softuni.bg", "https://istyle.bg" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "\"https://softuni.bg\" \"https://istyle.bg\"";
        var expexted = new List<string>() { "https://softuni.bg", "https://istyle.bg" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }
}

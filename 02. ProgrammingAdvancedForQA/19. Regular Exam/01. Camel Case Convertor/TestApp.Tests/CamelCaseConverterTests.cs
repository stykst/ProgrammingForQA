using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = string.Empty;
        var expected = string.Empty;

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        var input = "test";
        var expected = "test";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        var input = "softuni rocks";
        var expected = "softuniRocks";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        var input = "SoFtUni RegUlar ExAm";
        var expected = "softuniRegularExam";

        // Act
        var result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

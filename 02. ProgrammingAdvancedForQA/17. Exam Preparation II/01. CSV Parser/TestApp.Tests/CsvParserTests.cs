using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        var input = string.Empty;
        var expected = Array.Empty<string>();

        // Act
        var result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        var input = "SingleField";
        var expected = new string[] { "SingleField" };

        // Act
        var result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        var input = "ParseCsv,Single,Field,Returns,Array,With,One,Element";
        var expected = new string[] { "ParseCsv", "Single", "Field", "Returns", "Array", "With", "One", "Element" };

        // Act
        var result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        var input = "ParseCsv  , Single   ,      Field , Returns,Array, With,   One ,Element    ";
        var expected = new string[] { "ParseCsv", "Single", "Field", "Returns", "Array", "With", "One", "Element" };

        // Act
        var result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

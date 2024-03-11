using NUnit.Framework;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        var a = 'A';
        var b = 'B';
        var expected = string.Empty;

        // Act
        var result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        var a = 'B';
        var b = 'A';
        var expected = string.Empty;

        // Act
        var result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        var a = 'A';
        var b = 'C';
        var expected = "B";

        // Act
        var result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        var a = 'D';
        var b = 'G';
        var expected = "E F";

        // Act
        var result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        var a = 'X';
        var b = 'Z';
        var expected = "Y";

        // Act
        var result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

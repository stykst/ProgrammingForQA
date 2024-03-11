using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => Fake.RemoveStringNumbers(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[]? input = new[] { '1', '@', 'a', '3'};

        // Act
        var expected = new[] { '@', 'a' };
        var result = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[]? input = new[] { 'W', '@', 'a', '|' };

        // Act
        var result = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[]? input = Array.Empty<char>();

        // Act
        var result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.IsEmpty(result);
    }
}

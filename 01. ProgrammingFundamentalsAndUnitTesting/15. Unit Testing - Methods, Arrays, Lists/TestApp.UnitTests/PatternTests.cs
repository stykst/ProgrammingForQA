using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => Pattern.SortInPattern(inputArray));
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[]? inputArray = new[] { 1, 2, 1, 3, 4, 10, 12, 15 };

        // Act
        var expected = new[] { 1, 15, 2, 12, 3, 10, 4 };
        var result = Pattern.SortInPattern(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[]? inputArray = Array.Empty<int>();

        // Act
        var result = Pattern.SortInPattern(inputArray);

        // Assert
        CollectionAssert.AreEqual(inputArray, result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[]? inputArray = new[] { 15 };

        // Act
        var result = Pattern.SortInPattern(inputArray);

        // Assert
        CollectionAssert.AreEqual(inputArray, result);
    }
}

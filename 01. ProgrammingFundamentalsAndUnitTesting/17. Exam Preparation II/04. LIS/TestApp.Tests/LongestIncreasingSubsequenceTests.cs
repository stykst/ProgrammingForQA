using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] arr = null;

        //Act + Assert
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(arr));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] arr = Array.Empty<int>();

        // Act
        var result = LongestIncreasingSubsequence.GetLis(arr);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] arr = new[] { 15 };

        // Act
        var result = LongestIncreasingSubsequence.GetLis(arr);

        // Assert
        Assert.That(result, Is.EqualTo("15"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] arr = new[] { 121, 35, 15, 25, 30, 15, 35, 12 };
        var expected = "15 25 30 35";

        // Act
        var result = LongestIncreasingSubsequence.GetLis(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {// Arrange
        int[] arr = new[] { 15, 25, 30, 35 };
        var expected = "15 25 30 35";

        // Act
        var result = LongestIncreasingSubsequence.GetLis(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

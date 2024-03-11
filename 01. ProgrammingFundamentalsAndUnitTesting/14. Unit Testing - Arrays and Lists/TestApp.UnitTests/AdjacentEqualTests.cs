using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        var result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 5 };

        // Act
        var result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 2, 4, 3, 5 };

        // Act
        var result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 8 3 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> list = new() { 2, 2, 4 };

        // Act
        var result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 2, 2, 3, 5 };

        // Act
        var result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("4 3 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 5, 5 };

        // Act
        var result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 10"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 3, 4, 5 };

        // Act
        var result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 6 4 5"));
    }
}

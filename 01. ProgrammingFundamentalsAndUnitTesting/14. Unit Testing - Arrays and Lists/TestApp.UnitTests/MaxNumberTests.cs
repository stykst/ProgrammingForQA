using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new() { 15 };

        // Act
        var maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(15, maxNumber);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 15, 301, 1 };

        // Act
        var maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(301, maxNumber);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -15, -301, -1 };

        // Act
        var maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(-1, maxNumber);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -15, -301, -1, 2, 65, 0 };

        // Act
        var maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(65, maxNumber);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -15, -301, 65, 2, 65, 0 };

        // Act
        var maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(65, maxNumber);
    }
}

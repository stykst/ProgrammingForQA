using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> dict = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5}
        };
        var expected = 5;

        // Act
        var result = Fruits.GetFruitQuantity(dict, "Apple");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> dict = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5}
        };
        var expected = 0;

        // Act
        var result = Fruits.GetFruitQuantity(dict, "Banana");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> dict = new();
        var expected = 0;

        // Act
        var result = Fruits.GetFruitQuantity(dict, "Banana");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> dict = null;
        var expected = 0;

        // Act
        var result = Fruits.GetFruitQuantity(dict, "Banana");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> dict = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5}
        };
        var expected = 0;

        // Act
        var result = Fruits.GetFruitQuantity(dict, null);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();
        Dictionary<string, int> expected = new();

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5}
        };
        Dictionary<string, int> dict2 = new();
        Dictionary<string, int> expected = new();

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Banana", 4 },
            { "Pear", 1}
        };
        Dictionary<string, int> expected = new();

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5 }
        };
        Dictionary<string, int> expected = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5 }
        };

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Kiwi", 3 },
            { "Apple", 5}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Kiwi", 4 },
            { "Apple", 1}
        };
        Dictionary<string, int> expected = new();

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

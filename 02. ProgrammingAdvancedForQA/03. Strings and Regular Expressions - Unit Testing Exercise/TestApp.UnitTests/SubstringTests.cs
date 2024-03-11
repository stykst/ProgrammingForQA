using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "The quick";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "brown fox jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "over the lazy dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "The quick brown fox jumps over the lazy dog";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.AreEqual(string.Empty, output);
    }
}

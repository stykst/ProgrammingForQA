using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual, "Reverse did not work properly.");
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("a", actual, "Reverse did not work properly.");
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "string to be reversed";

        // Act
        string actual = StringReverse.Reverse(input);
        string expected = "desrever eb ot gnirts";

        // Assert
        Assert.AreEqual(expected, actual, "Reverse did not work properly.");
    }
}

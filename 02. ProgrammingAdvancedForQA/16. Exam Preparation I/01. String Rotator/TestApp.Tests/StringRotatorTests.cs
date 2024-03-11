using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = string.Empty;

        // Act
        var result = StringRotator.RotateRight(input, 2);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        var input = "hello";

        // Act
        var result = StringRotator.RotateRight(input, 0);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        var input = "abcdef";
        var expected = "efabcd";

        // Act
        var result = StringRotator.RotateRight(input, 2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        var input = "12345";
        var expected = "45123";

        // Act
        var result = StringRotator.RotateRight(input, -2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        var input = "xyz";
        var expected = "yzx";

        // Act
        var result = StringRotator.RotateRight(input, 5);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

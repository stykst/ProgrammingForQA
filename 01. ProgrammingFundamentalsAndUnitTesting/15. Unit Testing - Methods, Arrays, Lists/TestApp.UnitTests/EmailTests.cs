using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act & Assert
        Assert.IsTrue(Email.IsValidEmail(validEmail));
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string validEmail = "test.example.com";

        // Act & Assert
        Assert.IsFalse(Email.IsValidEmail(validEmail));
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string validEmail = null;

        // Act & Assert
        Assert.IsFalse(Email.IsValidEmail(validEmail));
    }
}

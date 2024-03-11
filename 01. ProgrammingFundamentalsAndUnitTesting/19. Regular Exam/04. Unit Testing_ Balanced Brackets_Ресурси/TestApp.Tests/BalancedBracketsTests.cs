using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        var output = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.IsTrue(output);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        var input = new string[] { "(", ")", "(", ")" };

        // Act
        var output = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.IsTrue(output);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        var input = new string[] { ")", "(", ")" };

        // Act
        var output = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.IsFalse(output);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        var input = new string[] { "(", ")", "(", ")", ")" };

        // Act
        var output = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.IsFalse(output);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        var input = new string[] { "(", "(" };

        // Act
        var output = BalancedBrackets.IsBalanced(input);

        // Assert
        Assert.IsFalse(output);
    }
}

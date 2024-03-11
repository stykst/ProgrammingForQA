using System;
using System.Text;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        var input = new string[] { "apple 1.99 3", "banana 1.25 3", "orange 0.99 2" };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        var input = new string[] { "apple 2 3", "ananas 4 1" };

        var sb = new StringBuilder();
        sb.AppendLine("apple -> 6.00");
        sb.AppendLine("ananas -> 4.00");

        var expected = sb.ToString().Trim();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        var input = new string[] { "apple 2.99 3.5", "ananas 4 1.5" };

        var sb = new StringBuilder();
        sb.AppendLine("apple -> 10.47");
        sb.AppendLine("ananas -> 6.00");

        var expected = sb.ToString().Trim();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

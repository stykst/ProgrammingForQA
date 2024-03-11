using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        _inventory.AddProduct("Sweater", 35.99, 1);
        var expected = $"Product Inventory:{Environment.NewLine}Sweater - Price: $35.99 - Quantity: 1";

        // Act
        var result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        var expected = "Product Inventory:";

        // Act
        var result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("Sweater", 35.99, 1);
        _inventory.AddProduct("Jeans", 55.99, 2);
        var expected = $"Product Inventory:{Environment.NewLine}Sweater - Price: $35.99 - Quantity: 1{Environment.NewLine}Jeans - Price: $55.99 - Quantity: 2";

        // Act
        var result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        var expected = 0d;

        // Act
        var result = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        _inventory.AddProduct("Sweater", 35.99, 1);
        _inventory.AddProduct("Jeans", 55.99, 2);
        var expected = 147.97;

        // Act
        var result = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

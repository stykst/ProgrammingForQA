using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        var s = "string";
        var expected = "gnirts";

        // Act
        var result = this._exceptions.ArgumentNullReverse(s);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        var totalPrice = 10.99m;
        var discount = 15m;

        var expected = 9.3415m;

        // Act
        var result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        var totalPrice = 10.99m;
        var discount = -15m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };
        var index = 1;
        var expected = 2;

        // Act
        var result = this._exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };
        var index = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 10;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        var isLogged = true;
        var expected = "User logged in.";

        // Act
        var result = this._exceptions.InvalidOperationPerformSecureOperation(isLogged);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        var isLogged = false;

        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLogged), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        var input = "12";
        var expected = 12;

        // Act
        var result = this._exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        var input = "InvalidInput";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        var input = new Dictionary<string, int>()
        {
            { "Alex", 32 },
            { "Pesho", 29 },
            { "Kris", 52 },
            { "Gosho", 42 },
            { "Maria", 39 }
        };
        var key = "Kris";
        var expected = 52;

        // Act
        var result = this._exceptions.KeyNotFoundFindValueByKey(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        var input = new Dictionary<string, int>()
        {
            { "Alex", 32 },
            { "Pesho", 29 },
            { "Kris", 52 },
            { "Gosho", 42 },
            { "Maria", 39 }
        };
        var key = "Ivan";

        // Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        var a = 12;
        var b = 13;
        var expected = 25;

        // Act
        var result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        var a = int.MaxValue;
        var b = int.MaxValue;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        var a = int.MinValue;
        var b = int.MinValue;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        var a = 26;
        var b = 13;
        var expected = 2;

        // Act
        var result = this._exceptions.DivideByZeroDivideNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var a = 26;
        var b = 0;

        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(a, b), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        var collection = new int[] { 1, 2, 3 };
        var index = 1;
        var expected = 6;

        // Act
        var result = this._exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collection = null;
        var index = 1;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        var collection = new int[] { 1, 2, 3 };
        var index = 10;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string>? input = new Dictionary<string, string>()
        {
            { "Alex", "32" },
            { "Pesho", "29" },
            { "Kris", "52" },
            { "Gosho", "42" },
            { "Maria", "39" }
        };
        var key = "Kris";
        var expected = 52;

        // Act
        var result = this._exceptions.GetElementAsNumber(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string>? input = new Dictionary<string, string>()
        {
            { "Alex", "32" },
            { "Pesho", "29" },
            { "Kris", "52" },
            { "Gosho", "42" },
            { "Maria", "39" }
        };
        var key = "Ivan";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string>? input = new Dictionary<string, string>()
        {
            { "Alex", "32" },
            { "Pesho", "29" },
            { "Kris", "wa" },
            { "Gosho", "42" },
            { "Maria", "39" }
        };
        var key = "Kris";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<FormatException>());
    }
}

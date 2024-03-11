using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        var n = 1;

        // Act & Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        var n = 7;

        // Act
        var result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.AreEqual(n, result);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long n = 213653465135469098;

        // Act
        var result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.AreEqual(52600291, result);
    }
}

using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;

    [SetUp]
    public void Setup()
    {
        this._vehicles = new();
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";
        var input = new string[]
        {
            "Car/Ford/Focus/120",
            "Car/Toyota/Camry/150",
            "Truck/Volvo/VNL/500"
        };

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        string expected = $"Cars:{Environment.NewLine}Trucks:";
        var input = new string[] { };

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

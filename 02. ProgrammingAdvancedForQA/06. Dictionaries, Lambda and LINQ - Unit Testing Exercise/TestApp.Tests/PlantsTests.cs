using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        var plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        var plants = new string[] { "Rose" };

        var sb = new StringBuilder();

        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("Rose");

        var expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        var plants = new string[] { "rose", "tulip", "gardenia" };

        var sb = new StringBuilder();

        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("rose");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("tulip");
        sb.AppendLine("Plants with 8 letters:");
        sb.AppendLine("gardenia");

        var expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        var plants = new string[] { "Rose", "tuLip", "gardeNia" };

        var sb = new StringBuilder();

        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("Rose");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("tuLip");
        sb.AppendLine("Plants with 8 letters:");
        sb.AppendLine("gardeNia");

        var expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

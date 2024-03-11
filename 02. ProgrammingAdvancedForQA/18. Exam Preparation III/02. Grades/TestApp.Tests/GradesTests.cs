using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            { "Misho", 3 },
            { "Pesho", 4 },
            { "Gosho", 5 },
            { "Sasho", 6 }
        };
        var expected = $"Sasho with average grade 6.00{Environment.NewLine}Gosho with average grade 5.00{Environment.NewLine}Pesho with average grade 4.00";

        // Act
        var result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new();
        var expected = string.Empty;

        // Act
        var result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            { "Misho", 3 },
            { "Pesho", 4 }
        };
        var expected = $"Pesho with average grade 4.00{Environment.NewLine}Misho with average grade 3.00";

        // Act
        var result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            { "Misho", 4 },
            { "Pesho", 4 },
            { "Gosho", 4 },
            { "Sasho", 4 }
        };
        var expected = $"Gosho with average grade 4.00{Environment.NewLine}Misho with average grade 4.00{Environment.NewLine}Pesho with average grade 4.00";

        // Act
        var result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

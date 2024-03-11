using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act + Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        var path = string.Empty;

        // Act + Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        var path = "C:\\Users\\user\\Text.txt";
        var expected = "File name: Text\nFile extension: txt";

        // Act
        var result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        var path = "C:\\Users\\user\\Text";
        var expected = "File name: Text";

        // Act
        var result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        var path = "C:\\?Users\\@user\\#Text.txt";
        var expected = "File name: #Text\nFile extension: txt";

        // Act
        var result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

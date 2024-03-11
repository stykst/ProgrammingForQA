using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        var sender = "Pesho";
        var message = "Saturday at six o'clock";

        // Act
        _chatRoom.SendMessage(sender, message);
        var result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain(sender));
        Assert.That(result, Does.Contain(message));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        var expected = string.Empty;

        // Act
        var result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        var sender = "Pesho";
        var message = "Saturday at six o'clock";
        var sender2 = "Gosho";
        var message2 = "Ok";

        // Act
        _chatRoom.SendMessage(sender, message);
        _chatRoom.SendMessage(sender2, message2);
        var result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain(sender));
        Assert.That(result, Does.Contain(message));
        Assert.That(result, Does.Contain(sender2));
        Assert.That(result, Does.Contain(message2));
    }
}

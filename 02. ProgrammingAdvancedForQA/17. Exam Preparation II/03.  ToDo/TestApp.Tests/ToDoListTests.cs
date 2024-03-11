using System;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        var dueDate = DateTime.Today;
        _toDoList.AddTask("Test task", dueDate);
        var expected = $"To-Do List:{Environment.NewLine}[ ] Test task - Due:";

        // Act
        var result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        var dueDate = DateTime.Today;
        _toDoList.AddTask("Test task", dueDate);
        _toDoList.CompleteTask("Test task");
        var expected = $"To-Do List:{Environment.NewLine}[✓] Test task - Due:";

        // Act
        var result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        var dueDate = DateTime.Today;
        _toDoList.AddTask("Test task", dueDate);

        // Act & Assert
        Assert.That(() => _toDoList.CompleteTask("Test new task"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        var expected = "To-Do List:";

        // Act
        var result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        var dueDate = DateTime.Today;
        _toDoList.AddTask("Test task", dueDate);
        _toDoList.AddTask("Test new task", dueDate);

        // Act
        var result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("Test task"));
        Assert.That(result, Does.Contain("Test new task"));
    }
}

using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;
    
    [SetUp]
    public void SetUp()
    {  
        this._article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        var articleData = new string[]
        {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3"
        };

        // Act
        var result = this._article.AddArticles(articleData);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        var articleData = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Kris",
                    Content = "Something",
                    Title = "Title"
                },
                new Article()
                {
                    Author = "Pesho",
                    Content = "Something new",
                    Title = "New Title"
                }
            }
        };

        var expercted = $"New Title - Something new: Pesho{Environment.NewLine}Title - Something: Kris";

        // Act
        var result = this._article.GetArticleList(articleData, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expercted));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        var articleData = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Kris",
                    Content = "Something",
                    Title = "Title"
                },
                new Article()
                {
                    Author = "Pesho",
                    Content = "Something new",
                    Title = "New Title"
                }
            }
        };

        // Act
        var result = this._article.GetArticleList(articleData, "not-criteria");

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }
}

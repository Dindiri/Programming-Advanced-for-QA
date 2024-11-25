using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    // TODO: write the setup method

    Article _article;
    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] article = { "Article1 Content2 Author1", "Article2 Content2 Author2", "Article3 Content3 Author3" };
        string firstArticleTitle = "Article1";
        string secondArticleContent = "Content2";
        string thirtArticleAuthor = "Author3";

        // Act
        Article result = _article.AddArticles(article);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article1"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        string[] article = { "Cons Content1 Author1", "BedRock Content3 Author3", "Alaska Content2 Author2" };

        Article testArticle = _article.AddArticles(article);
        
        string expected = $"Alaska - Content2: Author2{Environment.NewLine}" +
                          $"BedRock - Content3: Author3{Environment.NewLine}" +
                          $"Cons - Content1: Author1";

        // Act
        string result = _article.GetArticleList(testArticle, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        string[] article = { "Cons Content1 Author1", "BedRock Content3 Author3", "Alaska Content2 Author2" };

        // Act
        string result = _article.GetArticleList(_article, "name");

        // Assert
        Assert.That(result, Is.Empty);
    }
}

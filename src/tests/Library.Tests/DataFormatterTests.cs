using NUnit.Framework;
using TestDateFormat;
namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ExpectedDateFormat()
    {
        string testDate = "10/11/1997";
        var response = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(response, "1997-11-10");
    }
    [Test]
    public void NotExpectedDateFormat()
    {
        string testDate = "1997/11/10";
        var response = DateFormatter.ChangeFormat(testDate);
        Assert.AreNotEqual(response, "1997-11-10");
    }
    [Test]
    public void EmptyValue()
    {
        string testDate = " ";
        var response = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(response, "Error");
    }
}
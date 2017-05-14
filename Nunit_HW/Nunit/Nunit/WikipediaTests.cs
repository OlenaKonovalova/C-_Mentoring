using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Nunit
{
    [TestFixture]
    public class WikipediaTests
    {
        private IWebDriver _driver;
        private WikiPage _page;

        [OneTimeSetUp]
        public void SetUpBrowser()
        {
            _driver = new ChromeDriver(); 
        }

        [SetUp]
        public void SetUpPage()
        {
            _driver.Url = WikiPage.URL;
            _page = new WikiPage(_driver);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }  
        }

        [Test]
        public void ShouldCheckTitle()
        {
            Assert.That(_page.GetTitleText(), Is.EqualTo("Wikipedia").IgnoreCase);
        }

        [Test]
        public void ShouldCheckLanguage()
        {
            Assert.That(_page.ContainsLanguage("Українська"), Is.EqualTo(true));
        }

        [Test]
        public void CheckSearchResultsContainElements()
        {
            var searchString = "Code";
            _page.SerchForText(searchString);
            Assert.That(_page.SearchResults, Is.Not.Empty);
        }

        [Test]
        public void SearchForTextInSearchResults()
        {
            var searchString = "Code";
            _page.SerchForText(searchString);
            foreach (var element in _page.ContainsSearchString())
            {
                Assert.That(element, Does.Contain("Code").IgnoreCase);
            }
        }
    }
}

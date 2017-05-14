using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Nunit
{
    public class WikiPage
    {

        private IWebDriver _driver;

        public WikiPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public const string URL = "https://www.wikipedia.org/";

        [FindsBy(How = How.XPath, Using = ("//h1[@class='central-textlogo']"))]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@class='langlist langlist-large hlist']/ul/li"))]
        public IList<IWebElement> LanguageList { get; set; }

        [FindsBy(How = How.Id, Using = ("js-lang-list-button"))]
        public IWebElement ListButton { get; set; }

        [FindsBy(How = How.Id, Using = ("searchInput"))]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = (".pure-button.pure-button-primary-progressive"))]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ("//li/div[@class='mw-search-result-heading']/a"))]
        public IList<IWebElement> SearchResults { get; set; }

        public string GetTitleText()
        {
            return Title.GetAttribute("title");
        }

        public bool ContainsLanguage(string language)
        {
            ListButton.Click();
           
            foreach (var str in LanguageList)
            {
                if (str.Text.ToLower() == language.ToLower())
                    return true;
            }
            return false;
        }

        public void SerchForText(string searchString)
        {
            SearchField.SendKeys(searchString);
            SearchButton.Click();
        }

        public IList<string> ContainsSearchString()
        {
            List<string> SearchList = new List<string>();
            foreach (var element in SearchResults)
            {
                var title = element.GetAttribute("title");
                SearchList.Add(title);
            }
            return SearchList;
        }
    }
}

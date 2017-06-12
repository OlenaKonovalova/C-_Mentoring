using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow.Assist;

namespace SpecHT
{
    [Binding]
    public class RozetkaTestsSteps
    {
        private readonly RozetkaPage _rozetkaPage;
        public RozetkaTestsSteps()
        {
            _rozetkaPage = new RozetkaPage(CommonSteps.Driver);    
        }

        [Given(@"I am on Rozetka main page")]
        public void GivenIAmOnRozetkaMainPage()
        {
            _rozetkaPage.Driver.Navigate().GoToUrl(RozetkaPage.URL);
        }
        
        [Given(@"I have entered the (.*)")]
        public void GivenIHaveEnteredTheHyundai(string searchText)
        {
            _rozetkaPage.searchField.Clear();
            _rozetkaPage.searchField.SendKeys(searchText);
        }
        
        [Given(@"I have entered credentials")]
        public void GivenIHaveEnteredCredentials(Table table)
        {
            _rozetkaPage.linkToPersonalOffice.Click();

            var credentials = table.CreateInstance<Credentials>();

            _rozetkaPage.name.SendKeys(credentials.UserName);  
            _rozetkaPage.password.SendKeys(credentials.Password);
        }
        
        [Given(@"I am on Smartphone page")]
        public void GivenIAmOnSmartphonePage()
        {
            _rozetkaPage.Driver.Navigate().GoToUrl(RozetkaPage.SmartphoneUrl);
        }
        
        [Given(@"Go to the Smartphone page")]
        public void GivenGoToTheSmartphonePage()
        {
            _rozetkaPage.Driver.Navigate().GoToUrl(RozetkaPage.SmartphoneUrl);
        }

        [Given(@"Filter by brand - ZTE")]
        public void GivenFilterByBrand_Apple()
        {
            _rozetkaPage.zteFilterCheckbox.Click();
        }

        [When(@"I press searchButton")]
        public void WhenIPressSearchButton()
        {
            _rozetkaPage.searchButton.Click();
        }
        
        [When(@"I press enterButton")]
        public void WhenIPressEnterButton()
        {
            _rozetkaPage.enterButton.Click();
        }
        
        [When(@"I filter by brand - Apple")]
        public void WhenIFilterByBrand_Apple()
        {
            _rozetkaPage.appleFilterCheckbox.Click();
        }

        [When(@"Price descending sort is executed")]
        public void WhenPriceDescendingSortIsExecuted()
        {
            _rozetkaPage.dropLink.Click();
            _rozetkaPage.sortLink.Click();         
        }
        
        [Then(@"The results found contain (.*)")]
        public void ThenTheResultsFoundContainHyundai(string searchText)
        {
            var searchItems = _rozetkaPage.searchList.FindElements(By.CssSelector(".g-i-tile")).ToArray();

            var count = 0;
            foreach (var item in searchItems)
            {
                if (item.Text.Contains(searchText))
                {
                    count++;
                }
            }
            Assert.AreEqual(searchItems.Length - 1, count);
        }

        [Then(@"I see my personal page with personal data displayed")]
        public void ThenISeeMyPersonalPageWithPersonalDataDisplayed()
        {
            Assert.That(_rozetkaPage.miniCart, Is.Not.Null);
        }
        
        [Then(@"I see search results which are of Apple brand")]
        public void ThenISeeSearchResultsWhichAreOfAppleBrand()
        {
            var catalogItems = _rozetkaPage.catalog.FindElements(By.CssSelector(".g-i-tile-i-title.clearfix")).ToArray();

            var count = 0;
            foreach (var item in catalogItems)
            {
                if (item.Text.ToLower().Contains("apple"))
                {
                    count++;
                }
            }
            Assert.AreEqual(catalogItems.Length, count);
        }
        
        [Then(@"All the goods displayed are properly sorted")]
        public void ThenAllTheGoodsDisplayedAreProperlySorted()
        {
            var priceList = _rozetkaPage.goodList.FindElements(By.CssSelector(".g-price")).ToArray();

            for (int i = 1; i < priceList.Length; i++)
            {
                    Assert.LessOrEqual(CommonSteps.GetPrice(priceList[i].Text), CommonSteps.GetPrice(priceList[i - 1].Text));
            }
        }
    }
}

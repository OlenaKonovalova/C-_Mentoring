using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW
{
    public class RozetkaSteps
    {
        private readonly IWebDriver _driver;
        private readonly RozetkaPage _page;

        public RozetkaSteps(IWebDriver driver, RozetkaPage rozetkaPage)
        {
            _driver = driver;
            _page = rozetkaPage;
        }

        public void SearchForItem(string searchText)
        {
            _page.SearchField.Clear();
            _page.SearchField.SendKeys(searchText);
            _page.SubmitButton.Click();
        }

        public IWebElement[] FindHyuindaiItems()
        {
            var searchList = _driver.FindElement(By.Name("search_list"));
            return searchList.FindElements(By.CssSelector(".g-i-tile")).ToArray();
        }

        public IWebElement[] FindSmartphoneItems()
        {
            var catalog = RetryTakeGoods(By.Id("catalog_goods_block"));
            return _driver.FindElements(By.CssSelector(".g-i-tile-i-title.clearfix")).ToArray();
        }

        public void ExpandTheList()
        {
            var showAll = _driver.FindElement(By.Name("show_more_parameters"));
            showAll.Click();
        }

        public void SelectCheckBoxes()
        {

           RetryClick(By.Id("filter_producer_69"));
           RetryClick(By.Id("filter_producer_12"));
        }

        public bool RetryClick(By by)
        {
            bool result = false;
            int attempts = 2;
            while (attempts > 0)
            {
                try
                {
                    _driver.FindElement(by).Click();
                    result = true;
                    break;
                }
                catch (Exception e)
                { }
                attempts--;
            }
            return result;
        }

        public void SortDescending()
        {
            RetryClick(By.Name("drop_link"));
            RetryClick(By.Id("filter_sortexpensive"));
            _driver.Manage().Timeouts().PageLoad = new TimeSpan(0,0,10);
        }

        public void DisplayMoreGoods()
        {
            RetryClick(By.CssSelector(".g-i-more-link-text"));     
        }

        public IWebElement[] FindSortedItems()
        {

            var goodList = RetryTakeGoods(By.Name("goods_list"));
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 2, 0);
            return goodList.FindElements(By.CssSelector(".g-price-uah")).ToArray();
        }

        public IWebElement RetryTakeGoods(By by)
        {
            int attempts = 4;
            while (attempts > 0)
            {
                try
                {
                    var element = _driver.FindElement(by);
                    return element;  
                }
                catch (Exception e)
                { }
                attempts--;
            }
            throw new NullReferenceException();
        }
    }
}

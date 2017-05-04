using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Text.RegularExpressions;

namespace HW
{

    [TestFixture]
    public class SearchTests
    {
        private IWebDriver _driver;
        private RozetkaSteps _steps;
        private RozetkaPage _page;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            _driver = new ChromeDriver(options);
            _driver.Navigate().GoToUrl(RozetkaPage.MainURL);
            _page = new RozetkaPage(_driver);
            _steps = new RozetkaSteps(_driver, _page); 
        }

        [Test]
        public void AllHyundaiItemsExist()
        { 
            _steps.SearchForItem("Hyundai");
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 6);
            var items = _steps.FindHyuindaiItems();
            int count = 0;
            foreach (var item in items)
            {
               if (item.Text.ToLower().Contains("hyundai"))
                {
                    count++;
                }
            }
            Assert.AreEqual(items.Length-1, count);
        }

        [Test]
        public void ThirthySecondElementExists()
        {
            _steps.SearchForItem("Hyundai");
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 6);
            var items = _steps.FindHyuindaiItems();
            var lastElement = items[items.Length - 1];
            var element = _driver.FindElement(By.Name("more"));
            Assert.AreEqual(element, lastElement);
        }

        [TearDown]
        public void CloseDriver()
        {
            if (_driver != null)
            _driver.Quit();
        }
    }

    [TestFixture]
    public class FilteringTests
    {
        private IWebDriver _driver;
        private RozetkaSteps _steps;
        private RozetkaPage _page;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            _driver = new ChromeDriver(options);
            _driver.Navigate().GoToUrl(RozetkaPage.SmartphonesURL);
            _page = new RozetkaPage(_driver);
            _steps = new RozetkaSteps(_driver, _page);
        }

        [Test]
        public void FilterByBrand()
        {
            _steps.ExpandTheList();
            _steps.SelectCheckBoxes();
            var items = _steps.FindSmartphoneItems();
            int count = 0;
            foreach (var item in items)
            {
                if (item.Text.ToLower().Contains("apple") || item.Text.ToLower().Contains("samsung"))
                {
                    count++;
                }
            }
            Assert.AreEqual(items.Length, count);
        }

        [Test]
        public void ArrangePriceDescending()
        {
            //_steps.ExpandTheList();
            _steps.SelectCheckBoxes();

          
            _steps.SortDescending();
            _steps.DisplayMoreGoods();

            var goodList = _steps.FindSortedItems();

            for (int i = 1; i < goodList.Length; i++)
            {
                Assert.LessOrEqual(GetPrice(goodList[i].Text), GetPrice(goodList[i - 1].Text));
            }
        }

        private int GetPrice(string stringPrice)
        {
            stringPrice = Regex.Replace(stringPrice, @"\s+", "");
            stringPrice = stringPrice.Remove(stringPrice.Length - 3, 3);
            return Int32.Parse(stringPrice);
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
                _driver.Quit();
        }
    }
}

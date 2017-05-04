using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class RozetkaPage
    {
        public const string MainURL = "http://rozetka.com.ua";
        public const string SmartphonesURL = "http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/";
        private IWebDriver _driver;

        public RozetkaPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchField => _driver.FindElement(By.CssSelector(".rz-header-search-input-text.passive"));
        public IWebElement SubmitButton => _driver.FindElement(By.Name("rz-search-button"));
    }
}

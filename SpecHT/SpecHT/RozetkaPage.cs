using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecHT
{
    public class RozetkaPage
    {
        public IWebDriver Driver { get; }

        public RozetkaPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public const string URL = "https://rozetka.com.ua";

        public const string SmartphoneUrl = "http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/";

        [FindsBy(How = How.CssSelector, Using = (".rz-header-search-input-text.passive"))]
        public IWebElement searchField { get; set; }

        [FindsBy(How = How.XPath, Using = (".//span[@id='header_user_menu_parent']/a"))]
        public IWebElement linkToPersonalOffice { get; set; }

        [FindsBy(How = How.Name, Using = ("login"))]
        public IWebElement name { get; set; }

        [FindsBy(How = How.Name, Using = ("password"))]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Name, Using = ("rz-search-button"))]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.Name, Using = ("auth_submit"))]
        public IWebElement enterButton { get; set; }

        [FindsBy(How = How.Id, Using = ("filter_producer_69"))]
        public IWebElement appleFilterCheckbox{ get; set; }

        [FindsBy(How = How.Id, Using = ("filter_producer_81"))]
        public IWebElement zteFilterCheckbox { get; set; }

        [FindsBy(How = How.Name, Using = ("drop_link"))]
        public IWebElement dropLink { get; set; }

        [FindsBy(How = How.Id, Using = ("filter_sortexpensive"))]
        public IWebElement sortLink { get; set; }

        [FindsBy(How = How.Name, Using = ("search_list"))]
        public IWebElement searchList { get; set; }

        [FindsBy(How = How.Id, Using = ("mini-cart-block"))]
        public IWebElement miniCart { get; set; }

        [FindsBy(How = How.Id, Using = ("catalog_goods_block"))]
        public IWebElement catalog { get; set; }

        [FindsBy(How = How.Name, Using = ("goods_list"))]
        public IWebElement goodList { get; set; }
    }
}

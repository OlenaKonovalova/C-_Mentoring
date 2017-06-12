using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecHT
{
    [Binding]
   public static class CommonSteps
    {
        public static IWebDriver Driver { get; set; }

        public static int GetPrice(string stringPrice)
        {
            stringPrice = Regex.Replace(stringPrice, @"\s+", "");
            stringPrice = stringPrice.Remove(stringPrice.Length - 3, 3);
            return Int32.Parse(stringPrice);
        }

        [BeforeFeature]
        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            Driver = new ChromeDriver(options);
        }

        [AfterFeature]
        public static void KillBrowser()
        {
            Driver.Quit();
        }

    }
}

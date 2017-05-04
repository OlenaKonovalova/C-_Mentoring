//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SeleniumWebDriver
//{
//    public static class DriverExtensions
//    {
//        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
//        {
//            if (timeoutInSeconds > 0)
//            {
//                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
//                return wait.Until(drv => drv.FindElement(by));
//            }
//            return driver.FindElement(by);
//        }

//        public static void WaitForElementToAppear(this ISearchContext driver, By locator)
//        {
//            driver.TimerLoop(() =>
//            {
//                var element = driver.FindElement(locator);
//                return element.Displayed && element.Enabled;
//            }, false, "Timeout: Element not visible at: " + locator);
//        }

//        public static void WaitForElementToAppear(this ISearchContext driver, By locator, int seconds)
//        {
//            driver.TimerLoop(() =>
//            {
//                var _driver = driver as IWebDriver;
//                var element = _driver.FindElement(locator, seconds);
//                return element.Displayed && element.Enabled;
//            }, false, "Timeout: Element not visible at: " + locator);
//        }

//        public static void TimerLoop(this ISearchContext driver, Func<bool> isComplete, bool exceptionCompleteResult, string timeoutMsg)
//        {

//            const int timeoutinteger = 100;

//            for (int second = 0; ; second++)
//            {
//                try
//                {
//                    if (isComplete())
//                        return;
//                    if (second >= timeoutinteger)
//                        throw new TimeoutException(timeoutMsg);
//                }
//                catch (Exception ex)
//                {
//                    if (exceptionCompleteResult)
//                        return;
//                    if (second >= timeoutinteger)
//                        throw new TimeoutException(timeoutMsg, ex);
//                }
//                Thread.Sleep(100);
//            }
//        }
//    }
//}

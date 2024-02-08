using OpenQA.Selenium;

namespace Drivers
{
    public static class BrowserDriverExtensions
    {
        public static void QuitDriver(this BrowserDriver browserDriver)
        {
            if (browserDriver.WebDriver is not null)
            {
                browserDriver.WebDriver.Quit();
            }
        }

        public static void Navigate(this BrowserDriver browserDriver, string url)
        {
            browserDriver.WebDriver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElement(this BrowserDriver browserDriver, By by)
        {
            return browserDriver.WebDriver.FindElement(by);
        }

        public static void Click(this BrowserDriver browserDriver, IWebElement element)
        {
            element.Click();
        }

        public static void Type(this BrowserDriver browserDriver, IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static string GetPageSource(this BrowserDriver browserDriver)
        {
            return browserDriver.WebDriver.PageSource;
        }
    }
}

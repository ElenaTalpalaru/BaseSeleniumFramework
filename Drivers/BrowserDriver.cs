using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drivers
{
    public class BrowserDriver
    {
        private IWebDriver _webDriver;
        
        public IWebDriver WebDriver { get
            {
                return _webDriver;
            }
            set
            {
                _webDriver = value;
            }
        }

        public BrowserDriver(string driverType)
        {
            if (_webDriver is null)
            {
                switch (driverType)
                {
                    case "chrome":
                        {
                            _webDriver = new ChromeDriver();
                            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                            _webDriver.Manage().Window.Maximize();
                            break;
                        }
                    default:
                        {
                            _webDriver = new ChromeDriver();
                            break;
                        }
                }
            }
        }


    }
}

using Drivers;

namespace GoogleBussinessLayer.PageObjects
{
    public abstract class BasePage
    {
        public BrowserDriver BrowserDriver { get; set; }

        public BasePage(BrowserDriver browserDriver)
        {
            BrowserDriver = browserDriver;
        }
    }
}

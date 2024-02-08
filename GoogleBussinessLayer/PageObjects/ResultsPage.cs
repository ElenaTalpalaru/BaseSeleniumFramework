using Drivers;

namespace GoogleBussinessLayer.PageObjects
{
    public class ResultsPage : BasePage
    {
        public ResultsPage(BrowserDriver browserDriver) : base(browserDriver)
        {
        }

        public string GetContent()
        {
            return BrowserDriver.GetPageSource();
        }
    }
}

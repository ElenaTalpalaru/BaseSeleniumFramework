using Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleBussinessLayer.PageObjects
{
    public class SearchPage : BasePage
    {
        private By Searchbar => By.Name("q");
        private By SearchButton => By.Name("btnK");


        public SearchPage(BrowserDriver browserDriver) : base(browserDriver)
        {
        }

        public void SearchForPharase(string text)
        {
            var searchbar = BrowserDriver.FindElement(Searchbar);
            BrowserDriver.Type(searchbar, text);
            var searchButton = BrowserDriver.FindElement(SearchButton);
            BrowserDriver.Click(searchButton);

        }
    }
}

using Drivers;
using FluentAssertions;
using GoogleBussinessLayer.Configurations;
using GoogleBussinessLayer.PageObjects;

namespace GoogleTests.SearchPageTests
{
    public class SearchTests
    {
        private BrowserDriver browserDriver;
        private SearchPage searchPage;
        private ResultsPage resultsPage;

        [SetUp]
        public void Setup()
        {
            browserDriver = new BrowserDriver("chrome");
            searchPage = new SearchPage(browserDriver);
            resultsPage = new ResultsPage(browserDriver);
        }

        [TearDown]
        public void tearDown()
        {
            browserDriver.QuitDriver();
        }

        [Test]
        public void ShouldSearchTextAndReturnResults()
        {
            // Arrange
            
            browserDriver.Navigate(Config.BaseUrl);

            // Act
            searchPage.SearchForPharase("test");

            // Assert
            resultsPage.GetContent().Should().Contain("text");
        }
    }
}

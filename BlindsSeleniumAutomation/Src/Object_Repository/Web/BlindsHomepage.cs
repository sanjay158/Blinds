using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BlindsSelenium
{
    public static class Pages
    {
        public static BlindsHomepage BlindsHomepage
        {
            get
            {
                var blindsHomepage = new BlindsHomepage();
                PageFactory.InitElements(Browser.Driver, blindsHomepage);
                return blindsHomepage;
            }
        }

        public static ProductSearchpage ProductSearchpage
        {
            get
            {
                var productSearchpage = new ProductSearchpage();
                PageFactory.InitElements(Browser.Driver, productSearchpage);
                return productSearchpage;
            }
        }
    }

    public class BlindsHomepage
    {
        public void Goto()
        {
            Browser.Goto(GetEnvironment.GetUrl());
        }

        public void EnterSearchKeyword(string textToSearch)
        {
            var searchBox = Browser.Driver.FindElement(By.Id("gcc-inline-search"));
            searchBox.Click();
            searchBox.SendKeys(textToSearch);
        }

        public void ClickSearchButton()
        {
            var Begin = Browser.Driver.FindElement(By.Id("gcc-inline-search-submit"));
            Begin.Click();
        }

    }
    public class ProductSearchpage
    {
        public void ClickOnSortBy(string sortBy)
        {
            var sort = Browser.Driver.FindElement(By.LinkText(sortBy));
            sort.Click();
        }
    }

}

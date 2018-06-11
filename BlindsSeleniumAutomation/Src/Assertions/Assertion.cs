using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace BlindsSelenium
{

    public class BlindsAssertions
    {
       
        public static void VerifySearchResults()
        {
            var searchResults = Browser.Driver.FindElement(By.Id("gcc-search-results"));
            Assert.IsTrue(searchResults.Displayed);
        }

        public static void VerifySearchResultsAreSortedBy(string sortBY)
        {
           
            IList <IWebElement> priceFromUI = Browser.Driver.FindElements(By.XPath("//span[contains(text(), '$')]"));

            List<float> priceList = new List<float>();

            foreach (IWebElement e in priceFromUI)
            {
                priceList.Add(float.Parse(e.Text.Replace("$", "")));
            }

            if (!ascendingCheck(priceList))
            {
                Assert.Fail("Product prices are not in asending order");
            }
        }

        private static bool ascendingCheck(List<float> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                float a = data[i];
                if ((data[i] > data[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

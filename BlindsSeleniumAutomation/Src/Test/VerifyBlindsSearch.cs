using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BlindsSelenium
{
    [TestClass]
    public class VerifyBlindsSearch
    {
        [AssemblyCleanup]
        public static void SendResult()
        {
            //TODOSend Email with results after the execution
            Browser.Dipose();
        }

        [TestCleanup]
        public void TearDown()
        {
            Browser.Close();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Datasheets\\BlindsTestData.csv", "BlindsTestData#csv", DataAccessMethod.Sequential)]
        public void VerifySearchResultsByPriceLowToHigh()
        {
            string searchKeyword = testContextInstance.DataRow["SearchKeyword"].ToString();
            string sortBY = testContextInstance.DataRow["SortBy"].ToString();

            try
            {
                //Launch the browser
                Pages.BlindsHomepage.Goto();
                //Enter the search keyword: Dataset
                Pages.BlindsHomepage.EnterSearchKeyword(searchKeyword);
                //Click on the search button
                Pages.BlindsHomepage.ClickSearchButton();

                //Verify the search results are visible
                BlindsAssertions.VerifySearchResults();

                //Click on sort by: Dataset
                Pages.ProductSearchpage.ClickOnSortBy(sortBY);

                //Verify search results are sorted by fliter criteria: Dataset
                BlindsAssertions.VerifySearchResultsAreSortedBy(sortBY);
            }
            catch (Exception e)
            {
                Assert.Fail("Test Failed" + e);
            }
        }


        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}

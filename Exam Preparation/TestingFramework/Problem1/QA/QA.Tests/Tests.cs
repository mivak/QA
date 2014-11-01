namespace QA.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ArtOfTest.WebAii.Core;

    using QA.Core;
    using QA.TestingFramework;

    [TestClass]
    public class Tests : BaseTest
    {
        public Page Page { get; set; }

        protected override void TestInit()
        {
            this.Page = new Page();
            this.Page.GoToPage();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifyClientDataSourcePage()
        {
            this.Page.GoToClientDataSource();
            this.Page.Validator.ClientDataSourcePage();
        }

        [TestMethod]
        public void VerifyIntegrationWithRadGridPage()
        {
            this.Page.GoToIntegrationWithRadGrid();
            this.Page.Validator.IntegrationWithRadGridPage();
        }

        [TestMethod]
        public void VerifyNewRecordAdded()
        {
            string companyName = "Telerik";
            string contactName = "Pesho";
            string contactTitle = "QA";

            this.Page.AddRecord(companyName, contactName, contactTitle);
            this.Page.Validator.RecordAdded(companyName,
                contactName, contactTitle);
        }
    }
}
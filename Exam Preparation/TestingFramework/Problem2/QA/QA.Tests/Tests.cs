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
        public void VerifyDataFormDemoName()
        {
            this.Page.GoToDataForm();
            this.Page.Validator.DataFormDemoName();
        }

        [TestMethod]
        public void VerifyIntegrationWithRadGridDemoName()
        {
            this.Page.GoToIntegrationWithRadGrid();
            this.Page.Validator.RadGridDemoName();
        }

        [TestMethod]
        public void VerifyRecordUpdated()
        {
            string firstName = "Pesho";
            string lastName = "Ivanov";
            string homePhone = "(203) 123-4567";
            string extension = "1234";

            this.Page.EditRecord(firstName, lastName,
                homePhone, extension);
            this.Page.Validator.RecordUpdated(firstName,
                lastName, homePhone, extension);
        }
    }
}
namespace QA.TelerikAcademy.Tests.Documents
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Documents;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class Documents : BaseTest
    {
        public DocumentsPage DocumentsPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.DocumentsPage = PageProvider<DocumentsPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.KidsAdmin);
            NavigationService.NavigateToPage(this.User, this.DocumentsPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(203), Priority(2)]
        public void VerifyDocumentsBackToAdministrationButtonWorksCorrectly()
        {
            this.DocumentsPage.Map.BackToAdministrationButton.Click();
            this.DocumentsPage.Validator.VerifyAdminPageHeader();
        }       
    }
}

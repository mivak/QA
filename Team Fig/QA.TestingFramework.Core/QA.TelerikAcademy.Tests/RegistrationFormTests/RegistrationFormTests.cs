namespace QA.TelerikAcademy.Tests.RegistrationFormTests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage;

    [TestClass]
    public class RegistrationFormTests : BaseTest
    {
        public RegistrationFormPage RegistrationFormPage { get; set; }

        protected override void TestInit()
        {
            Manager.Current.ActiveBrowser.Window.Maximize();

            this.RegistrationFormPage = new RegistrationFormPage();
            this.RegistrationFormPage.GoToRegistrationFormModule();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifyLinkToSofiaRegistrationForm()
        {
            this.RegistrationFormPage.GoToSofiaRegistrationForm();
            this.RegistrationFormPage.Validator
                .RegistrationFormPageTitle();
        }
    }
}
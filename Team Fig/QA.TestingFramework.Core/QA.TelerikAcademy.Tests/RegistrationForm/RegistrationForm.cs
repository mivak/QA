namespace QA.TelerikAcademy.Tests.RegistrationForm
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class RegistrationForm : BaseTest
    {
        public RegistrationFormPage RegistrationFormPage { get; set; }

        protected override void TestInit()
        {
            this.RegistrationFormPage = PageProvider<RegistrationFormPage>.Instance;
            NavigationService.NavigateToPage(RegistrationFormPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(496), Priority(1)]
        public void VerifyLinkToSofiaRegistrationForm()
        {
            this.RegistrationFormPage.GoToSofiaRegistrationForm();
            this.RegistrationFormPage.Validator
                .RegistrationFormPageTitle();
        }
    }
}
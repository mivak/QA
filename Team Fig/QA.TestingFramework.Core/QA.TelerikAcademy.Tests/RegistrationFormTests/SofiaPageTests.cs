namespace QA.TelerikAcademy.Tests.RegistrationFormTests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia;

    [TestClass]
    public class SofiaPageTests : BaseTest
    {
        public SofiaPage SofiaPage { get; set; }

        protected override void TestInit()
        {
            Manager.Current.ActiveBrowser.Window.Maximize();

            this.SofiaPage = new SofiaPage();
            this.SofiaPage.GoToSofiaPage();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifyRegisterValidUser()
        {
            string username = this.SofiaPage
                .GetRandomEnglishString(6);
            this.SofiaPage.RegisterValidUser(username);
            this.SofiaPage.Validator.UserProfile(username);
        }

        [TestMethod]
        public void VerifyUsernameIsRequired()
        {
            string username = string.Empty;
            this.SofiaPage.RegisterValidUser(username);
            this.SofiaPage.Validator.UsernameIsRequired();
        }

        [TestMethod]
        public void VerifyPasswordIsRequired()
        {
            this.SofiaPage.RegisterEmptyPasswordUser();
            this.SofiaPage.Validator.PasswordIsRequired();
        }

        [TestMethod]
        public void VerifyPasswordMatchIsRequired()
        {
            this.SofiaPage.RegisterPasswordNotMatchUser();
            this.SofiaPage.Validator.PasswordMatchIsRequired();
        }

        [TestMethod]
        public void VerifyEmailIsRequired()
        {
            this.SofiaPage.RegisterEmptyEmailUser();
            this.SofiaPage.Validator.EmailIsRequired();
        }

        [TestMethod]
        public void VerifyFirstNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyFirstNameBgUser();
            this.SofiaPage.Validator.FirstNameBgIsRequired();
        }

        [TestMethod]
        public void VerifyLastNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyLastNameBgUser();
            this.SofiaPage.Validator.LastNameBgIsRequired();
        }

        [TestMethod]
        // Reported bug
        public void VerifyDateOfBirthIsRequired()
        {
            this.SofiaPage.RegisterEmptyDateOfBirthUser();
            this.SofiaPage.Validator.DateOfBirthIsRequired();
        }

        [TestMethod]
        public void VerifyGenderIsRequired()
        {
            this.SofiaPage.RegisterEmptyGenderUser();
            this.SofiaPage.Validator.GenderIsRequired();
        }

        [TestMethod]
        // Reported bug
        public void VerifyClassIsRequired()
        {
            this.SofiaPage.RegisterEmptyClassUser();
            this.SofiaPage.Validator.ClassIsRequired();
        }

        [TestMethod]
        public void VerifyParentFirstNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentFirstNameBgUser();
            this.SofiaPage.Validator.ParentFirstNameBgIsRequired();
        }

        [TestMethod]
        public void VerifyParentLastNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentLastNameBgUser();
            this.SofiaPage.Validator.ParentLastNameBgIsRequired();
        }

        [TestMethod]
        public void VerifyParentEmailIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentEmailUser();
            this.SofiaPage.Validator.ParentEmailIsRequired();
        }

        [TestMethod]
        public void VerifyParentPhoneIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentPhoneUser();
            this.SofiaPage.Validator.ParentPhoneIsRequired();
        }

        [TestMethod]
        public void VerifyUsernameMinLength()
        {
            this.SofiaPage.EnterShorterUsername();
            this.SofiaPage.Validator.UsernameLength();
        }

        [TestMethod]
        public void VerifyUsernameMaxLength()
        {
            this.SofiaPage.EnterLongerUsername();
            this.SofiaPage.Validator.UsernameLength();
        }

        [TestMethod]
        public void VerifyUsernameSymbolsValidation()
        {
            this.SofiaPage.EnterInvalidUsername();
            this.SofiaPage.Validator.UsernameSymbolsValidation();
        }
    }
}
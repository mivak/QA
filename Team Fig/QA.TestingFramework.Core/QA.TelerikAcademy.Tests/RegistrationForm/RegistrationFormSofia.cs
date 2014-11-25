namespace QA.TelerikAcademy.Tests.RegistrationForm
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class RegistrationFormSofia : BaseTest
    {
        public SofiaPage SofiaPage { get; set; }

        protected override void TestInit()
        {
            this.SofiaPage = PageProvider<SofiaPage>.Instance;
            NavigationService.NavigateToPage(SofiaPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(215), Priority(1)]
        public void VerifyRegisterValidUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            this.SofiaPage.RegisterValidUser(username);
            this.SofiaPage.Validator.UserProfile(username);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(226), Priority(2)]
        public void VerifyUsernameIsRequired()
        {
            string username = string.Empty;
            this.SofiaPage.RegisterValidUser(username);
            this.SofiaPage.Validator.UsernameIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(227), Priority(2)]
        public void VerifyPasswordIsRequired()
        {
            this.SofiaPage.RegisterEmptyPasswordUser();
            this.SofiaPage.Validator.PasswordIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(497), Priority(2)]
        public void VerifyPasswordMatchIsRequired()
        {
            this.SofiaPage.RegisterPasswordNotMatchUser();
            this.SofiaPage.Validator.PasswordMatchIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(228), Priority(2)]
        public void VerifyPasswordAgainIsRequired()
        {
            this.SofiaPage.RegisterEmptyPasswordAgainUser();
            this.SofiaPage.Validator.PasswordAgainIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(229), Priority(2)]
        public void VerifyEmailIsRequired()
        {
            this.SofiaPage.RegisterEmptyEmailUser();
            this.SofiaPage.Validator.EmailIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(230), Priority(2)]
        public void VerifyFirstNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyFirstNameBgUser();
            this.SofiaPage.Validator.FirstNameBgIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(231), Priority(2)]
        public void VerifyLastNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyLastNameBgUser();
            this.SofiaPage.Validator.LastNameBgIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(363), Priority(2)]
        [KnownIssue(2254)]
        public void VerifyDateOfBirthIsRequired()
        {
            this.SofiaPage.RegisterEmptyDateOfBirthUser();
            this.SofiaPage.Validator.DateOfBirthIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(233), Priority(2)]
        public void VerifyGenderIsRequired()
        {
            this.SofiaPage.RegisterEmptyGenderUser();
            this.SofiaPage.Validator.GenderIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(234), Priority(2)]
        [KnownIssue(2255)]
        public void VerifyClassIsRequired()
        {
            this.SofiaPage.RegisterEmptyClassUser();
            this.SofiaPage.Validator.ClassIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(235), Priority(2)]
        public void VerifyParentFirstNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentFirstNameBgUser();
            this.SofiaPage.Validator.ParentFirstNameBgIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(236), Priority(2)]
        public void VerifyParentLastNameBgIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentLastNameBgUser();
            this.SofiaPage.Validator.ParentLastNameBgIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(237), Priority(2)]
        public void VerifyParentEmailIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentEmailUser();
            this.SofiaPage.Validator.ParentEmailIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(238), Priority(2)]
        public void VerifyParentPhoneIsRequired()
        {
            this.SofiaPage.RegisterEmptyParentPhoneUser();
            this.SofiaPage.Validator.ParentPhoneIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(498), Priority(2)]
        public void VerifyUsernameMinLength()
        {
            this.SofiaPage.EnterShorterUsername();
            this.SofiaPage.Validator.UsernameLength();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(499), Priority(2)]
        public void VerifyUsernameMaxLength()
        {
            this.SofiaPage.EnterLongerUsername();
            this.SofiaPage.Validator.UsernameLength();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(500), Priority(2)]
        public void VerifyUsernameSymbolsValidation()
        {
            this.SofiaPage.EnterInvalidUsername();
            this.SofiaPage.Validator.UsernameSymbolsValidation();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(501), Priority(2)]
        public void VerifyPasswordMinLength()
        {
            this.SofiaPage.EnterShorterPassword();
            this.SofiaPage.Validator.PasswordLength();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(502), Priority(2)]
        public void VerifyEmailLength()
        {
            this.SofiaPage.EnterLongerEmail();
            this.SofiaPage.Validator.EmailLength();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(222), Priority(2)]
        public void VerifyEmailValidation()
        {
            this.SofiaPage.EnterInvalidEmail();
            this.SofiaPage.Validator.EmailInvalid();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(223), Priority(2)]
        public void VerifyFirstNameBgInvalidSymbolsValidation()
        {
            this.SofiaPage.EnterInvalidSymbolsInFirstNameBg();
            this.SofiaPage.Validator.FirstNameBgInvalid();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(503), Priority(2)]
        public void VerifyFirstNameBgMinLength()
        {
            this.SofiaPage.EnterShorterFirstNameBg();
            this.SofiaPage.Validator.FirstNameBgInvalid();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(504), Priority(2)]
        public void VerifyFirstNameBgMaxLength()
        {
            this.SofiaPage.EnterLongerFirstNameBg();
            this.SofiaPage.Validator.FirstNameBgLength();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(508), Priority(2)]
        [KnownIssue(2359)]
        public void VerifyPasswordXssValidation()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            this.SofiaPage.RegisterUserWithXssPassword(username);
            this.SofiaPage.Validator.UserProfile(username);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(509), Priority(2)]
        [KnownIssue(2360)]
        public void VerifyAdditionalInformationXssValidation()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            this.SofiaPage.RegisterUserWithXssAdditionlInfo(username);
            this.SofiaPage.Validator.UserProfile(username);
        }
    }
}
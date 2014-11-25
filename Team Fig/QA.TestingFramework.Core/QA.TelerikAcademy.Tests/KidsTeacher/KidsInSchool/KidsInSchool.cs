namespace QA.TelerikAcademy.Tests.KidsTeacher.KidsInSchool
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class KidsInSchool:BaseTest
    {
        public KidsInSchoolPage KidsInSchoolPage { get; set; }
        public IUser User { get; set; }

        private delegate void ValidateEntry(RegistrationEntry entry);

        protected override void TestInit()
        {
            Manager.Current.Settings.ExecutionDelay = 100;

            this.KidsInSchoolPage = PageProvider<KidsInSchoolPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.Teacher);
            NavigationService.NavigateToPage(this.User, this.KidsInSchoolPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(406), Priority(1)]
        public void RegisterExistingUserToTeacherSchool()
        {
            var userToRegister = new RegistrationEntry();

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister, 
                () => this.KidsInSchoolPage.Validator.UserIsRegistered(userToRegister.Username), true);

            this.KidsInSchoolPage.RemoveUserFromSchool(userToRegister.Username);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(407), Priority(1)]
        public void RegisterExistingUserToTeacherSchoolAllData()
        {
            var userToRegister = new RegistrationEntry(parentMobilePhone:"0888123456");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.Validator.UserIsRegistered(userToRegister.Username), true);

            this.KidsInSchoolPage.RemoveUserFromSchool(userToRegister.Username);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(408), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolNoUsername()
        {
            var userToRegister = new RegistrationEntry(username: "");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.UsernameEmpty(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(409), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolNoEmail()
        {
            var userToRegister = new RegistrationEntry(email: "");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.EmailEmpty(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(468), Priority(2)]
        [KnownIssue(2277)]
        public void RegisterExistingUserToTeacherSchoolInvalidEmail()
        {
            var userToRegister = new RegistrationEntry(email: "invalid@value");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.EmailInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(410), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolNoParentFirstName()
        {
            var userToRegister = new RegistrationEntry(parentFirstName: "");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameEmpty(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(471), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentFirstNameIsUnder2CharsLong()
        {
            var userToRegister = new RegistrationEntry(parentFirstName: "А");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(472), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentFirstNameContainsDigits()
        {
            var userToRegister = new RegistrationEntry(parentFirstName: "Име12");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(473), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentFirstNameContainsSpecialChars()
        {
            var userToRegister = new RegistrationEntry(parentFirstName: "<h1>Име</h1>");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(474), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentFirstNameContainsLatinLetters()
        {
            var userToRegister = new RegistrationEntry(parentFirstName: "ИмеNaРодител");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(475), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentFirstNameIsOver30CharsLong()
        {
            var userToRegister = new RegistrationEntry(parentFirstName: "Аааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааа");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameTooLong(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(442), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolNoParentLastName()
        {
            var userToRegister = new RegistrationEntry(parentLastName: "");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameEmpty(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(480), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentLastNameOver30Chars()
        {
            var userToRegister = new RegistrationEntry(parentLastName: "Ааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааа");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameTooLong(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(476), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentLastNameUnder2Chars()
        {
            var userToRegister = new RegistrationEntry(parentLastName: "А");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(477), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentLastNameContainsDigits()
        {
            var userToRegister = new RegistrationEntry(parentLastName: "Фамилия12");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(478), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentLastNameContainsSpecialChars()
        {
            var userToRegister = new RegistrationEntry(parentLastName: "Фам!или@я#");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(479), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentLastNameContainsLatinLetters()
        {
            var userToRegister = new RegistrationEntry(parentLastName: "ФамилияNaRoditel");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(465), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolNoParentEmail()
        {
            var userToRegister = new RegistrationEntry(parentEmail: "");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentEmailEmpty(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(482), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentEmailOnlyDigitsSpecialChars()
        {
            var userToRegister = new RegistrationEntry(parentEmail: "1234@123.123");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentEmailInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(481), Priority(2)]
        public void RegisterExistingUserToTeacherSchoolParentEmailNotFittingPattern()
        {
            var userToRegister = new RegistrationEntry(parentEmail: "invalid");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.ParentEmailInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(466), Priority(2)] 
        [KnownIssue(2266)]
        public void RegisterNonExistingUserToTeacherSchool()
        {
            var userToRegister = new RegistrationEntry(username: "random.user2");

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister,
                () => this.KidsInSchoolPage.RegistrationForm.Validator.UsernameIsInvalid(), false);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(467), Priority(2)] 
        public void RegisterDuplicateUserToTeacherSchool()
        {
            var userToRegister = new RegistrationEntry();

            this.KidsInSchoolPage.RegisterDuplicateUserToSchool(userToRegister);
        }
    }
}

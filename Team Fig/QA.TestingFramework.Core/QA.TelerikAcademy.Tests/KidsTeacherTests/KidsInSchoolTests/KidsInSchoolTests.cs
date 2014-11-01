namespace QA.TelerikAcademy.Tests.KidsTeacherTests.KidsInSchoolTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests;
    using System.Threading;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool;
    using ArtOfTest.WebAii.Win32.Dialogs;

    [TestClass]
    public class KidsInSchoolTests:BaseTest
    {
        public KidsInSchoolPage KidsInSchoolPage { get; set; }

        public LoginPage LoginPage { get; set; }

        protected override void TestInit()
        {
            Manager.Current.Settings.ExecutionDelay = 200;

            this.LoginPage = new LoginPage();
            this.KidsInSchoolPage = new KidsInSchoolPage();

            var kidsTeacherUser = User.Get(UserRoles.Teacher);
            this.LoginPage.LoginUser(kidsTeacherUser);
            this.LoginPage.Validator.UserLabel(kidsTeacherUser);

            this.KidsInSchoolPage.Navigate();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.KidsInSchoolPage.Map.KidsInSchoolLink.Wait.ForExists(10000);
            this.KidsInSchoolPage.Map.KidsInSchoolLink.Click();

            this.KidsInSchoolPage.Map.ModuleTitle.Wait.ForExists(10000);
            this.KidsInSchoolPage.Validator.ModuleTitle();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchool()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RemoveUserFromSchool(userToRegister.Username);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchoolAllData()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = "0888123456"
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RemoveUserFromSchool(userToRegister.Username);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchoolNoUsername()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.RegistrationForm.Validator.UsernameEmpty();

            this.KidsInSchoolPage.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchoolNoEmail()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.RegistrationForm.Validator.EmailEmpty();

            this.KidsInSchoolPage.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchoolNoParentFirstName()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.RegistrationForm.Validator.ParentFirstNameEmpty();

            this.KidsInSchoolPage.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchoolNoParentLastName()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);
             
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.RegistrationForm.Validator.ParentLastNameEmpty();

            this.KidsInSchoolPage.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterExistingUserToTeacherSchoolNoParentEmail()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.RegistrationForm.Validator.ParentEmailEmpty();

            this.KidsInSchoolPage.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterNonExistingUserToTeacherSchool()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user2",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.RegistrationForm.Validator.UsernameIsInvalid();

            this.KidsInSchoolPage.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        [TestMethod]
        public void RegisterDuplicateUserToTeacherSchool()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Map.KidsInSchoolGrid.Wait.ForExists(10000);

            var userToRegister = new RegistrationEntry()
            {
                Username = "random.user",
                Email = "a4188689@trbvm.com",
                ParentFirstName = "ИмеНаРодител",
                ParentLastName = "ФамилияНаРодител",
                ParentEmail = "roditel@yahoo.com",
                ParentPhone = ""
            };

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsRegistered(userToRegister.Username);

            AlertDialog alert = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            this.KidsInSchoolPage.RegisterExistingUserToSchool(userToRegister);

            Assert.IsTrue(alert.Window.Exists);

            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();

            this.KidsInSchoolPage.RemoveUserFromSchool(userToRegister.Username);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.KidsInSchoolPage.Validator.UserIsNotRegistered(userToRegister.Username);
        }
    }
}

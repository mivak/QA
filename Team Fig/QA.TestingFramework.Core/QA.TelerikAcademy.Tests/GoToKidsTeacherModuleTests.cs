using System;
using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.TelerikAcademy.Core.Pages.AdminPage;
using QA.TelerikAcademy.Core.Pages.LoginPage;
using QA.TelerikAcademy.Core;
using QA.TelerikAcademy.Core.Data;
using QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool;

namespace QA.TelerikAcademy.Tests
{
    [TestClass]
    public class GoToKidsTeacherModuleTests : BaseTest
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
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void GoToKidsInSchoolModule()
        {
            this.KidsInSchoolPage.Map.KidsInSchoolLink.Click();
            this.KidsInSchoolPage.Validator.ModuleTitle();
        }
    }
}
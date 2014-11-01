namespace QA.TelerikAcademy.Tests.SchoolsTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ArtOfTest.WebAii.Core;
    
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools;
    using QA.TelerikAcademy.Core.Pages.LoginPage;

    [TestClass]
    public class SchoolsTests : BaseTest
    {
        public SchoolsPage SchoolsPage { get; set; }
        
        public LoginPage LoginPage { get; set; }

        protected override void TestInit()
        {
            this.LoginPage = new LoginPage();
            Manager.Current.ActiveBrowser.Window.Maximize();

            var kidsAdminUser = User.Get(UserRoles.KidsAdmin);
            this.LoginPage.LoginUser(kidsAdminUser);
            this.LoginPage.Validator.UserLabel(kidsAdminUser);

            this.SchoolsPage = new SchoolsPage();
            this.SchoolsPage.GoToSchoolsModule();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifySchoolsBackToAdministrationButtonWorksCorrectly()
        {
            this.SchoolsPage.PageMap.BackToAdministrationButton
                .Click();
            this.SchoolsPage.Validator.AdminPageHeader();
        }

        [TestMethod]
        public void VerifyClickingOnTheCourseNameNavigatesToTheCorrectPage()
        {
            var firstCourseName = this.SchoolsPage
                .GetFirstCourseName();
            this.SchoolsPage.GoToFirstCourse();
            this.SchoolsPage.Validator
                .CoursePageHeader(firstCourseName);
        }

        [TestMethod]
        public void VerifyChangingCourseInstanceName()
        {
            var newName = this.SchoolsPage.GetRandomString(8);
            this.SchoolsPage.ChangeName(newName);
            this.SchoolsPage.Validator.NameChangedTo(newName);
        }

        [TestMethod]
        public void VerifyEmptyCourseInstanceNameIsNotAllowed()
        {
            var emptyName = string.Empty;
            this.SchoolsPage.ChangeName(emptyName);
            this.SchoolsPage.Validator.EmptyNameMessageDisplayed();
        }

        [TestMethod]
        public void VerifyChangeCategory()
        {
            var changedCategory = this.SchoolsPage.ChangeCategory();
            this.SchoolsPage.Validator
                .CategoryChanged(changedCategory);
        }

        [TestMethod]
        public void VerifyChangeDates()
        {
            string startDate = this.SchoolsPage
                .GetRandomDateAfter("01/01/2014");
            string endDate = this.SchoolsPage
                .GetRandomDateAfter(startDate);
            this.SchoolsPage.ChangeEndDate(endDate);
            this.SchoolsPage.ChangeStartDate(startDate);
            this.SchoolsPage.Validator.DatesChanged(
                startDate, endDate);
        }

        [TestMethod]
        // Reported bug
        public void VerifyStartDateCannotBeAfterEndDate()
        {
            string endDate = this.SchoolsPage
                .GetRandomDateAfter("01/01/2014");
            string startDate = this.SchoolsPage
                .GetRandomDateAfter(endDate);
            this.SchoolsPage.ChangeEndDate(endDate);
            this.SchoolsPage.ChangeStartDate(startDate);
            this.SchoolsPage.Validator.DatesNotChanged(
                startDate, endDate);
        }

        [TestMethod]
        public void VerifyChangeLicense()
        {
            string changedLicense = this.SchoolsPage
                .ChangeLicense();
            this.SchoolsPage.Validator
                .LicenseChanged(changedLicense);
        }
    }
}
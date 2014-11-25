namespace QA.TelerikAcademy.Tests.Schools
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class Schools : BaseTest
    {
        private readonly string date = "01/01/2014";

        public SchoolsPage SchoolsPage { get; set; }
        
        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.SchoolsPage = PageProvider<SchoolsPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.KidsAdmin);
            NavigationService.NavigateToPage(this.User, SchoolsPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(170), Priority(2)]
        public void VerifySchoolsBackToAdministrationButtonWorksCorrectly()
        {
            this.SchoolsPage.PageMap.BackToAdministrationButton
                .Click();
            this.SchoolsPage.Validator.AdminPageHeader();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(195), Priority(2)]
        public void VerifyClickingOnTheCourseNameNavigatesToTheCorrectPage()
        {
            var firstCourseName = this.SchoolsPage
                .GetFirstCourseName();
            this.SchoolsPage.GoToFirstCourse();
            this.SchoolsPage.Validator
                .CoursePageHeader(firstCourseName);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(488), Priority(2)]
        public void VerifyChangingCourseInstanceName()
        {
            var newName = RandomStringProvider.GetRandomStringLatin(8);
            this.SchoolsPage.ChangeName(newName);
            this.SchoolsPage.Validator.NameChangedTo(newName);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(489), Priority(2)]
        public void VerifyEmptyCourseInstanceNameIsNotAllowed()
        {
            var emptyName = string.Empty;
            this.SchoolsPage.ChangeName(emptyName);
            this.SchoolsPage.Validator.EmptyNameMessageDisplayed();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(490), Priority(2)]
        public void VerifyChangeCategory()
        {
            var changedCategory = this.SchoolsPage.ChangeCategory();
            this.SchoolsPage.Validator
                .CategoryChanged(changedCategory);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(491), Priority(2)]
        public void VerifyChangeDates()
        {
            string startDate = RandomStringProvider
                .GetRandomDate(date);
            string endDate = RandomStringProvider
                .GetRandomDate(startDate);
            this.SchoolsPage.ChangeEndDate(endDate);
            this.SchoolsPage.ChangeStartDate(startDate);
            this.SchoolsPage.Validator.DatesChanged(
                startDate, endDate);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(492), Priority(2)]
        [KnownIssue(2246)]
        public void VerifyStartDateCannotBeAfterEndDate()
        {
            string endDate = RandomStringProvider
                .GetRandomDate(date);
            string startDate = RandomStringProvider
                .GetRandomDate(endDate);
            this.SchoolsPage.ChangeEndDate(endDate);
            this.SchoolsPage.ChangeStartDate(startDate);
            this.SchoolsPage.Validator.DatesNotChanged(
                startDate, endDate);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(493), Priority(2)]
        public void VerifyChangeLicense()
        {
            string changedLicense = this.SchoolsPage
                .ChangeLicense();
            this.SchoolsPage.Validator
                .LicenseChanged(changedLicense);
        }
    }
}
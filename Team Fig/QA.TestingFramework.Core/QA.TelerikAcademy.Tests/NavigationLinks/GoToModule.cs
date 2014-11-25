using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.TelerikAcademy.Core;
using QA.TelerikAcademy.Core.Data.Users;
using QA.TelerikAcademy.Core.Pages.AdminPage;
using QA.TelerikAcademy.Core.Pages.LoginPage;
using QA.TelerikAcademy.Core.Providers;

namespace QA.TelerikAcademy.Tests.NavigationLinks
{
    [TestClass]
    public class GoToModule : BaseTest
    {
        public AdminPage AdminPage { get; set; }

        public LoginPage LoginPage { get; set; }

        protected override void TestInit()
        {
            this.LoginPage = PageProvider<LoginPage>.Instance;
            this.AdminPage = PageProvider<AdminPage>.Instance;

            var kidsAdminUser = UserFactory.GetUser(UserRoles.KidsAdmin);
            this.LoginPage.LoginUser(kidsAdminUser);
            this.LoginPage.Validator.UserLabel(kidsAdminUser);

            this.AdminPage.Navigate();
            this.AdminPage.Validator.AdminPageTitle();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void GoToCalendarsModule()
        {
            this.AdminPage.GoToCalendar();
            this.AdminPage.Validator.CalendarPageTitle();
        }

        [TestMethod]
        public void GoToOfficialHolidaysModule()
        {
            this.AdminPage.GoToOfficialHolidays();
            this.AdminPage.Validator.OfficialHolidaysPageTitle();
        }

        [TestMethod]
        public void GoToEventsModule()
        {
            this.AdminPage.GoToEvents();
            this.AdminPage.Validator.EventsPageTitle();
        }

        [TestMethod]
        public void GoToMovedLecturesModule()
        {
            this.AdminPage.GoToMovedLectures();
            this.AdminPage.Validator.MovedLecturesPageTitle();
        }

        [TestMethod]
        public void GoToSchoolsModule()
        {
            this.AdminPage.GoToSchools();
            this.AdminPage.Validator.SchoolsPageTitle();
        }

        [TestMethod]
        public void GoToSchoolTypesModule()
        {
            this.AdminPage.GoToSchoolTypes();
            this.AdminPage.Validator.SchoolTypesPageTitle();
        }

        [TestMethod]
        public void GoToKidsInSchoolsModule()
        {
            this.AdminPage.GoToKidsInSchools();
            this.AdminPage.Validator.KidsInSchoolsPageTitle();
        }

        [TestMethod]
        public void GoToContestsModule()
        {
            this.AdminPage.GoToContests();
            this.AdminPage.Validator.ContestsPageTitle();
        }

        [TestMethod]
        public void GoToEntryTestsModule()
        {
            this.AdminPage.GoToEntryTests();
            this.AdminPage.Validator.EntryTestsPageTitle();
        }

        [TestMethod]
        public void GoToCandidatesModule()
        {
            this.AdminPage.GoToCandidates();
            this.AdminPage.Validator.CandidatesPageTitle();
        }

        [TestMethod]
        public void GoToDocumentsModule()
        {
            this.AdminPage.GoToDocuments();
            this.AdminPage.Validator.DocumentsPageTitle();
        }
    }
}
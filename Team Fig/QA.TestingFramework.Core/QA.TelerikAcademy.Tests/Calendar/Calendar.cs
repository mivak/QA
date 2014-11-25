namespace QA.TelerikAcademy.Tests.Calendar
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.Calendar;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class Calendar : BaseTest
    {
        public CalendarPage CalendarPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.CalendarPage = PageProvider<CalendarPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.Admin);
            NavigationService.NavigateToPage(this.User, CalendarPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Vassil")]
        [TestCase(143), Priority(2)]
        public void VerifyCalendarBackToAdministrationLinkWorksCorrectly()
        {
            this.CalendarPage.PageMap.BackToAdministrationLink
                .Click();
            this.CalendarPage.Validator.AdminPageHeader();
        }
    }
}

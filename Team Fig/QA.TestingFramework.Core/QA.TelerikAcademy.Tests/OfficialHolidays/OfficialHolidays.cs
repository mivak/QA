namespace QA.TelerikAcademy.Tests.OfficialHolidays
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.OfficialHolidays;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class OfficialHolidays : BaseTest
    {
        public OfficialHolidaysPage OfficialHolidaysPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.OfficialHolidaysPage = PageProvider<OfficialHolidaysPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.Admin);
            NavigationService.NavigateToPage(this.User, OfficialHolidaysPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Vassil")]
        [TestCase(161), Priority(2)]
        public void VerifyCalendarBackToAdministrationButtonWorksCorrectly()
        {
            this.OfficialHolidaysPage.PageMap.BackToAdministrationButton
                .Click();
            this.OfficialHolidaysPage.Validator.AdminPageHeader();
        }
    }
}

namespace QA.TelerikAcademy.Tests.EntryTests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.EntryTests;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class EntryTests : BaseTest
    {
        public EntryTestsPage EntryTestsPage { get; set; }
        
        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.EntryTestsPage = PageProvider<EntryTestsPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.KidsAdmin);
            NavigationService.NavigateToPage(this.User, EntryTestsPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Rossitza")]
        [TestCase(335), Priority(1)]
        public void CreateEntryTest_Valid()
        {
            var startDateTime =  RandomStringProvider.GetRandomDateTime(RandomStringProvider.DateTimeNow);
            var endDateTime = RandomStringProvider.GetRandomDateTime(startDateTime);
            var testConfiguration = "English Test (Разни въпроси)";
            var trainingRoom = "Light";
            var city = "Друг";
            var candidateCountLimit = "100";
            this.EntryTestsPage.CreateEntryTestValid(
                testConfiguration, startDateTime, endDateTime, city, trainingRoom, candidateCountLimit);

            this.EntryTestsPage.Validator.EntryTestCreated( 
                testConfiguration, startDateTime, endDateTime, city, trainingRoom, candidateCountLimit);
        }
    }
}
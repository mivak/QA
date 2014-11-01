namespace QA.TelerikAcademy.Tests.EventsTests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.Events;

    [TestClass]
    public class EventsTests : BaseTest
    {
        public LoginPage LoginPage { get; set; }

        public EventsPage EventsPage { get; set; }

        protected override void TestInit()
        {
            var adminUser = User.Get(UserRoles.Admin);

            this.LoginPage = new LoginPage();
            this.LoginPage.LoginUser(adminUser);

            this.EventsPage = new EventsPage();
            this.EventsPage.GoToEventsModule();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifyCreatingEventToAllCourses()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.Validator.VerifyEventDescription();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        public void VerifyCreatingEventToExistingUser()
        {
            this.EventsPage.CreateEventToExistingUser();
            this.EventsPage.Validator.VerifyEventUser();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        public void VerifyCreatingEventToSpecificTrainingRoom()
        {
            this.EventsPage.CreateEventToSpecificTrainingRoom();
            this.EventsPage.Validator.VerifyEventTrainingRoom();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        public void VerifyCreatingEventToUnexistingUser()
        {
            this.EventsPage.CreateEventToUnexistingUser();
            this.EventsPage.Validator.VerifyInvalidUserErrorMessage();
        }

        [TestMethod]
        public void VerifyCreatingEventWithoutDescription()
        {
            this.EventsPage.CreateEventWithoutDescription();
            this.EventsPage.Validator.VerifyDescriptionErrorMessage();
        }

        [TestMethod]
        public void VerifyCreatingEventWithValidStartDate()
        {
            this.EventsPage.CreateEventWithValidStartDate();
            this.EventsPage.Validator.VerifyValidStartDate();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        public void VerifyCreatingEventWithInvalidStartDate()
        {
            this.EventsPage.CreateEventWithInvalidStartDate();
            this.EventsPage.Validator.VerifyInvalidStartDateErrorMessage();
        }

        [TestMethod]
        public void VerifyCreatingEventWithEndDateBeforeStartDate()
        {
            this.EventsPage.CreateEventWithEndDateBeforeStartDate();
            this.EventsPage.Validator.VerifyEndDateIsBeforeStartDateErrorMessage();
        }

        [TestMethod]
        public void VerifyEventsBackToAdministrationButtonWorksCorrectly()
        {
            this.EventsPage.Map.BackToAdministrationButton.Click();
            this.EventsPage.Validator.VerifyAdminPageHeader();
        }

        [TestMethod]
        public void VerifyChangeEventDescription()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.ChangeDescriptionOfExistingEvent();
            this.EventsPage.Validator.VerifyChangedEventDescription();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        public void VerifyDeleteEvent()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.RemoveEvent();
            this.EventsPage.Validator.VerifyDeleteEvent();
        }

        [TestMethod]
        public void VerifyCancelButttonUntilModifyingEvent()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.ModifyEventInformationWithoutSaving();
            this.EventsPage.Validator.VerifyCancelButton();
            this.EventsPage.RemoveEvent();
        }
    }
}

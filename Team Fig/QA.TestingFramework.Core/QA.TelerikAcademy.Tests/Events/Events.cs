namespace QA.TelerikAcademy.Tests.Events
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.Events;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class Events : BaseTest
    {
        public EventsPage EventsPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.EventsPage = PageProvider<EventsPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.Admin);
            NavigationService.NavigateToPage(this.User, this.EventsPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(240), Priority(2)]
        public void VerifyCreatingEventToAllCourses()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.Validator.VerifyEventDescription();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(242), Priority(2)]
        public void VerifyCreatingEventToExistingUser()
        {
            this.EventsPage.CreateEventToExistingUser();
            this.EventsPage.Validator.VerifyEventUser();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(243), Priority(2)]
        public void VerifyCreatingEventToSpecificTrainingRoom()
        {
            this.EventsPage.CreateEventToSpecificTrainingRoom();
            this.EventsPage.Validator.VerifyEventTrainingRoom();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(269), Priority(2)]
        [KnownIssue(2311)]
        public void VerifyCreatingEventToUnexistingUser()
        {
            this.EventsPage.CreateEventToUnexistingUser();
            this.EventsPage.Validator.VerifyInvalidUserErrorMessage();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(270), Priority(2)]
        [KnownIssue(2310)]
        public void VerifyCreatingEventWithoutDescription()
        {
            this.EventsPage.CreateEventWithoutDescription();
            this.EventsPage.Validator.VerifyDescriptionErrorMessage();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(244), Priority(2)]
        public void VerifyCreatingEventWithValidStartDate()
        {
            this.EventsPage.CreateEventWithValidStartDate();
            this.EventsPage.Validator.VerifyValidStartDate();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(271), Priority(2)]
        [KnownIssue(2312)]
        public void VerifyCreatingEventWithInvalidStartDate()
        {
            this.EventsPage.CreateEventWithInvalidStartDate();
            this.EventsPage.Validator.VerifyInvalidStartDateErrorMessage();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(273), Priority(2)]
        [KnownIssue(2313)]
        public void VerifyCreatingEventWithEndDateBeforeStartDate()
        {
            this.EventsPage.CreateEventWithEndDateBeforeStartDate();
            this.EventsPage.Validator.VerifyEndDateIsBeforeStartDateErrorMessage();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(251), Priority(3)]
        public void VerifyEventsBackToAdministrationButtonWorksCorrectly()
        {
            this.EventsPage.Map.BackToAdministrationButton.Click();
            this.EventsPage.Validator.VerifyAdminPageHeader();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(245), Priority(3)]
        public void VerifyChangeEventDescription()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.ChangeDescriptionOfExistingEvent();
            this.EventsPage.Validator.VerifyChangedEventDescription();
            this.EventsPage.RemoveEvent();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(261), Priority(2)]
        public void VerifyDeleteEvent()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.RemoveEvent();
            this.EventsPage.Validator.VerifyDeleteEvent();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(250), Priority(3)]
        public void VerifyCancelButttonUntilModifyingEvent()
        {
            this.EventsPage.CreateEventToAllCourses();
            this.EventsPage.ModifyEventInformationWithoutSaving();
            this.EventsPage.Validator.VerifyCancelButton();
            this.EventsPage.RemoveEvent();
        }
    }
}

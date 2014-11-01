namespace QA.TelerikAcademy.Tests.MovedLecturesTests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.Events;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.MovedLectures;

    [TestClass]
    public class MovedLecturesTests : BaseTest
    {
        public LoginPage LoginPage { get; set; }

        public MovedLecturesPage MovedLecturesPage { get; set; }

        protected override void TestInit()
        {
            var adminUser = User.Get(UserRoles.Admin);

            this.LoginPage = new LoginPage();
            this.LoginPage.LoginUser(adminUser);

            this.MovedLecturesPage = new MovedLecturesPage();
            this.MovedLecturesPage.GoToMovedLecturesModule();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifyPostponeLectureForAllCourses()
        {
            this.MovedLecturesPage.MoveLectureForAllCourses();
            this.MovedLecturesPage.Validator.VerifyPosponeLectureForAllCourses();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        public void VerifyMoveLectureToNewTrainingRoom()
        {
            this.MovedLecturesPage.MoveLectureToAnotherTrainingRoom();
            this.MovedLecturesPage.Validator.VerifyLectureIsMovedToNewTrainingRoom();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        public void VerifyMoveLectureForSpecificCourse()
        {
            this.MovedLecturesPage.MoveLectureForAllCourses();
            this.MovedLecturesPage.MoveLectureForSpecificCourse();
            this.MovedLecturesPage.Validator.VerifyLectureToSpecificCourseIsMoved();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        public void VerifyNewStartTimeOfMovedLecture()
        {
            this.MovedLecturesPage.MoveLectureForAllCourses();
            this.MovedLecturesPage.SetNewStartTimeOfExistingMovedLecture();
            this.MovedLecturesPage.Validator.VerifyNewStartTimeOfExistingMovedLecture();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        public void VerifyMovedLecturesBackToAdministrationButtonWorksCorrectly()
        {
            this.MovedLecturesPage.Map.BackToAdministrationButton.Click();
            this.MovedLecturesPage.Validator.VerifyAdminPageHeader();
        }
    }
}

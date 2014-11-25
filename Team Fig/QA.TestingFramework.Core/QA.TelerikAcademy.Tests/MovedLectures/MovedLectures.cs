namespace QA.TelerikAcademy.Tests.MovedLectures
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.Calendars.MovedLectures;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class MovedLectures : BaseTest
    {
        public MovedLecturesPage MovedLecturesPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.MovedLecturesPage = PageProvider<MovedLecturesPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.Admin);
            NavigationService.NavigateToPage(this.User, this.MovedLecturesPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(312), Priority(2)]
        public void VerifyPostponeLectureForAllCourses()
        {
            this.MovedLecturesPage.MoveLectureForAllCourses();
            this.MovedLecturesPage.Validator.VerifyPosponeLectureForAllCourses();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(313), Priority(2)]
        public void VerifyMoveLectureToNewTrainingRoom()
        {
            this.MovedLecturesPage.MoveLectureToAnotherTrainingRoom();
            this.MovedLecturesPage.Validator.VerifyLectureIsMovedToNewTrainingRoom();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(309), Priority(2)]
        public void VerifyMoveLectureForSpecificCourse()
        {
            this.MovedLecturesPage.MoveLectureForAllCourses();
            this.MovedLecturesPage.MoveLectureForSpecificCourse();
            this.MovedLecturesPage.Validator.VerifyLectureToSpecificCourseIsMoved();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(315), Priority(2)]
        public void VerifyNewStartTimeOfMovedLecture()
        {
            this.MovedLecturesPage.MoveLectureForAllCourses();
            this.MovedLecturesPage.SetNewStartTimeOfExistingMovedLecture();
            this.MovedLecturesPage.Validator.VerifyNewStartTimeOfExistingMovedLecture();
            this.MovedLecturesPage.RemoveMovedLecture();
        }

        [TestMethod]
        [Owner("Vladimir")]
        [TestCase(319), Priority(3)]
        public void VerifyMovedLecturesBackToAdministrationButtonWorksCorrectly()
        {
            this.MovedLecturesPage.Map.BackToAdministrationButton.Click();
            this.MovedLecturesPage.Validator.VerifyAdminPageHeader();
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.MovedLectures
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;

    public class MovedLecturesPageValidator
    {
        public MovedLecturesPageMap Map
        {
            get
            {
                return new MovedLecturesPageMap();
            }
        }

        public void VerifyPosponeLectureForAllCourses()
        {
            var rowsInGrid = this.Map.Grid.BodyRows.Count;
            Assert.AreEqual(1, rowsInGrid);
            Assert.AreEqual("За всички курсове", this.Map.Grid.BodyRows[0].Cells[2].InnerText);
        }

        public void VerifyLectureIsMovedToNewTrainingRoom()
        {
            Assert.AreEqual("Ultimate", this.Map.NewTrainingRoom.SelectedOption.Text);
        }

        public void VerifyLectureToSpecificCourseIsMoved()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.AreEqual("Човъркане в Студентската Система", this.Map.Grid.BodyRows[0].Cells[2].InnerText);
        }

        public void VerifyNewStartTimeOfExistingMovedLecture()
        {
            Assert.AreEqual("31/12/2021 17:30:00", this.Map.Grid.BodyRows[0].Cells[5].InnerText);
        }

        public void VerifyAdminPageHeader()
        {
            Assert.AreEqual("Администрация",
               this.Map.AdminPageHeader.InnerText);
        }
    }
}
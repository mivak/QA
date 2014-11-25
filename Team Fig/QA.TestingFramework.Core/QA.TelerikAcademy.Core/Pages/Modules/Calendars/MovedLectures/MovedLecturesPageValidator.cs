namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.MovedLectures
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using System;
    using System.Threading;

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
            Assert.AreEqual("За всички курсове", this.Map.Grid.BodyRows[0].Cells[2].InnerText);
        }

        public void VerifyLectureIsMovedToNewTrainingRoom()
        {
            var trainingRoom = this.Map.Grid.Rows[0].Cells[3].InnerText;
            Assert.AreEqual("Ultimate", trainingRoom);
        }

        public void VerifyLectureToSpecificCourseIsMoved()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.Map.Grid.Wait.ForExists(5000);
            Assert.AreEqual("TEST", this.Map.Grid.BodyRows[0].Cells[2].InnerText);
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
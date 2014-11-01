using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.MovedLectures
{
    public class MovedLecturesPage : BasePage
    {
        private const string MovedLecturesPageUrl = "http://test.telerikacademy.com/Administration_Calendar/MovedLectures";

        public MovedLecturesPage()
            : base(MovedLecturesPageUrl)
        {
        }

        public MovedLecturesPageMap Map
        {
            get
            {
                return new MovedLecturesPageMap();
            }
        }

        public MovedLecturesPageValidator Validator
        {
            get
            {
                return new MovedLecturesPageValidator();
            }
        }

        public void GoToMovedLecturesModule()
        {
            this.Navigate();
        }

        public void MoveLectureForAllCourses()
        {
            Manager.Current.ActiveBrowser.WaitForElement(3000, "xpath=//*[@id='DataGrid']/div[1]/a[2]");
            this.Map.MovePostponeLectureButton.Click();
            this.Map.UpdateButton.Click();
        }

        public void MoveLectureToAnotherTrainingRoom()
        {
            Manager.Current.ActiveBrowser.WaitForElement(3000, "xpath=//*[@id='DataGrid']/div[1]/a[2]");
            this.Map.MovePostponeLectureButton.Click();
            this.Map.NewTrainingRoom.SelectByText("Ultimate");
            this.Map.UpdateButton.Click();
        }

        public void MoveLectureForSpecificCourse()
        {
            this.Map.ModifyButton.Click();
            this.Map.CourseInputField.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Човъркане в Студентската Система", 5);
            this.Map.UpdateButton.Click();
        }

        public void SetNewStartTimeOfExistingMovedLecture()
        {
            this.Map.ModifyButton.Click();
            this.Map.NewStratTimeInputField.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("31/12/2021 17:30:00");
            this.Map.UpdateButton.Click();
        }

        public void RemoveMovedLecture()
        {
            AlertDialog alert = AlertDialog.CreateAlertDialog(
                Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            Manager.Current.ActiveBrowser.Refresh();
            Manager.Current.ActiveBrowser.WaitForElement(3000, "xpath=//*[@id='DataGrid']/table/tbody/tr[1]/td[8]/a");
            this.Map.DeleteButton.Click();

            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
            Manager.Current.ActiveBrowser.Refresh();
        }
    }
}

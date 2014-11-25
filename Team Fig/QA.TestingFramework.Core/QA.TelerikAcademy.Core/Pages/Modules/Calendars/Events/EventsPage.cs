namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Events
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Base;
    using System;

    public class EventsPage : BasePage
    {
        public EventsPage()
            : base("http://test.telerikacademy.com/Administration_Calendar/CustomEvents")
        {
        }

        public EventsPageMap Map
        {
            get
            {
                return new EventsPageMap();
            }
        }

        public EventsPageValidator Validator
        {
            get
            {
                return new EventsPageValidator();
            }
        }
        
        public void CreateEventToAllCourses()
        {
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);
            this.Map.UpdateButton.Click();
        }

        public void CreateEventToExistingUser()
        {
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);
            this.Map.EventUser.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("TestUser", 5);
            this.Map.UpdateButton.Click();
        }

        public void CreateEventToSpecificTrainingRoom()
        {
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);
            this.Map.TrainingRoom.SelectByText("Enterprise", true);
            this.Map.UpdateButton.Click();
        }

        public void CreateEventToUnexistingUser()
        {            
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);
            this.Map.EventUser.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("UnexistingUser", 5);
            this.Map.UpdateButton.Click();
        }

        public void CreateEventWithoutDescription()
        {
            this.Map.CreateEventButton.Click();
            this.Map.UpdateButton.Click();
        }

        public void CreateEventWithValidStartDate()
        {
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);

            this.Map.StartDate.MouseClick();
            this.Map.StartDate.Text = String.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("27/10/2015 22:30:00", 5);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.EndDate.MouseClick();
            this.Map.EndDate.Text = String.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("27/12/2015 22:30:00", 5);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.UpdateButton.Click();
        }

        public void CreateEventWithEndDateBeforeStartDate()
        {
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);

            this.Map.StartDate.MouseClick();
            this.Map.StartDate.Text = String.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("27/12/2015 22:30:00", 5);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.EndDate.MouseClick();
            this.Map.EndDate.Text = String.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("27/10/2015 22:30:00", 5);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.UpdateButton.Click();
        }

        public void CreateEventWithInvalidStartDate()
        {
            this.Map.CreateEventButton.Click();
            this.Map.EventDescription.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Some test description", 5);
            this.Map.StartDate.MouseClick();
            this.Map.StartDate.Text = String.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("Invalid start date", 5);
            this.Map.UpdateButton.Click();
        }

        public void ChangeDescriptionOfExistingEvent()
        {
            Manager.Current.ActiveBrowser.WaitForElement(3000, "xpath=//*[@id='DataGrid']/table/tbody/tr/td[10]/a");
            this.Map.ModifyButton.Click();
            Manager.Current.ActiveBrowser.WaitForElement(6000, "id=Title");
            this.Map.EventDescription.MouseClick();
            this.Map.EventDescription.Text = "";
            Manager.Current.Desktop.KeyBoard.TypeText("Changed description", 5);
            this.Map.UpdateButton.Click();
        }

        public void ModifyEventInformationWithoutSaving()
        {
            Manager.Current.ActiveBrowser.WaitForElement(6000, "xpath=//*[@id='DataGrid']/table/tbody/tr/td[10]/a");
            this.Map.ModifyButton.Click();
            Manager.Current.ActiveBrowser.WaitForElement(6000, "id=Title");
            this.Map.EventDescription.MouseClick();
            this.Map.EventDescription.Text = String.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("Changed description", 5);
            this.Map.CancelButton.Click();
        }

        public void RemoveEvent()
        {
            AlertDialog alert = AlertDialog.CreateAlertDialog(
                Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            Manager.Current.ActiveBrowser.Refresh();
            Manager.Current.ActiveBrowser.WaitForAjax(3000);
            this.Map.DeleteButton.Click();
  
            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
            Manager.Current.ActiveBrowser.Refresh();
        }
    }
}

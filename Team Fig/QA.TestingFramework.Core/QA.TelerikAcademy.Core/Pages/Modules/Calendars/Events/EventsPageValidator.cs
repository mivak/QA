namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Events
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;

    public class EventsPageValidator
    {
        public EventsPageMap Map
        {
            get
            {
                return new EventsPageMap();
            }
        }
                
        public void VerifyEventDescription()
        {
            this.Map.Grid.Wait.ForExists();

            var descriptionCell = this.Map.Grid.Rows[0].Cells[6];

            Assert.AreEqual("Some test description", descriptionCell.TextContent);
        }

        public void VerifyEventUser()
        {
            this.Map.Grid.Wait.ForExists();

            var usernameCell = this.Map.Grid.Rows[0].Cells[5];

            Assert.AreEqual("TestUser", usernameCell.InnerText);
        }        
        
        public void VerifyAdminPageHeader()
        {
            Assert.AreEqual("Администрация",
               this.Map.AdminPageHeader.InnerText);
        }

        public void VerifyEventTrainingRoom()
        {
            Assert.AreEqual("Enterprise",
               this.Map.TrainingRoom.SelectedOption.Text);
        }

        public void VerifyDescriptionErrorMessage()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(3000, "id=Title_validationMessage");
            
            var descriptionErrorMessage = this.Map.DescriptionErrorMessage.InnerText;
            Assert.AreEqual("Моля въведете описание!", descriptionErrorMessage);
        }

        public void VerifyInvalidUserErrorMessage()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(3000, "id=Username_validationMessage");
                        
            var userErrorMessage = this.Map.UserErrorMessage.InnerText;
            Assert.AreEqual("Не съществува такъв потребител!", userErrorMessage);
        }

        public void VerifyValidStartDate()
        {            
            Assert.AreEqual("27/10/2015 22:30:00", this.Map.Grid.Rows[0].Cells[7].InnerText);
            Assert.AreEqual("27/12/2015 22:30:00", this.Map.Grid.Rows[0].Cells[8].InnerText);
        }

        public void VerifyInvalidStartDateErrorMessage()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(3000, "id=StartTime_validationMessage");
            
            var startDateErrorMessage = this.Map.StartDateErrorMessage.InnerText;
            Assert.AreEqual("Моля изберете начално време!", startDateErrorMessage);
        }

        public void VerifyEndDateIsBeforeStartDateErrorMessage()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(3000, "id=EndTime_validationMessage");

            var startDateErrorMessage = this.Map.EndDateErrorMessage.InnerText;
            Assert.AreEqual("Невалидно крайно време! Не може събитие да свърши преди да е започнало.", startDateErrorMessage);
        }

        public void VerifyChangedEventDescription()
        {
            this.Map.Grid.Wait.ForExists();

            var descriptionCell = this.Map.Grid.Rows[0].Cells[6];

            Assert.AreEqual("Changed description", descriptionCell.TextContent);
        }

        public void VerifyCancelButton()
        {
            Assert.AreEqual("Some test description", this.Map.Grid.Rows[0].Cells[6].InnerText);
        }

        public void VerifyDeleteEvent()
        {
            var rowsInGrid = this.Map.Grid.BodyRows.Count;

            Assert.AreEqual(0, rowsInGrid);
        }
    }
}

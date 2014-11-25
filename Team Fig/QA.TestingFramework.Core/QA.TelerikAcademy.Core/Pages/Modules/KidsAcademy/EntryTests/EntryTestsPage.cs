namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.EntryTests
{
    using QA.TelerikAcademy.Core.Pages.Base;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using System.Threading;
    using System;
    using ArtOfTest.WebAii.Core;
    
    public class EntryTestsPage : BasePage
    {
        public EntryTestsPage()
            : base("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams")
        {
        }

        public EntryTestsPageMap Map
        {
            get
            {
                return new EntryTestsPageMap();
            }
        }

        public EntryTestEditPageMap EntryTestEditMap
        {
            get
            {
                return new EntryTestEditPageMap();
            }
        }

        public EntryTestsPageValidator Validator
        {
            get
            {
                return new EntryTestsPageValidator();
            }
        }

        public void CreateEntryTestValid(string testConfiguration, string startDateTime, string endDateTime, string city, string trainingRoom, string candidateCountLimit)
        {
            this.Map.CreateEntryTest.Click();
            this.EntryTestEditMap.TestConfiguration.SelectByText(testConfiguration, true);
            this.EntryTestEditMap.StartTime.Text = startDateTime;
            this.EntryTestEditMap.EndTime.Text = endDateTime;
            this.EntryTestEditMap.CandidateForCity.SelectByText(city, true);
            this.EntryTestEditMap.TrainingRoom.SelectByText(trainingRoom, true);
            this.EntryTestEditMap.CandidatesCountLimit.Text = candidateCountLimit;
            this.EntryTestEditMap.UpdateButton.MouseClick();
        }
    }
}

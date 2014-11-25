namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.ContestCreationForm
{
    using System;
    using ArtOfTest.WebAii.Core;

    public class ContestCreationForm
    {
        public ContestCreationForm()
        {
        }

        public ContestCreationFormMap Map
        {
            get
            {
                return new ContestCreationFormMap();
            }
        }

        public ContestCreationFormValidator Validator
        {
            get
            {
                return new ContestCreationFormValidator();
            }
        }

        public void CreateSampleContest(string contestName)
        {
            var contest = new
            {
                BgCoderId = "20",
                Name = contestName,
                StartTime = "28/11/2014 10:00:00",
                EndTime = "28/11/2014 18:00:00",
                ActiveTo = "28/12/2014 10:00:00"
            };

            //this.Map.BgCoderId.Text = contest.BgCoderId;
            this.Map.BgCoderId.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(contest.BgCoderId, 5);
            this.Map.BgCoderId.Focus();

            this.Map.ContestName.MouseClick();
            this.Map.ContestName.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(contest.Name, 5);

            this.Map.StartTime.Text = contest.StartTime;
            this.Map.StartTime.Focus();
            
            this.Map.EndTime.Text = contest.EndTime;
            this.Map.EndTime.Focus();

            this.Map.ActiveTo.Text = contest.ActiveTo;
            this.Map.ActiveTo.Focus();

            this.Map.UpdateButton.Click();
        }
    }
}
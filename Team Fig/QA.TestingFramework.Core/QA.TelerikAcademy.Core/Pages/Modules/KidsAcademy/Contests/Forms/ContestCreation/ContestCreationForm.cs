namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.ContestCreation
{
    using System;
    using ArtOfTest.WebAii.Core;
    using System.Threading;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using System.Globalization;

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
            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            Thread.Sleep(1500);

            string bgCoderId, contestStartDate, contestEndDate, contestLastActiveDate;
            GenerateRandomContestData(out bgCoderId, out contestStartDate, out contestEndDate, out contestLastActiveDate);

            var contest = new
            {
                BgCoderId = bgCoderId,
                Name = contestName,
                StartTime = contestStartDate,
                EndTime = contestEndDate,
                ActiveTo = contestLastActiveDate
            };

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

        private void GenerateRandomContestData(out string bgCoderId, out string contestStartDate, out string contestEndDate, out string contestLastActiveDate)
        {
            string dateTimeFormat = "dd/MM/yyyy hh:00:00";

            bgCoderId = RandomStringProvider.GetRandomInt(1, 30);

            var currentDate = DateTime.Now.ToString(dateTimeFormat, CultureInfo.InvariantCulture);

            contestStartDate = RandomStringProvider.GetRandomDateTime(currentDate, dateTimeFormat);

            contestEndDate = RandomStringProvider.GetRandomDateTime(contestStartDate, dateTimeFormat);

            contestLastActiveDate = RandomStringProvider.GetRandomDateTime(contestEndDate, dateTimeFormat);
        }
    }
}
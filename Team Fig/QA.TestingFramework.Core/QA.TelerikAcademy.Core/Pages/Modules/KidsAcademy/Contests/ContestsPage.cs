namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.ContestCreation;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContest;
    using System.Threading;
    using System.Drawing;
    public class ContestsPage : BasePage
    {
        private const string ContestsPageUrl = "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCompetitions";
        public ContestsPage()
            : base(ContestsPageUrl)
        {
        }

        public ContestsPageMap Map
        {
            get
            {
                return new ContestsPageMap();
            }
        }

        public ContestsPageValidator Validator
        {
            get
            {
                return new ContestsPageValidator();
            }
        }

        public ContestCreationForm ContestCreationForm
        {
            get
            {
                return new ContestCreationForm();
            }
        }

        public AddUserToContestForm AddUserToContestForm
        {
            get
            {
                return new AddUserToContestForm();
            }
        }

        public void GoToContestsModule()
        {
            this.Navigate();
        }

        public void CreateNewContest(string contestName)
        {
            this.Map.CreateContestButton.Click();
            this.ContestCreationForm.CreateSampleContest(contestName);
        }

        public void EraseContest(string contestName)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);
            Thread.Sleep(1000);

            var eraseButton = rowContainingContest.Find.ByExpression<HtmlSpan>("k-icon k-delete".Class());

            AlertDialog alert = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();
            
            eraseButton.Click();
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
        }

        public void AddNewUserToContest(string contestName, string username, int points, string isTaken)
        {
            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUser(username, points, isTaken);
        }

        public void RemoveUserFromContest(string contestName, string username)
        {
            AlertDialog alert = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);
            var indexOfContestRow = rowContainingContest.RowIndex;

            var detailRow = this.Map.Grid.Find.ByTagIndex<HtmlTableRow>("tr", indexOfContestRow + 1);

            var gridFromContest = detailRow.Find.ByAttributes<HtmlTable>("role=grid");

            var userEraseButton = gridFromContest.Find.ByExpression<HtmlAnchor>("k-button k-button-icontext k-grid-delete".Class());

            userEraseButton.Click();

            alert.WaitUntilHandled();

            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
        }

        public void ExpandContestUsersGrid(string contestName)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);

            var expandContestUsers = rowContainingContest.Find.ByExpression<HtmlAnchor>("k-icon k-plus".Class());

            expandContestUsers.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();
        }

        public void CloseContestUsersGrid(string contestName)
        {
            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);

            var closeContestUsersLink = rowContainingContest.Find.ByExpression<HtmlAnchor>("k-icon k-minus".Class());

            closeContestUsersLink.Click();
        }

        
    }
}

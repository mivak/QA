namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests
{
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Base;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContest;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.ContestCreation;

    public class ContestsPage : BasePage
    {
        public ContestsPage() :
            base("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCompetitions")
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

        public void CreateNewContest(string contestName)
        {
            this.Map.CreateContestButton.Click();

            this.ContestCreationForm.CreateSampleContest(contestName);
        }

        public void EraseContest(string contestName)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);

            var eraseButton = rowContainingContest.Find.ByExpression<HtmlSpan>("k-icon k-delete".Class());

            AlertDialog alert = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();
            
            eraseButton.MouseClick();

            try
            {
                alert.WaitUntilHandled(10000);
            }
            catch (System.TimeoutException)
            {
                alert.Window.SetFocus();
                Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);
            }

            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
        }

        public void AddNewUserToContest(string contestName, UserContestEntry userToRegister)
        {
            this.CreateNewContest(contestName);

            Manager.Current.ActiveBrowser.Refresh();

            this.ExpandContestUsersGrid(contestName);

            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUser(userToRegister);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();
        }

        public void AddInvalidUserToContest(string contestName, UserContestEntry userToRegister)
        {
            this.CreateNewContest(contestName);

            Manager.Current.ActiveBrowser.Refresh();

            this.Map.ContestNameColumn.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.ExpandContestUsersGrid(contestName);

            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUser(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.AddUserToContestForm.Validator.UserDoesNotExist();

            this.AddUserToContestForm.Map.CancelButton.Click();

            this.EraseContest(contestName);
        }

        public void AddUserToContesInvalidExamState(string contestName, UserContestEntry userToRegister)
        {
            this.CreateNewContest(contestName);

            Manager.Current.ActiveBrowser.Refresh();

            this.Map.ContestNameColumn.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.ExpandContestUsersGrid(contestName);

            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUser(userToRegister);

            Manager.Current.ActiveBrowser.Refresh();

            this.Map.ContestNameColumn.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.ExpandContestUsersGrid(contestName);

            this.Validator.UserIsNotRegisteredToContest(contestName, userToRegister.Username);

            this.EraseContest(contestName);
        }

        public void AddUserToContesEmptyPoints(string contestName, UserContestEntry userToRegister)
        {
            this.CreateNewContest(contestName);

            Manager.Current.ActiveBrowser.Refresh();

            this.Map.ContestNameColumn.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.ExpandContestUsersGrid(contestName);

            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUserEmptyPoints(userToRegister);

            Manager.Current.ActiveBrowser.Refresh();

            this.Map.ContestNameColumn.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.ExpandContestUsersGrid(contestName);

            this.Validator.UserIsNotRegisteredToContest(contestName, userToRegister.Username);

            this.EraseContest(contestName);
        }

        public void RegisterUserToContestStringPoints(string contestName, string username = "random.user", string points = "string", string isTaken = "True")
        {
            this.CreateNewContest(contestName);

            Manager.Current.ActiveBrowser.Refresh();

            this.Map.ContestNameColumn.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.ExpandContestUsersGrid(contestName);

            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUserStringPoints(username, points, isTaken);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.AddUserToContestForm.Validator.Points();

            this.AddUserToContestForm.Map.CancelButton.Click();

            this.EraseContest(contestName);
        }

        public void AddDuplicateUserToContest(string contestName, UserContestEntry userToRegister)
        {
            this.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.Map.AddUserToContestButton.GetRectangle());

            this.AddUserToContestForm.RegisterUser(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.AddUserToContestForm.Validator.DuplicateUser();

            this.AddUserToContestForm.Map.CancelButton.Click();
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

            userEraseButton.MouseClick();

            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();

            this.Validator.UserIsNotRegisteredToContest(contestName, username);

            this.EraseContest(contestName);
        }

        public void ExpandContestUsersGrid(string contestName)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);

            var expandContestUsers = rowContainingContest.Find.ByExpression<HtmlAnchor>("k-icon k-plus".Class());
            
            if (expandContestUsers!=null)
            {
                expandContestUsers.Click();
            }

            Manager.Current.ActiveBrowser.RefreshDomTree();
        }

        public void CloseContestUsersGrid(string contestName)
        {
            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);

            var closeContestUsersLink = rowContainingContest.Find.ByExpression<HtmlAnchor>("k-icon k-delete".Class());

            closeContestUsersLink.Click();
        }
    }
}
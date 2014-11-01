namespace QA.TelerikAcademy.Tests.ContestsTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests;
    using System.Threading;
    using System.Drawing;

    [TestClass]
    public class ContestsTests : BaseTest
    {
        public ContestsPage ContestsPage { get; set; }
        public LoginPage LoginPage { get; set; }

        protected override void TestInit()
        {
            Manager.Current.Settings.ExecutionDelay = 200;

            this.LoginPage = new LoginPage();

            LoginPage.Navigate();

            if (LoginPage.NavigationMap.LogoutLink != null)
            {
                LoginPage.NavigationMap.LogoutLink.Click();
            }

            var kidsAdminUser = User.Get(UserRoles.KidsAdmin);

            this.LoginPage.LoginUser(kidsAdminUser);
            this.LoginPage.Validator.UserLabel(kidsAdminUser);

            this.ContestsPage = new ContestsPage();
            this.ContestsPage.GoToContestsModule();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifyContestsBackToAdministrationButton()
        {
            this.ContestsPage.Map.BackToAdministrationButton.Click();
            this.ContestsPage.Validator.AdminPageHeader();
        }

        [TestMethod]
        public void AddUserRecordToContest()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 120,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsRegisteredToContest(contestName, user.Username);

            this.ContestsPage.RemoveUserFromContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        public void AddUserNotEnlistedToSchoolRecordToContest()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user2",
                Points = 0,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Thread.Sleep(1000);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.AddUserToContestForm.Validator.UserDoesNotExist();

            this.ContestsPage.AddUserToContestForm.Map.CancelButton.Click();

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }


        [TestMethod]
        public void AddDuplicateUserRecordToContest()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 0,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsRegisteredToContest(contestName, user.Username);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Thread.Sleep(1000);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.AddUserToContestForm.Validator.DuplicateUser();

            this.ContestsPage.AddUserToContestForm.Map.CancelButton.Click();

            this.ContestsPage.RemoveUserFromContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestValidPointsExamNotTaken()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 120,
                IsTaken = "False"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestValidPointsExamTakenNotSet()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 120,
                IsTaken = "Not Set"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestValidPointsExamTakenNotPicked()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 120,
                IsTaken = ""
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestEmptyPointsExamTaken()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 0,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.ContestsPage.Map.AddUserToContestButton.GetRectangle());

            this.ContestsPage.AddUserToContestForm.RegisterUserEmptyPoints(user.Username,user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestNegativePointsExamTaken()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = -50,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestTooBigValuePointsExamTaken()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 100000,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestStringPointsExamTaken()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = "string",
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.ContestsPage.Map.AddUserToContestButton.GetRectangle());

            this.ContestsPage.AddUserToContestForm.RegisterUserStringPoints(user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.AddUserToContestForm.Validator.Points();

            this.ContestsPage.AddUserToContestForm.Map.CancelButton.Click();

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        //Reported bug
        public void AddUserRecordToContestEmptyPointsExamTakenValueNotSet()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 0,
                IsTaken = ""
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Map.AddUserToContestButton.Focus();

            Manager.Current.Desktop.Mouse.Click(MouseClickType.LeftClick, this.ContestsPage.Map.AddUserToContestButton.GetRectangle());

            this.ContestsPage.AddUserToContestForm.RegisterUserEmptyPoints(user.Username, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);

            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }

        [TestMethod]
        public void EraseUserRecordFromContest()
        {
            var contestName = "Sample contest";

            this.ContestsPage.CreateNewContest(contestName);

            Thread.Sleep(1000);

            var user = new
            {
                Username = "random.user",
                Points = 120,
                IsTaken = "True"
            };

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.AddNewUserToContest(contestName, user.Username, user.Points, user.IsTaken);

            Manager.Current.ActiveBrowser.Refresh();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.ContestsPage.ExpandContestUsersGrid(contestName);

            this.ContestsPage.Validator.UserIsRegisteredToContest(contestName, user.Username);

            this.ContestsPage.RemoveUserFromContest(contestName, user.Username);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(contestName, user.Username);
            this.ContestsPage.CloseContestUsersGrid(contestName);

            this.ContestsPage.EraseContest(contestName);
        }
    }
}

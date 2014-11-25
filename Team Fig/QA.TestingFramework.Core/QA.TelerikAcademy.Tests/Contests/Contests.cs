namespace QA.TelerikAcademy.Tests.Contests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class Contests : BaseTest
    {
        private static string testContestName;

        private static UserContestEntry userToRegister;

        public ContestsPage ContestsPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            Manager.Current.Settings.ExecutionDelay = 200;

            this.ContestsPage = PageProvider<ContestsPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.KidsAdmin);
            NavigationService.NavigateToPage(this.User, this.ContestsPage);

            testContestName = RandomStringProvider.GetRandomStringLatin(int.Parse(RandomStringProvider.GetRandomInt(4,15)));
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(395), Priority(3)]
        
        public void VerifyContestsBackToAdministrationButton()
        {
            this.ContestsPage.Map.BackToAdministrationButton.Click();
            this.ContestsPage.Validator.AdminPageHeader();
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(424), Priority(2)]
        public void AddUserRecordToContest()
        {
            userToRegister = UserContestEntry.GetRandomEntry();

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.RemoveUserFromContest(testContestName, userToRegister.Username);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(458), Priority(2)]
        public void AddUserNotEnlistedToSchoolRecordToContest()
        {
            userToRegister = UserContestEntry.GetRandomEntry(username:"random.user2");

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(425), Priority(2)]
        [KnownIssue(2358)]
        public void AddDuplicateUserRecordToContest()
        {
            userToRegister = UserContestEntry.GetRandomEntry();

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.AddDuplicateUserToContest(testContestName, userToRegister);

            this.ContestsPage.AddUserToContestForm.Validator.DuplicateUser();

            this.ContestsPage.RemoveUserFromContest(testContestName, userToRegister.Username);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(426), Priority(2)]
        [KnownIssue(2258)]
        public void AddUserRecordToContestValidPointsExamNotTaken()
        {
            userToRegister = UserContestEntry.GetRandomEntry(isTaken: "False");

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(427), Priority(2)]
        [KnownIssue(2258)]
        public void AddUserRecordToContestValidPointsExamTakenNotSet()
        {
            userToRegister = UserContestEntry.GetRandomEntry(isTaken: "NotSet");

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(428), Priority(2)]
        [KnownIssue(2258)]
        public void AddUserRecordToContestValidPointsExamTakenNotPicked()
        {
            userToRegister = UserContestEntry.GetRandomEntry(isTaken: "");

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(429), Priority(2)]
        [KnownIssue(2260)]
        public void AddUserRecordToContestEmptyPointsExamTaken()
        {
            userToRegister = UserContestEntry.GetRandomEntry();
            userToRegister.Points = "";

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(430), Priority(2)]
        [KnownIssue(2261)]
        public void AddUserRecordToContestNegativePointsExamTaken()
        {
            userToRegister = UserContestEntry.GetRandomEntry(minPointsValue:-50, maxPointsValue:-10);

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(431), Priority(2)]
        [KnownIssue(2262)]
        public void AddUserRecordToContestTooBigValuePointsExamTaken()
        {
            userToRegister = UserContestEntry.GetRandomEntry();
            userToRegister.Points = "100000000000";

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }

        [TestMethod]
        [Owner("Natalia")]
        [TestCase(432), Priority(2)]
        public void AddUserRecordToContestStringPointsExamTaken()
        {
            userToRegister = UserContestEntry.GetRandomEntry();
            userToRegister.Points = "string";

            this.ContestsPage.AddNewUserToContest(testContestName, userToRegister);

            this.ContestsPage.Validator.UserIsNotRegisteredToContest(testContestName, userToRegister.Username);

            this.ContestsPage.EraseContest(testContestName);
        }
    }
}
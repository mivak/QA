namespace QA.TelerikAcademy.Tests.Candidates
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Candidates;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class Candidates : BaseTest
    {
        public CandidatesPage CandidatesPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.CandidatesPage = PageProvider<CandidatesPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.KidsAdmin);
            NavigationService.NavigateToPage(this.User, CandidatesPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Rossitza")]
        [TestCase(461), Priority(1)]
        public void Candidate_Accept()
        {
            this.CandidatesPage.AcceptCandidate();
            this.CandidatesPage.Validator.IsAccepted();
        }

        [TestMethod]
        [Owner("Rossitza")]
        [TestCase(462), Priority(1)]
        public void Candidate_Deny()
        {
            this.CandidatesPage.DenyCandidate();
            this.CandidatesPage.Validator.IsDenied();
        }


        [TestMethod]
        [Owner("Rossitza")]
        [TestCase(463), Priority(1)]
        public void Candidate_ClearDecision()
        {
            this.CandidatesPage.ClearDecisionAboutCandidate();
            this.CandidatesPage.Validator.IsUndecided();
        }
    }
}
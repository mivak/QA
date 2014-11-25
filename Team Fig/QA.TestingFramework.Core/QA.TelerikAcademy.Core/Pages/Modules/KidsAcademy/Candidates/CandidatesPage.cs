
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Candidates
{
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Base;
    
    public class CandidatesPage : BasePage
    {
        public CandidatesPage()
            : base("http://test.telerikacademy.com/KidsAcademy/AdministrationCandidates")
        {
        }

        public CandidatesPageMap Map 
        { 
            get
            {
                return new CandidatesPageMap();
            }
        }

        public CandidatesPageValidator Validator
        {
            get
            {
                return new CandidatesPageValidator();
            }
        }

        public void AcceptCandidate()
        {
            this.Map.AcceptButton.MouseClick();
            Manager.Current.ActiveBrowser.Refresh();
        }

        public void DenyCandidate()
        {
            this.Map.DenyButton.MouseClick();
            Manager.Current.ActiveBrowser.Refresh();
        }

        public void ClearDecisionAboutCandidate()
        {
            this.Map.ClearDecisionButton.MouseClick();
            Manager.Current.ActiveBrowser.Refresh();
        }
    }
}

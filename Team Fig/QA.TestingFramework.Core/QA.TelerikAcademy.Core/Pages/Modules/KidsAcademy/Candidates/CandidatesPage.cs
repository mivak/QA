namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Candidates
{
    public class CandidatesPage : BasePage
    {
        private const string CandidatesPageUrl = "http://test.telerikacademy.com/KidsAcademy/AdministrationCandidates";

        public CandidatesPage()
            : base(CandidatesPageUrl)
        {
        }

        public CandidatesPageMap Map 
        { 
            get
            {
                return new CandidatesPageMap();
            }
        }

        public CandidatesPageValidater Validator
        {
            get
            {
                return new CandidatesPageValidater();
            }
        }
    }
}

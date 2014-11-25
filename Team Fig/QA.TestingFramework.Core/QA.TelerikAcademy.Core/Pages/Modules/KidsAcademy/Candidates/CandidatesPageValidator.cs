namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Candidates
{
    using ArtOfTest.Common.UnitTesting;

    public class CandidatesPageValidator
    {
        private static readonly string noDecisionStatus = "Нерешен";
        private static readonly string acceptedStatus = "Приет";
        private static readonly string deniedStatus = "Неприет";

        public CandidatesPageMap PageMap
        {
            get
            {
                return new CandidatesPageMap();
            }
        }
        public void IsUndecided()
        {
            Assert.AreEqual(noDecisionStatus, this.PageMap.CandidateStatus.InnerText);
        }

        public void IsDenied()
        {
            Assert.AreEqual(deniedStatus, this.PageMap.CandidateStatus.InnerText);
        }

        public void IsAccepted()
        {
            Assert.AreEqual(acceptedStatus, this.PageMap.CandidateStatus.InnerText);
        }
    }
}

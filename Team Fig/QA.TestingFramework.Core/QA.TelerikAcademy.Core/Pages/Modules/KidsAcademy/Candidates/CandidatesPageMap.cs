namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Candidates
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class CandidatesPageMap : BaseElementMap
    {        

        public HtmlAnchor ExportToExcelButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor AllAcceptedKidsEnterAcademyButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("inAcademy");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/Administration/Navigation");
            }
        }

        public HtmlAnchor ClearDecisionButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id=\"DataGrid\"]/table/tbody/tr[1]/td[19]/a");
            }
        }

        public HtmlAnchor DenyButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id=\"DataGrid\"]/table/tbody/tr[1]/td[18]/a");
            }
        }

        public HtmlAnchor AcceptButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id=\"DataGrid\"]/table/tbody/tr[1]/td[17]/a");
            }
        }

        public HtmlTableCell CandidateStatus
        {
            get
            {
                return this.Find.ByXPath<HtmlTableCell>("//*[@id=\"DataGrid\"]/table/tbody/tr[1]/td[16]");
            }
        }
    }
}

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

        public HtmlAnchor HaideVsichkiUchenichkiButton
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
    }
}

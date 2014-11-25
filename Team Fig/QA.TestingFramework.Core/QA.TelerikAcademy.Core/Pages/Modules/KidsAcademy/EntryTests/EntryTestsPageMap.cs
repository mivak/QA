namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.EntryTests
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class EntryTestsPageMap : BaseElementMap
    {
        public HtmlAnchor CreateEntryTest
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/AdministrationKidsCandidatesExams/Read?DataGrid-mode=insert");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/AdministrationKidsCandidatesExams/Read");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=treegrid");
            }
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Documents
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class DocumentsPageMap : BaseElementMap
    {
        public HtmlAnchor AddFileButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/KidsAcademy/AdministrationKidsSchoolsDocuments/KidsSchoolDocumentCreate");
            }
        }
        
        public HtmlAnchor DownloadAllFilesButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("download-all");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/Administration/Navigation");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=grid");
            }
        }
    }
}

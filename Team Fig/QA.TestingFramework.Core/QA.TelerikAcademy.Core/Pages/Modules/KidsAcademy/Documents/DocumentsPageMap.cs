namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Documents
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class DocumentsPageMap : BaseElementMap
    {
        public HtmlAnchor AddFileButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на файл");
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
                return this.Find.ByContent<HtmlAnchor>("Обратно към администрацията");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByXPath<HtmlTable>("//*[@id='DataGrid']/table");
            }
        }

        public HtmlInputSubmit AddAttachedFile
        {
            get
            {
                return this.Find.ByExpression<HtmlInputSubmit>("value=Добавяне");
            }
        }

        public HtmlContainerControl AdminPageHeader
        {
            get
            {
                return this.Find.ByXPath<HtmlContainerControl>(
                    "//*[@id='MainContent']/h1");
            }
        }

        public HtmlSpan EmptyNameErrorMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>("//*[@id='MainContent']/form/fieldset/div[6]/span/span");
            }
        }

        public HtmlSpan KidsSchoolDropdown
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>("//*[@id='MainContent']/form/fieldset/div[2]/span[1]");
            }
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Documents
{
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Base;

    public class DocumentsPage : BasePage
    {
        public DocumentsPage()
            : base("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsSchoolsDocuments")
        {
        }

        public DocumentsPageMap Map
        {
            get
            {
                return new DocumentsPageMap();
            }
        }

        public DocumentsPageValidator Validator
        {
            get
            {
                return new DocumentsPageValidator();
            }
        }

        public void AddFileWithEmptyName()
        {
            //TODO: AddFileWIthEmptyName
        }
    }
}

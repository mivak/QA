namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Documents
{
    using ArtOfTest.Common.UnitTesting;

    public class DocumentsPageValidator
    {
        public DocumentsPageMap Map
        {
            get
            {
                return new DocumentsPageMap();
            }
        }

        public void VerifyAdminPageHeader()
        {
            Assert.AreEqual("Администрация на детската академия на Телерик",
               this.Map.AdminPageHeader.InnerText);
        }
    }
}

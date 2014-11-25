namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class KidsInSchoolMap : BaseElementMap
    {
        public HtmlAnchor KidsInSchoolLink
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Деца в школа");
            }
        }
        public HtmlContainerControl ModuleTitle
        {
            get
            {
                return this.Find.ByExpression<HtmlContainerControl>("//*[@id=\"Tabstrip-2\"]/h1".XPath());
            }
        }

        public HtmlAnchor RegisterExistingUserButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Записване на съществуващ потребител");
            }
        }

        public HtmlTable KidsInSchoolGrid
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=treegrid");
            }
        }
    }
}

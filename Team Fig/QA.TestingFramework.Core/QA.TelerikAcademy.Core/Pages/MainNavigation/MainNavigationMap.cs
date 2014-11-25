namespace QA.TelerikAcademy.Core.Pages.MainNavigation
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class MainNavigationMap : BaseElementMap
    {
        public HtmlAnchor AdminLink
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Админ");
            }
        }

        public HtmlSpan TeacherLink
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Учител");
            }
        }

        public HtmlAnchor TestSchoolLink
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Тестова школа - Варна");
            }
        }
    }
}
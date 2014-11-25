namespace QA.TelerikAcademy.Core.Pages.Navigation
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class NavigationMap : BaseElementMap
    {
        public HtmlSpan UsernameLabel
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("username".Class());
            }
        }

        public HtmlAnchor LogoutLink
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ExitMI");
            }
        }
    }
}
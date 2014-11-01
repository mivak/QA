namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class LoginPageMap : BaseElementMap
    {
        public HtmlInputText Email
        {
            get
            {
                return this.Find.ById<HtmlInputText>("UsernameOrEmail");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputSubmit Submit
        {
            get
            {
                return this.Find.ByExpression<HtmlInputSubmit>(
                    "//*[@id='MainContent']/form/fieldset/input".XPath());
            }
        }
    }
}
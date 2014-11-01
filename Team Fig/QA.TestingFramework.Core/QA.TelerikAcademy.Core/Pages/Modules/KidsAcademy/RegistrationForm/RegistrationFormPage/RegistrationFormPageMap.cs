namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class RegistrationFormPageMap : BaseElementMap
    {
        public HtmlAnchor SofiaCityLink
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>(
                    "href=/KidsAcademy/Registration/1/Sofia");
            }
        }
        
    }
}
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage
{
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Base;

    public class RegistrationFormPage : BasePage
    {
        public RegistrationFormPage()
            : base("http://test.telerikacademy.com/KidsAcademy/Registration")
        {
        }

        public RegistrationFormPageMap PageMap
        {
            get
            {
                return new RegistrationFormPageMap();
            }
        }

        public RegistrationFormValidator Validator
        {
            get
            {
                return new RegistrationFormValidator();
            }
        }

        public void GoToSofiaRegistrationForm()
        {
            this.PageMap.SofiaCityLink.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }
    }
}
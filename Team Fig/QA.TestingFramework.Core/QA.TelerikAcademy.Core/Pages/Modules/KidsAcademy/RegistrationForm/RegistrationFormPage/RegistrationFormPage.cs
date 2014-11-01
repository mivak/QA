namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage
{
    using ArtOfTest.WebAii.Core;

    public class RegistrationFormPage : BasePage
    {
        private const string RegistrationFormUrl =
            "http://test.telerikacademy.com/KidsAcademy/Registration";

        public RegistrationFormPage()
            : base(RegistrationFormUrl)
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

        public void GoToRegistrationFormModule()
        {
            this.Navigate();
        }

        public void GoToSofiaRegistrationForm()
        {
            this.PageMap.SofiaCityLink.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }
    }
}
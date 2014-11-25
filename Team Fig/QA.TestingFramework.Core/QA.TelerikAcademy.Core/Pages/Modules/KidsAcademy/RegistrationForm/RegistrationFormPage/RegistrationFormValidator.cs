namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class RegistrationFormValidator
    {
        private readonly string pageTitle = "Регистрация за \"Детската академия на Телерик\" в София - Телерик Академия - Студентска система (students system)";

        public RegistrationFormPageMap PageMap 
        {
            get
            {
                return new RegistrationFormPageMap();
            }
        }
        public void RegistrationFormPageTitle()
        {
            Assert.AreEqual(pageTitle,
                Manager.Current.ActiveBrowser.PageTitle);
        }
    }
}
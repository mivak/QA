namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormPage
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class RegistrationFormValidator
    {
        public RegistrationFormPageMap PageMap 
        {
            get
            {
                return new RegistrationFormPageMap();
            }
        }
        public void RegistrationFormPageTitle()
        {
            Assert.AreEqual("Регистрация за \"Детската академия на Телерик\" в София - Телерик Академия - Студентска система (students system)",
                Manager.Current.ActiveBrowser.PageTitle);
        }
    }
}
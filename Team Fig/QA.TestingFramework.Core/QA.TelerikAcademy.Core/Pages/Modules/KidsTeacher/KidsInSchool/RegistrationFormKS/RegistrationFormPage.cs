namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool.RegistrationFormKS
{
    using ArtOfTest.WebAii.Core;

    public class RegistrationFormPage
    {
        public RegistrationFormMap Map
        {
            get
            {
                return new RegistrationFormMap();
            }
        }

        public RegistrationFormValidator Validator
        {
            get
            {
                return new RegistrationFormValidator();
            }
        }

        public void RegisterNewUser(RegistrationEntry userProfile)
        {
            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Map.Username.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(userProfile.Username);

            this.Map.Email.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(userProfile.Email);

            this.Map.ParentFirstName.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(userProfile.ParentFirstName);

            this.Map.ParentLastName.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(userProfile.ParentLastName);

            this.Map.ParentEmail.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(userProfile.ParentEmail);

            this.Map.ParentPhone.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(userProfile.ParentPhone);

            this.Map.AddUserButton.Click();
        }
    }
}
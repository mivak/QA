namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool.RegistrationFormKS
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.ContestCreation;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContest;
    using System.Threading;
    using System.Drawing;
    using QA.TelerikAcademy.Core.Base;

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
            this.Map.Username.Click();
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

            this.Map.AddUserButton.MouseClick();
        }
    }
}

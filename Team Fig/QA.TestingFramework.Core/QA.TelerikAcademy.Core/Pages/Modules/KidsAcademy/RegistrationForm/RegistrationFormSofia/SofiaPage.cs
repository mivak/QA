namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia
{
    using System;
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Pages.Base;

    public class SofiaPage : BasePage
    {
        private readonly string xss = "<script>alert('Hello')<script>";

        public SofiaPage()
            : base("http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia")
        {
        }

        public SofiaPageMap PageMap
        {
            get
            {
                return new SofiaPageMap();
            }
        }

        public SofiaPageValidator Validator
        {
            get
            {
                return new SofiaPageValidator();
            }
        }

        public void RegisterValidUser(string username)
        {
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyPasswordUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            this.EnterUsername(username);
            this.EnterEmail();
            this.EnterFirstNameBg();

            this.EnterDateOfBirth();
            this.EnterLastNameBg();
            this.PageMap.GenderFemale.MouseClick();
            this.EnterPhone();

            this.EnterSchoolName();
            this.EnterClass();
            this.EnterAdditionalInformation();
            this.EnterCity();

            this.EnterParentFirstNameBg();
            this.EnterParentLastNameBg();
            this.EnterParentEmail();
            this.EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterPasswordNotMatchUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password + "1");

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyPasswordAgainUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyEmailUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyFirstNameBgUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyLastNameBgUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterDateOfBirth();
            EnterFirstNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyDateOfBirthUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyGenderUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyClassUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentFirstNameBgUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentLastNameBgUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentEmailUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentPhoneUser()
        {
            string username = RandomStringProvider.GetRandomStringLatin(6);
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void EnterShorterUsername()
        {
            this.EnterUsername(RandomStringProvider.GetRandomStringLatin(4));
            this.PageMap.Password.MouseClick();
        }

        public void EnterLongerUsername()
        {
            this.EnterUsername(RandomStringProvider.GetRandomStringLatin(33));
            this.PageMap.Password.MouseClick();
        }

        public void EnterInvalidUsername()
        {
            this.EnterUsername("-" + RandomStringProvider.GetRandomStringLatin(4));
            this.PageMap.Password.MouseClick();
        }

        public void EnterShorterPassword()
        {
            this.EnterUsername(RandomStringProvider.GetRandomStringLatin(6));
            this.EnterPassword(RandomStringProvider.GetRandomStringLatin(5));
            this.PageMap.PasswordAgain.MouseClick();
        }

        public void EnterLongerEmail()
        {
            string password = RandomStringProvider.GetRandomStringLatin(7);
            this.EnterUsername(RandomStringProvider.GetRandomStringLatin(6));
            this.EnterPassword(password);
            this.EnterPasswordAgain(password);
            this.PageMap.Email.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringLatin(45) +
                RandomStringProvider.GetRandomEmail());
            this.PageMap.FirstNameBg.MouseClick();
        }

        public void EnterInvalidEmail()
        {
            this.PageMap.Email.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringLatin(5));
            this.PageMap.FirstNameBg.MouseClick();
        }

        public void EnterInvalidSymbolsInFirstNameBg()
        {
            this.PageMap.FirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringLatin(5));
            this.PageMap.LastNameBg.MouseClick();
        }

        public void EnterShorterFirstNameBg()
        {
            this.PageMap.FirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringCyrillic(1));
            this.PageMap.LastNameBg.MouseClick();
        }

        public void EnterLongerFirstNameBg()
        {
            this.PageMap.FirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringCyrillic(31));
            this.PageMap.LastNameBg.MouseClick();
        }

        public void RegisterUserWithXssPassword(string username)
        {
            EnterUsername(username);
            string password = xss;
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterAdditionalInformation();
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterUserWithXssAdditionlInfo(string username)
        {
            EnterUsername(username);
            string password = RandomStringProvider.GetRandomStringLatin(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();

            this.PageMap.AdditionalInfo.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(xss);
            EnterCity();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        private void EnterParentPhone()
        {
            this.PageMap.ParentPhone.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomPhoneNumber());
        }

        private void EnterParentEmail()
        {
            this.PageMap.ParentEmail.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomEmail());
        }

        private void EnterParentLastNameBg()
        {
            this.PageMap.ParentLastNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringCyrillic(9));
        }

        private void EnterParentFirstNameBg()
        {
            this.PageMap.ParentFirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringCyrillic(7));
        }

        private void EnterAdditionalInformation()
        {
            this.PageMap.AdditionalInfo.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringLatin(20));
        }

        private void EnterCity()
        {
            this.PageMap.City.MouseClick();
            this.PageMap.City.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText("София");
        }

        private void EnterClass()
        {
            this.PageMap.Class.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.PageMap.ClassFourth.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }

        private void EnterSchoolName()
        {
            this.PageMap.SchoolName.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringLatin(10));
        }

        private void EnterPhone()
        {
            this.PageMap.Phone.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomPhoneNumber());
        }

        private void EnterLastNameBg()
        {
            this.PageMap.LastNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringCyrillic(8));
        }

        private void EnterDateOfBirth()
        {
            this.PageMap.DateOfBirth.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomDate("01/01/2007"));
        }

        private void EnterFirstNameBg()
        {
            this.PageMap.FirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomStringCyrillic(6));
        }

        private void EnterEmail()
        {
            this.PageMap.Email.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                RandomStringProvider.GetRandomEmail());
        }

        private void EnterPasswordAgain(string password)
        {
            this.PageMap.PasswordAgain.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(password);
        }

        private void EnterPassword(string password)
        {
            this.PageMap.Password.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(password);
        }

        private void EnterUsername(string username)
        {
            this.PageMap.Username.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(username);
        }
    }
}
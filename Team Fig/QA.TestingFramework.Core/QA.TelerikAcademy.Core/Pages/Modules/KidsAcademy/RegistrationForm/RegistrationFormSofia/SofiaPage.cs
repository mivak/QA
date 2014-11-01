namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia
{
    using System;
    using ArtOfTest.WebAii.Core;
    using System.Text;

    public class SofiaPage : BasePage
    {
        private const string RegistrationFormUrl =
            "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia";

        private const string EnglishLetters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private const string BulgarianLetters =
            "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯабвгдежзийклмнопрстуфхцчшщъьюя";

        private readonly Random random = new Random();

        public SofiaPage()
            : base(RegistrationFormUrl)
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

        public void GoToSofiaPage()
        {
            this.Navigate();
        }

        public string GetRandomEnglishString(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(EnglishLetters[random.Next(EnglishLetters.Length)]);
            }

            return text.ToString();
        }

        public string GetRandomBulgarianString(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(BulgarianLetters[random.Next(BulgarianLetters.Length)]);
            }

            return text.ToString();
        }

        public string GetRandomDate()
        {
            int year = random.Next(1997, 2010);
            int month = random.Next(1, 12);
            int day = random.Next(1, 31);

            StringBuilder date = new StringBuilder();
            if (day < 10)
            {
                date.Append("0");
            }

            date.Append(day.ToString());
            date.Append("/");

            if (month < 10)
            {
                date.Append("0");
            }

            date.Append(month.ToString());
            date.Append("/");
            date.Append(year.ToString());

            return date.ToString();
        }

        public string GetRandomEmail()
        {
            StringBuilder email = new StringBuilder();
            email.Append(this.GetRandomEnglishString(5));
            email.Append("@");
            email.Append(this.GetRandomEnglishString(4));
            email.Append(".");
            email.Append(this.GetRandomEnglishString(3));

            return email.ToString();
        }

        public string GetRandomPhoneNumber()
        {
            string phoneNumber = "0888" +
                this.random.Next(100000, 999999).ToString();

            return phoneNumber;
        }

        public void RegisterValidUser(string username)
        {
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
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
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyPasswordUser()
        {
            string username = this.GetRandomEnglishString(6);
            this.EnterUsername(username);
            this.EnterEmail();
            this.EnterFirstNameBg();

            this.EnterDateOfBirth();
            this.EnterLastNameBg();
            this.PageMap.GenderFemale.MouseClick();
            this.EnterPhone();

            this.EnterSchoolName();
            this.EnterClass();
            this.EnterCity();

            this.EnterAdditionalInformation();

            this.EnterParentFirstNameBg();
            this.EnterParentLastNameBg();
            this.EnterParentEmail();
            this.EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterPasswordNotMatchUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
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
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyEmailUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyFirstNameBgUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyLastNameBgUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterDateOfBirth();
            EnterFirstNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyDateOfBirthUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyGenderUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            EnterPhone();
            EnterSchoolName();
            EnterClass();
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyClassUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
            EnterPassword(password);
            EnterPasswordAgain(password);

            EnterEmail();
            EnterFirstNameBg();
            EnterDateOfBirth();
            EnterLastNameBg();

            this.PageMap.GenderFemale.MouseClick();

            EnterPhone();
            EnterSchoolName();
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentFirstNameBgUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
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
            EnterCity();
            EnterAdditionalInformation();

            EnterParentLastNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentLastNameBgUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
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
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentEmail();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentEmailUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
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
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentPhone();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void RegisterEmptyParentPhoneUser()
        {
            string username = this.GetRandomEnglishString(6);
            EnterUsername(username);
            string password = this.GetRandomEnglishString(6);
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
            EnterCity();
            EnterAdditionalInformation();

            EnterParentFirstNameBg();
            EnterParentLastNameBg();
            EnterParentEmail();

            this.PageMap.TermsAndConditions.Click();
            this.PageMap.RegistrationButton.Click();
        }

        public void EnterShorterUsername()
        {
            this.EnterUsername("asdf");
            this.PageMap.Password.MouseClick();
        }

        // 33 letters
        public void EnterLongerUsername()
        {
            this.EnterUsername("asdfasdfasdfasdfasdfasdfasdfasdfa");
            this.PageMap.Password.MouseClick();
        }

        public void EnterInvalidUsername()
        {
            this.EnterUsername("-asdf");
            this.PageMap.Password.MouseClick();
        }

        private void EnterParentPhone()
        {
            this.PageMap.ParentPhone.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomPhoneNumber());
        }

        private void EnterParentEmail()
        {
            this.PageMap.ParentEmail.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomEmail());
        }

        private void EnterParentLastNameBg()
        {
            this.PageMap.ParentLastNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomBulgarianString(9));
        }

        private void EnterParentFirstNameBg()
        {
            this.PageMap.ParentFirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomBulgarianString(7));
        }

        private void EnterAdditionalInformation()
        {
            this.PageMap.AdditionalInfo.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomEnglishString(20));
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
                this.GetRandomEnglishString(10));
        }

        private void EnterPhone()
        {
            this.PageMap.Phone.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomPhoneNumber());
        }

        private void EnterLastNameBg()
        {
            this.PageMap.LastNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomBulgarianString(8));
        }

        private void EnterDateOfBirth()
        {
            this.PageMap.DateOfBirth.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomDate());
        }

        private void EnterFirstNameBg()
        {
            this.PageMap.FirstNameBg.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomBulgarianString(6));
        }

        private void EnterEmail()
        {
            this.PageMap.Email.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(
                this.GetRandomEmail());
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
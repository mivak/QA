namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class SofiaPageValidator
    {
        private readonly string usernameRequiredMessage = "Потребителското име е задължително";
        private readonly string passwordRequiredMessage = "Паролата е задължителна";
        private readonly string passwordAgainRequiredMessage = "Повторното въвеждане на паролата е задължително";
        private readonly string emailRequiredMessage = "Имейлът е задължителен";
        private readonly string firstNameBgRequiredMessage = "Името е задължително";
        private readonly string lastNameBgRequiredMessage = "Фамилията е задължителна";
        private readonly string dateOfBirthRequiredMessage = "Датата на раждане е задължителна";
        private readonly string genderRequiredMessage = "Моля, изберете пол";
        private readonly string classRequiredMessage = "Избирането на клас е задължително";
        private readonly string parentFirstNameBgRequiredMessage = "Името на родителя е задължително";
        private readonly string parentLastNameBgRequiredMessage = "Фамилията на родителя е задължителна";
        private readonly string parentEmailRequiredMessage = "Имейлът на родителя е задължителен";
        private readonly string parentPhoneNumberRequiredMessage = "Мобилният телефон на родителя е задължителен";

        private readonly string passwordsDoNotMatchMessage = "Паролите не съвпадат";
        private readonly string passwordLengthMessage = "Паролата трябва да е повече от 6 символа";
        
        private readonly string usernameLengthMessage = "Потребителското име трябва да е между 5 и 32 символа";
        private readonly string usernameAcceptedSymbolsMessage = "Потребителското име може да съдържа само малки и главни латински букви, цифри и знаците точка и долна черта. Потребителското име трябва да започва с буква и да завършва с буква или цифра.";
        
        private readonly string emailLengthMessage = "Имейлът трябва да е не по-дълъг от 50 символа";
        private readonly string emailInvalidMessage = "Моля въведете валиден имейл адрес.";
        
        private readonly string firstNameBgInvalidSymbolsMessage = "Невалидно име. Името може да съдържа само букви от българската азбука и знака тире. Минимална дължина - 2 букви.";
        private readonly string firstNameBgLengthMessage = "Името трябва да е не по-дълго от 30 и не по-къса от 2 символа.";

        public SofiaPageMap PageMap
        {
            get
            {
                return new SofiaPageMap();
            }
        }

        public void UserProfile(string username)
        {
            Assert.AreEqual(username,
                this.PageMap.UserProfile.InnerText);
        }

        public void UsernameIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(usernameRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void PasswordIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(passwordRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void PasswordAgainIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(passwordAgainRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void PasswordMatchIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(passwordsDoNotMatchMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void EmailIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(emailRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void FirstNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(firstNameBgRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void LastNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(lastNameBgRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void DateOfBirthIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(dateOfBirthRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void GenderIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(genderRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ClassIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(classRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentFirstNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(parentFirstNameBgRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentLastNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(parentLastNameBgRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentEmailIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(parentEmailRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentPhoneIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(parentPhoneNumberRequiredMessage));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void UsernameLength()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .UsernameLengthValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .UsernameLengthValidationMessage
                .InnerText.Contains(usernameLengthMessage));
        }

        public void UsernameSymbolsValidation()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .UsernameLengthValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .UsernameLengthValidationMessage
                .InnerText.Contains(usernameAcceptedSymbolsMessage));
        }

        public void PasswordLength()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .PasswordLengthValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .PasswordLengthValidationMessage
                .InnerText.Contains(passwordLengthMessage));
        }

        public void EmailLength()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .EmailValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .EmailValidationMessage
                .InnerText.Contains(emailLengthMessage));
        }

        public void EmailInvalid()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .EmailValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .EmailValidationMessage
                .InnerText.Contains(emailInvalidMessage));
        }

        public void FirstNameBgInvalid()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .FirstNameBgValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .FirstNameBgValidationMessage
                .InnerText.Contains(firstNameBgInvalidSymbolsMessage));
        }

        public void FirstNameBgLength()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .FirstNameBgValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .FirstNameBgValidationMessage
                .InnerText.Contains(firstNameBgLengthMessage));
        }
    }
}
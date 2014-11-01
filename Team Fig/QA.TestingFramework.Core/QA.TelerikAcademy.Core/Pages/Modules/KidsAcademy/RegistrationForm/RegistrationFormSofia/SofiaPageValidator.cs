namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class SofiaPageValidator
    {
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
                .InnerText.Contains(
                "Потребителското име е задължително"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void PasswordIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Паролата е задължителна"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void PasswordMatchIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Паролите не съвпадат"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void EmailIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Имейлът е задължителен"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void FirstNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Името е задължително"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void LastNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Фамилията е задължителна"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void DateOfBirthIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Датата на раждане е задължителна"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void GenderIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Моля, изберете пол"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ClassIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Избирането на клас е задължително"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentFirstNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Името на родителя е задължително"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentLastNameBgIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Фамилията на родителя е задължителна"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentEmailIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Имейлът на родителя е задължителен"));
            Assert.AreEqual(
                "http://test.telerikacademy.com/KidsAcademy/Registration/1/Sofia",
                Manager.Current.ActiveBrowser.Url);
        }

        public void ParentPhoneIsRequired()
        {
            Assert.IsTrue(this.PageMap.ValidationSummaryErrors
                .InnerText.Contains(
                "Мобилният телефон на родителя е задължителен"));
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
                .InnerText.Contains(
                "Потребителското име трябва да е между 5 и 32 символа"));
        }

        public void UsernameSymbolsValidation()
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.PageMap
                .UsernameLengthValidationMessage.IsVisible());
            Assert.IsTrue(this.PageMap
                .UsernameLengthValidationMessage
                .InnerText.Contains(
                "Потребителското име може да съдържа само малки и главни латински букви, цифри и знаците точка и долна черта. Потребителското име трябва да започва с буква и да завършва с буква или цифра."));
        }
    }
}
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool.RegistrationFormKS
{
    using ArtOfTest.Common.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RegistrationFormValidator
    {
        public RegistrationFormMap Map 
        { 
            get
            {
                return new RegistrationFormMap();
            }
        }

        public void UsernameIsInvalid()
        {
            Assert.IsNotNull(this.Map.UsernameValidationMessage);
        }

        public void UsernameEmpty()
        {
            Assert.AreEqual(this.Map.UsernameValidationMessage.TextContent, "Потребителско име е задължително");
        }

        public void EmailEmpty()
        {
            Assert.AreEqual(this.Map.EmailValidationMessage.TextContent, "Имейлът е задължително поле");
        }

        public void EmailInvalid()
        {
            Assert.AreEqual(this.Map.EmailValidationMessage.TextContent, "Моля въведете валиден имейл адрес.");
        }
        public void ParentFirstNameEmpty()
        {
            Assert.AreEqual(this.Map.ParentFirstNameValidationMessage.TextContent, "Името на родителя е задължително");
        }

        public void ParentFirstNameInvalid()
        {
            Assert.AreEqual(this.Map.ParentFirstNameValidationMessage.TextContent, "Невалидно име. Името може да съдържа само букви от българската азбука и знака тире. Минимална дължина - 2 букви.");
        }

        public void ParentFirstNameTooLong()
        {
            Assert.AreEqual(this.Map.ParentFirstNameValidationMessage.TextContent, "Името трябва да е не по-дълго от 30 и не по-къса от 2 символа.");
        }

        public void ParentLastNameEmpty()
        {
            Assert.AreEqual(this.Map.ParentLastNameValidationMessage.TextContent, "Фамилията на родителя е задължителна");
        }

        public void ParentLastNameInvalid()
        {
            Assert.AreEqual(this.Map.ParentLastNameValidationMessage.TextContent, "Невалидна фамилия. Фамилията може да съдържа само букви от българската азбука и знака тире. Минимална дължина - 2 букви.");
        }

        public void ParentLastNameTooLong()
        {
            Assert.AreEqual(this.Map.ParentLastNameValidationMessage.TextContent, "Фамилията трябва да е не по-дълга от 30 и не по-къса от 2 символа.");
        }

        public void ParentEmailEmpty()
        {
            Assert.AreEqual(this.Map.ParentEmailValidationMessage.TextContent, "Имейлът на родителя е задължителен");
        }

        public void ParentEmailInvalid()
        {
            Assert.AreEqual(this.Map.ParentEmailValidationMessage.TextContent, "Моля въведете валиден имейл адрес.");
        }

        public void ParentPhoneInvalid()
        {
            Assert.AreEqual(this.Map.ParentPhoneValidationMessage.TextContent, "Моля въведете валиден мобилен телефон (пример: 0888123456 или +359888123456)");
        }
    }
}

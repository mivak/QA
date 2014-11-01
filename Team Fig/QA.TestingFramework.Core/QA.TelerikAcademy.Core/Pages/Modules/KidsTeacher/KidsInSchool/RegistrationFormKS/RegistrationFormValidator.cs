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
        public void ParentFirstNameEmpty()
        {
            Assert.AreEqual(this.Map.ParentFirstNameValidationMessage.TextContent, "Името на родителя е задължително");
        }

        public void ParentLastNameEmpty()
        {
            Assert.AreEqual(this.Map.ParentLastNameValidationMessage.TextContent, "Фамилията на родителя е задължителна");
        }

        public void ParentEmailEmpty()
        {
            Assert.AreEqual(this.Map.ParentEmailValidationMessage.TextContent, "Имейлът на родителя е задължителен");
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool.RegistrationFormKS
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class RegistrationFormMap : BaseElementMap
    {
        public HtmlInputText Username
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlInputText Email
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Email");
            }
        }

        public HtmlInputText ParentFirstName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ParentFirstName");
            }
        }

        public HtmlInputText ParentLastName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ParentLastName");
            }
        }

        public HtmlInputText ParentEmail
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ParentEmail");
            }
        }

        public HtmlInputText ParentPhone
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ParentPhone");
            }
        }

        public HtmlAnchor AddUserButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне");
            }
        }

        public HtmlAnchor CancelRegistrationButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Отмяна");
            }
        }

        public HtmlDiv UsernameValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Username_validationMessage");
            }
        }

        public HtmlDiv EmailValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Email_validationMessage");
            }
        }

        public HtmlDiv ParentFirstNameValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("ParentFirstName_validationMessage");
            }
        }

        public HtmlDiv ParentLastNameValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("ParentLastName_validationMessage");
            }
        }

        public HtmlDiv ParentEmailValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("ParentEmail_validationMessage");
            }
        }

        public HtmlDiv ParentPhoneValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("ParentPhone_validationMessage");
            }
        }
    }
}
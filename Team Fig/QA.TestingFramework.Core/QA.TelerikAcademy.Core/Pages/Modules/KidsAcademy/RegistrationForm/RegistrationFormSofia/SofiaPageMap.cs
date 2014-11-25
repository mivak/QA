namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.RegistrationForm.RegistrationFormSofia
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class SofiaPageMap : BaseElementMap
    {
        public HtmlInputText Username 
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "Username");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>(
                    "Password");
            }
        }

        public HtmlInputPassword PasswordAgain
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>(
                    "PasswordAgain");
            }
        }

        public HtmlInputText Email
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "Email");
            }
        }

        public HtmlInputText FirstNameBg
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "FirstName");
            }
        }

        public HtmlInputText LastNameBg
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "LastName");
            }
        }

        public HtmlInputText DateOfBirth
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "BirthDay");
            }
        }

        public HtmlInputRadioButton GenderMale
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>(
                    "Male");
            }
        }

        public HtmlInputRadioButton GenderFemale
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>(
                    "Female");
            }
        }

        public HtmlInputText Phone
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "Phone");
            }
        }

        public HtmlInputText SchoolName
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "SchoolName");
            }
        }

        public HtmlDiv Class
        {
            get
            {
                return this.Find.ByXPath<HtmlDiv>(
                    "//*[@id='MainContent']/form/fieldset[1]/div[22]");
            }
        }

        public HtmlContainerControl ClassLabel
        {
            get
            {
                return this.Find.ByContent<HtmlContainerControl>(
                    "Клас");
            }
        }

        public HtmlListItem ClassFourth
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>(
                    "Четвърти");
            }
        }

        public HtmlListItem ClassFifth
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>(
                    "Пети");
            }
        }

        public HtmlInputText City
        {
            get
            {
                return this.Find.ByXPath<HtmlInputText>(
                    "//*[@id='MainContent']/form/fieldset[1]/div[24]/span[1]/span/input");
            }
        }

        public HtmlTextArea AdditionalInfo
        {
            get
            {
                return this.Find.ById<HtmlTextArea>(
                    "About");
            }
        }

        public HtmlInputText ParentFirstNameBg
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ParentFirstName");
            }
        }

        public HtmlInputText ParentLastNameBg
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ParentLastName");
            }
        }

        public HtmlInputText ParentEmail
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ParentEmail");
            }
        }

        public HtmlInputText ParentPhone
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ParentPhone");
            }
        }

        public HtmlInputCheckBox TermsAndConditions
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>(
                    "TermsAndConditions");
            }
        }

        public HtmlInputSubmit RegistrationButton
        {
            get
            {
                return this.Find.ByXPath<HtmlInputSubmit>(
                    "//*[@id='MainContent']/form/fieldset[3]/p/input");
            }
        }

        public HtmlAnchor UserProfile
        {
            get
            {
                return this.Find.ById<HtmlAnchor>(
                    "UserProfile");
            }
        }

        public HtmlDiv ValidationSummaryErrors
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>(
                    "class=validation-summary-errors");
            }
        }

        public HtmlSpan UsernameLengthValidationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(
                    "//*[@id='MainContent']/form/fieldset[1]/div[2]/span/span");
            }
        }

        public HtmlSpan PasswordLengthValidationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(
                    "//*[@id='MainContent']/form/fieldset[1]/div[4]/span/span");
            }
        }

        public HtmlSpan EmailValidationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(
                    "//*[@id='MainContent']/form/fieldset[1]/div[8]/span/span");
            }
        }

        public HtmlSpan FirstNameBgValidationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(
                    "//*[@id='MainContent']/form/fieldset[1]/div[10]/span/span");
            }
        }
    }
}
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using System.Linq;

    public class SchoolsEditPageMap : BaseElementMap
    {
        public HtmlInputText CourseInstanceName
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "CourseInstanceName");
            }
        }

        public HtmlDiv Category
        {
            get
            {
                return this.Find.ByXPath<HtmlDiv>(
                    "/html/body/div[11]/div[2]/div/div[6]");
            }
        }

        public HtmlContainerControl CategoryLabel
        {
            get
            {
                return this.Find.ByContent<HtmlContainerControl>(
                    "Категория");
            }
        }

        public HtmlListItem CategoryName5
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>(
                    "Another category");
            }
        }

        public HtmlListItem CategoryName6
        {
            get
            {
                return this.Find.ByXPath<HtmlListItem>(
                    "//*[@id='CourseInstanceCategoryId_listbox']/li[6]");
            }
        }

        public HtmlInputText StartDate
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "StartDate");
            }
        }

        public HtmlInputText EndDate
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "EndDate");
            }
        }

        public HtmlInputCheckBox IsActive
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>(
                    "IsActive");
            }
        }

        public HtmlInputCheckBox IsPublic
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>(
                    "IsPublic");
            }
        }

        public HtmlInputText LecturesPerWeek
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "LecturesPerWeek");
            }
        }

        public HtmlInputText ApplyDeadLine
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ApplyDeadline");
            }
        }

        public HtmlInputText LiveStudentsLimit
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "LiveStudentsLimit");
            }
        }

        public HtmlInputText OnlineStudentsLimit
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "OnlineStudentsLimit");
            }
        }

        public HtmlDiv Licence
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>(
                    "/html/body/div[11]/div[2]/div/div[24]".XPath());
            }
        }

        public HtmlContainerControl LicenceLabel
        {
            get
            {
                return this.Find.ByContent<HtmlContainerControl>(
                    "Лиценз за курса");
            }
        }

        public HtmlListItem LicenceShare
        {
            get
            {
                return this.Find.ByXPath<HtmlListItem>(
                    "//*[@id='CourseLicenseId_listbox']/li[2]");
            }
        }

        public HtmlListItem LicenceUse
        {
            get
            {
                return this.Find.ByXPath<HtmlListItem>(
                    "//*[@id='CourseLicenseId_listbox']/li[3]");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Update");
            }
        }

        public HtmlDiv EmptyNameValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>(
                    "CourseInstanceName_validationMessage");
            }
        }
    }
}
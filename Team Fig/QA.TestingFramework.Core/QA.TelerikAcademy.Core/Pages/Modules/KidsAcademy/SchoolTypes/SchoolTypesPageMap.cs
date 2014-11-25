namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class SchoolTypesPageMap : BaseElementMap
    {   
        public HtmlAnchor CreateSchoolTypeButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Създаване на нов тип школа");
            }
        }

        public HtmlInputNumber KidsSchoolTypeId
        {
            get
            {
                return this.Find.ById<HtmlInputNumber>(
                    "KidsSchoolTypeId");
            }
        }

        public HtmlInputText Name
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Update");
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Cancel");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Обратно към администрацията");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByXPath<HtmlTable>(
                    "//*[@id='DataGrid']/table");
            }
        }

        public HtmlContainerControl AdminPageHeader
        {
            get
            {
                return this.Find.ByXPath<HtmlContainerControl>(
                    "//*[@id='MainContent']/h1");
            }
        }

        public HtmlAnchor ColumnHeaderId
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Kids School Type Id");
            }
        }

        public HtmlAnchor ColumnHeaderName
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Name");
            }
        }

        public HtmlDiv IdValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>(
                    "KidsSchoolTypeId_validationMessage");
            }
        }

        public HtmlAnchor ChangeButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='DataGrid']/table/tbody/tr[1]/td[3]/a");
            }
        }

        public HtmlAnchor DeleteButtonFirstRow
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='DataGrid']/table/tbody/tr[1]/td[4]/a");
            }
        }

        public HtmlAnchor DeleteButtonSecondRow
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='DataGrid']/table/tbody/tr[2]/td[4]/a");
            }
        }

        public HtmlDiv CreateWindowDivContainer
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>(
                    "class=k-edit-form-container");
            }
        }
    }
}
namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.MovedLectures
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class MovedLecturesPageMap : BaseElementMap
    {
        public HtmlAnchor MovePostponeLectureButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Преместване / Отлагане на лекция");
            }
        }

        public HtmlSelect NewTrainingRoom
        {
            get
            {
                return this.Find.ById<HtmlSelect>("NewTrainingRoomId");
            }
        }

        public HtmlSpan TrainingRoomDropdownArrow
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>("/html/body/div[10]/div[2]/div/form/fieldset/div[8]/span[1]/span/span[2]/span");
            }
        }

        public HtmlAnchor ExportToExcelButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Обратно към администрацията");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByXPath<HtmlTable>("//*[@id='DataGrid']/table");
            }
        }

        public HtmlUnorderedList CoursesList
        {
            get
            {
                return this.Find.ById<HtmlUnorderedList>("CourseInstanceId_listbox");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Update");
            }
        }

        public HtmlInputText CourseInputField
        {
            get
            {
                return this.Find.ByName<HtmlInputText>("CourseInstanceId_input");
            }
        }

        public HtmlInputText NewStratTimeInputField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("NewStartTime");
            }
        }

        public HtmlAnchor ModifyButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr/td[7]/a");
            }
        }

        public HtmlAnchor DeleteButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr[1]/td[8]/a");
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
    }
}

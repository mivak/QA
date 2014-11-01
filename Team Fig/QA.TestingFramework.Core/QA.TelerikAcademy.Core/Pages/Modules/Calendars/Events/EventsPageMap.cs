namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Events
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class EventsPageMap : BaseElementMap
    {
        public HtmlAnchor CreateEventButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Добавяне на събитие");
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

        public HtmlTextArea EventDescription
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Title");
            }
        }

        public HtmlInputText EventUser
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlSelect TrainingRoom
        {
            get
            {
                return this.Find.ById<HtmlSelect>("TrainingRoomId");
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

        public HtmlInputText StartDate
        {
            get
            {
                return this.Find.ById<HtmlInputText>("StartTime");
            }
        }

        public HtmlInputText EndDate
        {
            get
            {
                return this.Find.ById<HtmlInputText>("EndTime");
            }
        }

        public HtmlAnchor ModifyButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr/td[10]/a");
            }
        }

        public HtmlAnchor DeleteButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr/td[11]/a");
            }
        }

        public HtmlDiv DescriptionErrorMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Title_validationMessage");
            }
        }

        public HtmlDiv UserErrorMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Username_validationMessage");
            }
        }

        public HtmlDiv StartDateErrorMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("StartTime_validationMessage");
            }
        }

        public HtmlDiv EndDateErrorMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("EndTime_validationMessage");
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

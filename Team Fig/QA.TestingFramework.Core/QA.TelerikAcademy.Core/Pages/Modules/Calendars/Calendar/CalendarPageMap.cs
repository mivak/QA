namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Calendar
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class CalendarPageMap : BaseElementMap
    {
        public HtmlAnchor BackToAdministrationLink
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "<< Назад към администрацията");
            }
        }

        public HtmlTable CalendarGrid
        {
            get
            {
                return this.Find.ByXPath<HtmlTable>(
                    "//*[@id='calendar']/div/div[1]/table");
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

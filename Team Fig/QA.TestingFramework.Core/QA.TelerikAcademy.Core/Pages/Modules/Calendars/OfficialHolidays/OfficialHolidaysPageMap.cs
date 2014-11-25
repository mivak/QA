namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.OfficialHolidays
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class OfficialHolidaysPageMap : BaseElementMap
    {
        public HtmlAnchor CreateHolidayButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Създай празник");
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

namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.OfficialHolidays
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class OfficialHolidaysPageMap : BaseElementMap
    {
        public HtmlAnchor CreateHolidayButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>(
                    "href=http://test.telerikacademy.com/Administration_Calendar/Holidays/HolidaysRead?DataGrid-mode=insert");
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
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/Administration/Navigation");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=grid");
            }
        }
    }
}

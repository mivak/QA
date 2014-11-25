namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.OfficialHolidays
{
    using QA.TelerikAcademy.Core.Pages.Base;
    
    public class OfficialHolidaysPage : BasePage
    {
        public OfficialHolidaysPage()
            : base("http://test.telerikacademy.com/Administration_Calendar/Holidays")
        {
        }

        public OfficialHolidaysPageMap PageMap 
        { 
            get
            {
                return new OfficialHolidaysPageMap();
            }
        }

        public OfficialHolidaysPageValidator Validator
        {
            get
            {
                return new OfficialHolidaysPageValidator();
            }
        }
    }
}

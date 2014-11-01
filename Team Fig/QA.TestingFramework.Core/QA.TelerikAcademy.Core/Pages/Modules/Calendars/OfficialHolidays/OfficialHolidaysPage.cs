namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.OfficialHolidays
{
    public class OfficialHolidaysPage : BasePage
    {
        private const string OfficialHolidaysPageUrl = "http://test.telerikacademy.com/Administration_Calendar/Holidays";
        public OfficialHolidaysPage()
            : base(OfficialHolidaysPageUrl)
        {
        }

        public OfficialHolidaysPageMap Map 
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

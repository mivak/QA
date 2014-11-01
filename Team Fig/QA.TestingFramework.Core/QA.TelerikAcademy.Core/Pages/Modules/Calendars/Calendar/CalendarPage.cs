namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Calendar
{
    public class CalendarPage : BasePage
    {
        private const string CalendarPageUrl = "http://test.telerikacademy.com/Administration_Calendar/Calendar";

        public CalendarPage()
            : base(CalendarPageUrl)
        {
        }

        public CalendarPageMap Map
        {
            get
            {
                return new CalendarPageMap();
            }
        }

        public CalendarPageValidator Validator
        {
            get
            {
                return new CalendarPageValidator();
            }
        }
    }
}

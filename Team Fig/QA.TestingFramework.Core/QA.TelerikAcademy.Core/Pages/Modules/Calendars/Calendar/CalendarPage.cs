namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Calendar
{
    using QA.TelerikAcademy.Core.Pages.Base;
    public class CalendarPage : BasePage
    {
        public CalendarPage()
            : base("http://test.telerikacademy.com/Administration_Calendar/Calendar")
        {
        }

        public CalendarPageMap PageMap
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

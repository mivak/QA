namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.Calendar
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class CalendarPageValidator
    {
        private readonly string adminPageHeader = "Администрация";

        public CalendarPageMap PageMap
        {
            get
            {
                return new CalendarPageMap();
            }
        }

        public void AdminPageHeader()
        {
            Assert.AreEqual(adminPageHeader,
                this.PageMap.AdminPageHeader.InnerText);
        }
    }
}

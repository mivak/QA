namespace QA.TelerikAcademy.Core.Pages.Modules.Calendars.OfficialHolidays
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class OfficialHolidaysPageValidator
    {
        private readonly string adminPageHeader = "Администрация";

        public OfficialHolidaysPageMap PageMap
        {
            get
            {
                return new OfficialHolidaysPageMap();
            }
        }

        public void AdminPageHeader()
        {
            Assert.AreEqual(adminPageHeader,
                this.PageMap.AdminPageHeader.InnerText);
        }
    }
}

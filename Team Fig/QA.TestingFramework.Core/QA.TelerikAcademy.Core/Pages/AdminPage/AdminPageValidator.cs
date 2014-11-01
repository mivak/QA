namespace QA.TelerikAcademy.Core.Pages.AdminPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class AdminPageValidator
    {
        public AdminPageMap AdminPageMap 
        {
            get
            {
                return new AdminPageMap();
            }
        }
        public void AdminPageTitle()
        {
            Assert.AreEqual(
                "Администрация - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void CalendarPageTitle()
        {
            Assert.AreEqual(
                "Пълен календар на събитията в академията - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void OfficialHolidaysPageTitle()
        {
            Assert.AreEqual(
                "Празници - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void EventsPageTitle()
        {
            Assert.AreEqual(
                "Събития - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void MovedLecturesPageTitle()
        {
            Assert.AreEqual(
                "Index - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void SchoolsPageTitle()
        {
            Assert.AreEqual(
                "Администрация на школи - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void SchoolTypesPageTitle()
        {
            Assert.AreEqual(
                "Администрация на типовете школи - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }


        public void KidsInSchoolsPageTitle()
        {
            Assert.AreEqual(
                "Администрация на деца в школи - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void ContestsPageTitle()
        {
            Assert.AreEqual(
                "Състезания от детската академия - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void EntryTestsPageTitle()
        {
            Assert.AreEqual(
                "Входни изпити за \"Детската академия на Телерик\" - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void CandidatesPageTitle()
        {
            Assert.AreEqual(
                "Кандидати за \"Детската академия\" - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }

        public void DocumentsPageTitle()
        {
            Assert.AreEqual(
                "Документи - Телерик Академия - Студентска система (students system)",
                this.AdminPageMap.CurrentPageTitle);
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.AdminPage
{
    using QA.TelerikAcademy.Core.Pages.Base;
    using QA.TelerikAcademy.Core.Pages.MainNavigation;

    public class AdminPage : BasePage
    {
        public AdminPage()
            : base("http://test.telerikacademy.com/Administration/Navigation")
        {
        }

        public AdminPageMap AdminPageMap
        {
            get
            {
                return new AdminPageMap();
            }
        }

        public MainNavigationMap MainNavigationMap
        {
            get
            {
                return new MainNavigationMap();
            }
        }

        public AdminPageValidator Validator
        {
            get
            {
                return new AdminPageValidator();
            }
        }

        public void GoToCalendar()
        {
            this.AdminPageMap.Calendar.Wait.ForExists();
            this.AdminPageMap.Calendar.Click();
        }

        public void GoToOfficialHolidays()
        {
            this.AdminPageMap.OfficialHolidays.Wait.ForExists();
            this.AdminPageMap.OfficialHolidays.Click();
        }

        public void GoToEvents()
        {
            this.AdminPageMap.Events.Wait.ForExists();
            this.AdminPageMap.Events.Click();
        }

        public void GoToMovedLectures()
        {
            this.AdminPageMap.MovedLectures.Wait.ForExists();
            this.AdminPageMap.MovedLectures.Click();
        }

        public void GoToSchools()
        {
            this.AdminPageMap.Schools.Wait.ForExists();
            this.AdminPageMap.Schools.Click();
        }

        public void GoToSchoolTypes()
        {
            this.AdminPageMap.SchoolTypes.Wait.ForExists();
            this.AdminPageMap.SchoolTypes.Click();
        }

        public void GoToKidsInSchools()
        {
            this.AdminPageMap.KidsInSchools.Wait.ForExists();
            this.AdminPageMap.KidsInSchools.Click();
        }

        public void GoToContests()
        {
            this.AdminPageMap.Contests.Wait.ForExists();
            this.AdminPageMap.Contests.Click();
        }

        public void GoToEntryTests()
        {
            this.AdminPageMap.EntryTests.Wait.ForExists();
            this.AdminPageMap.EntryTests.Click();
        }

        public void GoToCandidates()
        {
            this.AdminPageMap.Candidates.Wait.ForExists();
            this.AdminPageMap.Candidates.Click();
        }

        public void GoToDocuments()
        {
            this.AdminPageMap.Documents.Wait.ForExists();
            this.AdminPageMap.Documents.Click();
        }
    }
}
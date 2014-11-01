namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.EntryTests
{
    public class EntryTestsPage : BasePage
    {
        private const string EntryTestsPageUrl = "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams";

        public EntryTestsPage()
            : base(EntryTestsPageUrl)
        {
        }

        public EntryTestsPageMap Map
        {
            get
            {
                return new EntryTestsPageMap();
            }
        }

        public EntryTestsPageValidator Validator
        {
            get
            {
                return new EntryTestsPageValidator();
            }
        }
    }
}

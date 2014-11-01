namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.KidsInSchools
{
    public class KidsInSchoolsPage : BasePage
    {
         private const string KidsInSchoolsPageUrl = "http://test.telerikacademy.com/KidsAcademy/AdministrationUsersInKidsSchools";

         public KidsInSchoolsPage()
             : base(KidsInSchoolsPageUrl)
        {
        }

        public KidsInSchoolsPageMap Map
        {
            get
            {
                return new KidsInSchoolsPageMap();
            }
        }

        public KidsInSchoolsPageValidator Validator
        {
            get
            {
                return new KidsInSchoolsPageValidator();
            }
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.KidsInSchools
{
    using QA.TelerikAcademy.Core.Pages.Base;
    
    public class KidsInSchoolsPage : BasePage
    {
         public KidsInSchoolsPage()
            : base("http://test.telerikacademy.com/KidsAcademy/AdministrationUsersInKidsSchools")
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

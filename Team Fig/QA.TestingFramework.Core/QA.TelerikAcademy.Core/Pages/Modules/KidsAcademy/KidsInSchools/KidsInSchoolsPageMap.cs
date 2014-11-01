namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.KidsInSchools
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class KidsInSchoolsPageMap : BaseElementMap
    {
        public HtmlAnchor RegisterNewUser
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool/RegisterUser");
            }
        }

        public HtmlAnchor RegisterExistingUser
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/KidsAcademy/AdministrationUsersInKidsSchools/UsersInKidsSchoolsRead?UsersInKidsSchoolGrid-mode=insert");
            }
        }

        public HtmlAnchor ExportToExcelButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=http://test.telerikacademy.com/Administration/Navigation");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=grid");
            }
        }
    }
}

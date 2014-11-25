namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class ContestsPageMap : BaseElementMap
    {
        public HtmlAnchor CreateContestButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href =/KidsAcademy/AdministrationKidsCompetitions/ReadKidsCompetitions?DataGrid-mode=insert");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/AdministrationNavigation");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=treegrid");
            }
        }

        public HtmlAnchor AddUserToContestButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на потребител за състезание");
            }
        }

        public HtmlContainerControl AdminPageHeader 
        { 
            get
            {
                return this.Find.ByXPath<HtmlContainerControl>("//*[@id='MainContent']/h1");
            }
        }

        public HtmlAnchor ContestNameColumn
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Име на състезанието");
            }
        }
    }
}

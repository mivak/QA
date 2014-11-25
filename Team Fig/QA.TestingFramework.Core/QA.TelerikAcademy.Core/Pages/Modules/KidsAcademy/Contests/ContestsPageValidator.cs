using ArtOfTest.WebAii.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests
{
    public class ContestsPageValidator
    {
        public ContestsPage Page
        {
            get
            {
                return new ContestsPage();
            }
        }

        public void AdminPageHeader()
        {
            Assert.AreEqual("Администрация на детската академия на Телерик", this.Page.Map.AdminPageHeader.InnerText);
        }

        public void UserIsRegisteredToContest(string contestName, string username)
        {
            this.Page.ExpandContestUsersGrid(contestName);

            var rowContainingContest = this.Page.Map.Grid.Find.TableRow(contestName);
            var indexOfContestRow = rowContainingContest.RowIndex;

            var detailRow = this.Page.Map.Grid.Find.ByTagIndex<HtmlTableRow>("tr",indexOfContestRow+1);

            var gridFromContest = detailRow.Find.ByAttributes<HtmlTable>("role=grid");

            var usernameFromRow = gridFromContest.Find.ByContent<HtmlAnchor>(username);

            Assert.IsNotNull(usernameFromRow);
        }

        public void UserIsNotRegisteredToContest(string contestName, string username)
        {
            this.Page.ExpandContestUsersGrid(contestName);

            var rowContainingContest = this.Page.Map.Grid.Find.TableRow(contestName);
            var indexOfContestRow = rowContainingContest.RowIndex;

            var detailRow = this.Page.Map.Grid.Find.ByTagIndex<HtmlTableRow>("tr", indexOfContestRow + 1);

            var gridFromContest = detailRow.Find.ByAttributes<HtmlTable>("role=grid");

            var usernameFromRow = gridFromContest.Find.ByContent<HtmlAnchor>(username);

            Assert.IsNull(usernameFromRow);
        }
        
    }
}

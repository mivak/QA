using ArtOfTest.WebAii.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests
{
    public class ContestsPageValidator
    {
        public ContestsPageMap Map
        {
            get
            {
                return new ContestsPageMap();
            }
        }

        public void AdminPageHeader()
        {
            Assert.AreEqual("Администрация на детската академия на Телерик", this.Map.AdminPageHeader.InnerText);
        }

        public void UserIsRegisteredToContest(string contestName, string username)
        {
            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);
            var indexOfContestRow = rowContainingContest.RowIndex;

            var detailRow = this.Map.Grid.Find.ByTagIndex<HtmlTableRow>("tr",indexOfContestRow+1);

            var gridFromContest = detailRow.Find.ByAttributes<HtmlTable>("role=grid");

            var usernameFromRow = gridFromContest.Find.ByContent<HtmlAnchor>(username);

            Assert.IsNotNull(usernameFromRow);
        }

        public void UserIsNotRegisteredToContest(string contestName, string username)
        {
            var rowContainingContest = this.Map.Grid.Find.TableRow(contestName);
            var indexOfContestRow = rowContainingContest.RowIndex;

            var detailRow = this.Map.Grid.Find.ByTagIndex<HtmlTableRow>("tr", indexOfContestRow + 1);

            var gridFromContest = detailRow.Find.ByAttributes<HtmlTable>("role=grid");

            var usernameFromRow = gridFromContest.Find.ByContent<HtmlAnchor>(username);

            Assert.IsNull(usernameFromRow);
        }
        
    }
}

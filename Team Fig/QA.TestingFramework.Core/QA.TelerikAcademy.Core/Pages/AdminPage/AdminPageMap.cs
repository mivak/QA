namespace QA.TelerikAcademy.Core.Pages.AdminPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public class AdminPageMap : BaseElementMap
    {
        public string CurrentPageTitle
        {
            get
            {
                return Manager.Current.ActiveBrowser.PageTitle;
            }
        }

        public HtmlAnchor Calendar
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/a[83]");
            }
        }

        public HtmlAnchor OfficialHolidays
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Официални празници");
            }
        }

        public HtmlAnchor Events
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Събития");
            }
        }

        public HtmlAnchor MovedLectures
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Преместени лекции");
            }
        }

        public HtmlAnchor Schools
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[1]");
            }
        }

        public HtmlAnchor SchoolTypes
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[2]");
            }
        }

        public HtmlAnchor KidsInSchools
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[3]");
            }
        }

        public HtmlAnchor Contests
        {
            get
            {
                //this.OwnerBrowser.WaitForElement(new HtmlFindExpression());
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[4]");
            }
        }

        public HtmlAnchor EntryTests
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[5]");
            }
        }

        public HtmlAnchor Candidates
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[6]");
            }
        }

        public HtmlAnchor Documents
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='MainContent']/section/a[7]");
            }
        }
    }
}
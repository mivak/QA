namespace QA.Core
{
    using ArtOfTest.WebAii.Core;
    using System.Threading;

    public class Page : BasePage
    {
        private const string PageUrl =
            "http://demos.telerik.com/aspnet-ajax/grid/examples/overview/defaultcs.aspx";

        public Page()
            : base(PageUrl)
        {
        }

        public PageMap PageMap
        {
            get
            {
                return new PageMap();
            }
        }

        public Validator Validator
        {
            get
            {
                return new Validator();
            }
        }

        public void GoToPage()
        {
            this.Navigate();
        }

        public void GoToClientDataSource()
        {
            this.PageMap.AllControls.Click();
            this.PageMap.ClientDataSource.Wait.ForExists();
            this.PageMap.ClientDataSource.Click();
        }

        public void GoToIntegrationWithRadGrid()
        {
            this.GoToClientDataSource();
            this.PageMap.ApplicationScenarios.Click();
            this.PageMap.IntegrationWithRadGrid.Click();
        }

        public void AddRecord(string companyName,
            string contactName, string contactTitle)
        {
            this.GoToIntegrationWithRadGrid();

            this.PageMap.AddNewRecord.MouseClick();

            this.PageMap.RadGrid.Rows[0].Cells[1].MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(companyName);

            this.PageMap.RadGrid.Rows[0].Cells[2].MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(contactName);

            this.PageMap.RadGrid.Rows[0].Cells[3].MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(contactTitle);

            this.PageMap.SaveChanges.MouseClick();
            //Thread.Sleep(2000);
            //this.PageMap.FirstRow.Wait.ForExists();
        }
    }
}
namespace QA.Core
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    public class Validator
    {
        public PageMap PageMap
        {
            get
            {
                return new PageMap();
            }
        }

        public void ClientDataSourcePage()
        {
            string clientDataSourceTitle =
                "RadClientDataSource - Telerik's ASP.NET ClientDataSource";
            Assert.AreEqual(clientDataSourceTitle,
                this.PageMap.DemoName.InnerText);
        }

        public void IntegrationWithRadGridPage()
        {
            string demoName = 
                "ClientDataSource - Integration with RadGrid";
            Assert.AreEqual(demoName,
                this.PageMap.DemoName.InnerText);
        }

        public void RecordAdded(string companyName,
            string contactName, string contactTitle)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            Assert.AreNotEqual(" ",
                this.PageMap.FirstRow.Cells[0].InnerText);
            Assert.AreEqual(companyName,
                this.PageMap.RadGrid.BodyRows[0].Cells[1].InnerText);
            Assert.AreEqual(contactName,
                this.PageMap.FirstRow.Cells[2].InnerText);
            Assert.AreEqual(contactTitle,
                this.PageMap.FirstRow.Cells[3].InnerText);
        }
    }
}
namespace QA.Core
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class Validator
    {
        public PageMap PageMap
        {
            get
            {
                return new PageMap();
            }
        }

        public void DataFormDemoName()
        {
            string demoName =
                "RadDataForm - Telerik's ASP.NET DataForm";
            Assert.AreEqual(demoName,
                this.PageMap.DemoName.InnerText);
        }

        public void RadGridDemoName()
        {
            string demoName =
                "DataForm - Integration with RadGrid";
            Assert.AreEqual(demoName,
                this.PageMap.DemoName.InnerText);
        }

        public void RecordUpdated(string firstName,
            string lastName, string homePhone, string extension)
        {
            Assert.AreEqual(firstName,
                this.PageMap.Grid.BodyRows[0].Cells[1].InnerText);
            Assert.AreEqual(lastName,
                this.PageMap.Grid.BodyRows[0].Cells[2].InnerText);
            Assert.AreEqual(homePhone,
                this.PageMap.Grid.BodyRows[0].Cells[4].InnerText);
            Assert.AreEqual(extension,
                this.PageMap.Grid.BodyRows[0].Cells[3].InnerText);
        }
    }
}
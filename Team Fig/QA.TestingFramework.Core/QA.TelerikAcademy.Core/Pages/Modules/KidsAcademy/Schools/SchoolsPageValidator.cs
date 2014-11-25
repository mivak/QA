namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class SchoolsPageValidator
    {
        private readonly string pageHeader = "Администрация на детската академия на Телерик";
        private readonly string courseInstanceRequiredMessage = "Моля въведете името на курсовата инстанция";

        public SchoolsPageMap PageMap
        {
            get
            {
                return new SchoolsPageMap();
            }
        }

        public SchoolsEditPageMap EditPageMap
        {
            get
            {
                return new SchoolsEditPageMap();
            }
        }

        public void AdminPageHeader()
        {
            Assert.AreEqual(pageHeader,
                this.PageMap.AdminPageHeader.InnerText);
        }

        public void CoursePageHeader(string name)
        {
            Assert.AreEqual(name, 
                this.PageMap.CourseHeaderName.InnerText);
        }

        public void NameChangedTo(string name)
        {
            Assert.AreEqual(name,
                this.PageMap.InnerGrid.Rows[0].Cells[1].InnerText);
        }

        public void EmptyNameMessageDisplayed()
        {
            Assert.IsTrue(this.EditPageMap
                .EmptyNameValidationMessage.IsVisible());
            Assert.AreEqual(courseInstanceRequiredMessage,
                this.EditPageMap
                .EmptyNameValidationMessage.InnerText);
        }

        public void CategoryChanged(string category)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.AreEqual(category,
                this.PageMap.InnerGrid.Rows[0].Cells[2].InnerText);
        }

        public void DatesChanged(string startDate, string endDate)
        {
            Assert.AreEqual(startDate,
                this.PageMap.InnerGrid.Rows[0].Cells[3].InnerText);
            Assert.AreEqual(endDate,
                this.PageMap.InnerGrid.Rows[0].Cells[4].InnerText);
        }

        public void DatesNotChanged(string startDate, string endDate)
        {
            Assert.AreNotEqual(startDate,
                this.PageMap.InnerGrid.Rows[0].Cells[3].InnerText);
            Assert.AreNotEqual(endDate,
                this.PageMap.InnerGrid.Rows[0].Cells[4].InnerText);
        }

        public void LicenseChanged(string license)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Assert.IsTrue(this.EditPageMap.Licence.InnerText
                .Contains(license));
        }
    }
}
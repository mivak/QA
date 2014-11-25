namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools
{
    using System;

    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Base;
    
    public class SchoolsPage : BasePage
    {
        public SchoolsPage()
            : base("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsSchools")
        {
        }

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

        public SchoolsPageValidator Validator
        {
            get
            {
                return new SchoolsPageValidator();
            }
        }

        public string GetFirstCourseName()
        {
            this.PageMap.Grid.BodyRows[1].Cells[0].MouseClick();
            Manager.Current.ActiveBrowser.WaitForElement(5000,
                "xpath=//*[@id='KidsSchool_8']/table");
            Manager.Current.ActiveBrowser.RefreshDomTree();
            return this.PageMap.InnerGrid.BodyRows[0].Cells[1].InnerText;
        }

        public void GoToFirstCourse()
        {
            this.PageMap.CourseNameLink.Click();
        }

        public void ChangeName(string name)
        {
            GoToSchoolsEditPage();

            this.EditPageMap.CourseInstanceName.MouseClick();
            this.EditPageMap.CourseInstanceName.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(name);
            this.EditPageMap.UpdateButton.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }

        public string ChangeCategory()
        {
            GoToSchoolsEditPage();
            
            this.EditPageMap.CategoryLabel.MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();

            if (this.EditPageMap.Category.InnerText.Contains(
                "Another category"))
            {
                this.EditPageMap.CategoryName6.Click();
                this.EditPageMap.UpdateButton.Click();
                return "Team Fig Testing";
            }
            else
            {
                this.EditPageMap.CategoryName5.Click();
                this.EditPageMap.UpdateButton.Click();
                return "Another category";
            }
        }

        public void ChangeStartDate(string startDate)
        {
            this.EditPageMap.StartDate.MouseClick();
            this.EditPageMap.StartDate.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(startDate);
            this.EditPageMap.UpdateButton.Click();
            this.PageMap.InnerGrid.Rows[0].Cells[3].Wait.ForContent(
                ArtOfTest.WebAii.ObjectModel.FindContentType.InnerText,
                startDate);
        }

        public void ChangeEndDate(string endDate)
        {
            GoToSchoolsEditPage();
            this.EditPageMap.EndDate.MouseClick();
            this.EditPageMap.EndDate.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(endDate);
        }

        public string ChangeLicense()
        {
            GoToSchoolsEditPage();

            this.EditPageMap.LicenceLabel.MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();

            if (this.EditPageMap.Licence.InnerText.Contains(
                "Лиценз за използване на материали (с некомерсиална цел)"))
            {
                this.EditPageMap.LicenceShare.Click();
                return "Лиценз за промяна и споделяне на материали (с некомерсиална цел) ";
            }
            else
            {
                this.EditPageMap.LicenceUse.Click();
                return "Лиценз за използване на материали (с некомерсиална цел)";
            }
        }

        private void GoToSchoolsEditPage()
        {
            this.PageMap.Grid.BodyRows[1].Cells[0].MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(5000,
                "class=k-button k-button-icontext k-grid-edit");
            this.PageMap.EditButton.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }
    }
}
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools
{
    using System;
    using System.Text;

    using ArtOfTest.WebAii.Core;
    
    public class SchoolsPage : BasePage
    {
        private const string SchoolsPageUrl =
            "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsSchools";

        private const string Letters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private readonly Random random = new Random();

        public SchoolsPage()
            : base(SchoolsPageUrl)
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

        public void GoToSchoolsModule()
        {
            this.Navigate();
        }

        public string GetRandomString(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(Letters[random.Next(Letters.Length)]);
            }

            return text.ToString();
        }

        // prevDate should be in format "01/01/2012"
        public string GetRandomDateAfter(string prevDate)
        {
            int prevDay = int.Parse(prevDate.Substring(0, 2));
            int prevMonth = int.Parse(prevDate.Substring(3, 2));
            int prevYear = int.Parse(prevDate.Substring(6, 4));

            int year = random.Next(prevYear, prevYear + 1);
            int month = 0;
            int day = 0;

            if (year > prevYear)
            {
                month = random.Next(1, 12);
            }
            else
            {
                month = random.Next(prevMonth, 12);
            }
            
            if (year == prevYear && month == prevMonth)
            {
                day = random.Next(prevDay, 31);
            }
            else
            {
                day = random.Next(1, 31);
            }

            StringBuilder date = new StringBuilder();
            if (day < 10)
            {
                date.Append("0");
            }

            date.Append(day.ToString());
            date.Append("/");

            if (month < 10)
            {
                date.Append("0");
            }

            date.Append(month.ToString());
            date.Append("/");
            date.Append(year.ToString());

            return date.ToString();
        }

        public string GetFirstCourseName()
        {
            this.PageMap.ShowInnerGridButton.Click();
            this.PageMap.InnerGrid.Wait.ForExists();
            return this.PageMap.InnerGrid.Rows[0].Cells[1].InnerText;
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
            this.PageMap.ShowInnerGridButton.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.PageMap.EditButton.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }
    }
}
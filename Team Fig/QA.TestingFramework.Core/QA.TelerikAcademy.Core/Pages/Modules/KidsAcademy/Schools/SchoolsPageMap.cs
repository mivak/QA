﻿namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Schools
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class SchoolsPageMap : BaseElementMap
    {
        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Обратно към администрацията");
            }
        }

        public HtmlContainerControl AdminPageHeader
        {
            get
            {
                return this.Find.ByXPath<HtmlContainerControl>(
                    "//*[@id='MainContent']/h1");
            }
        }

        public HtmlAnchor ShowInnerGridButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='DataGrid']/table/tbody/tr[1]/td[1]/a");
            }
        }

        public HtmlAnchor CourseNameLink
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='KidsSchool_9']/table/tbody/tr/td[2]/a");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ByXPath<HtmlTable>(
                    "//*[@id='DataGrid']/table");
            }
        }

        public HtmlTable InnerGrid
        {
            get
            {
                return this.Find.ByXPath<HtmlTable>(
                    "//*[@id='KidsSchool_" +
                    this.Grid.Rows[0].Cells[2].InnerText +
                "']/table");
            }
        }

        public HtmlContainerControl CourseHeaderName
        {
            get
            {
                return this.Find.ByXPath<HtmlContainerControl>(
                    "//*[@id='MainContent']/h1");
            }
        }

        public HtmlAnchor EditButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='KidsSchool_" +
                    this.Grid.Rows[0].Cells[2].InnerText +
                    "']/table/tbody/tr/td[10]/a");
            }
        }
    }
}
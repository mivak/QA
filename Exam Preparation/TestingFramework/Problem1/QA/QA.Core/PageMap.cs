namespace QA.Core
{
    using QA.TestingFramework;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class PageMap : BaseElementMap
    {
        public HtmlAnchor AllControls
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("allControls");
            }
        }

        public HtmlAnchor ClientDataSource
        {
            get
            {
                return this.Find.ById<HtmlAnchor>(
                    "ctl00_SliderControlList_ControlsSiteMap_i7_NodeLink");
            }
        }

        public HtmlSpan DemoName
        {
            get
            {
                return this.Find.ById<HtmlSpan>(
                    "ctl00_DemoName");
            }
        }

        public HtmlSpan ApplicationScenarios
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>(
                    "Application Scenarios");
            }
        }

        public HtmlAnchor IntegrationWithRadGrid
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>(
                    "Integration with RadGrid");
            }
        }

        public HtmlAnchor AddNewRecord
        {
            get
            {
                return this.Find.ById<HtmlAnchor>(
                    "ctl00_ContentPlaceHolder1_RadGrid1_ctl00_ctl02_ctl00_InitInsertButton");
            }
        }

        public HtmlAnchor SaveChanges
        {
            get
            {
                return this.Find.ById<HtmlAnchor>(
                    "ctl00_ContentPlaceHolder1_RadGrid1_ctl00_ctl02_ctl00_SaveChangesButton");
            }
        }

        public HtmlTableRow FirstRow
        {
            get
            {
                return this.Find.ById<HtmlTableRow>(
                    "ctl00_ContentPlaceHolder1_RadGrid1_ctl00__-1");
            }
        }

        public HtmlTable RadGrid
        {
            get
            {
                return this.Find.ById<HtmlTable>(
                    "ctl00_ContentPlaceHolder1_RadGrid1_ctl00");
            }
        }

        public HtmlTable Rad
        {
            get
            {
                return this.Find.ById<HtmlTable>(
                    "ctl00_ContentPlaceHolder1_RadGrid1_ctl00");
            }
        }
    }
}
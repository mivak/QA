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

        public HtmlAnchor DataForm
        {
            get
            {
                return this.Find.ById<HtmlAnchor>(
                    "ctl00_SliderControlList_ControlsSiteMap_i11_NodeLink");
            }
        }

        public HtmlSpan DemoName
        {
            get
            {
                return this.Find.ById<HtmlSpan>("ctl00_DemoName");
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

        public HtmlInputSubmit EditButton
        {
            get
            {
                return this.Find.ById<HtmlInputSubmit>(
                    "ctl00_ContentPlaceHolder1_RadDataForm1_ctrl0_ButtonEdit");
            }
        }

        public HtmlInputText EditFirstNameInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ctl00_ContentPlaceHolder1_RadDataForm1_ctrl0_FirstNameTextBox2");
            }
        }

        public HtmlInputText EditLastNameInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ctl00_ContentPlaceHolder1_RadDataForm1_ctrl0_LastNameTextBox2");
            }
        }

        public HtmlInputText EditHomePhoneInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ctl00_ContentPlaceHolder1_RadDataForm1_ctrl0_HomePhoneTextBox2");
            }
        }

        public HtmlInputText EditExtensionInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>(
                    "ctl00_ContentPlaceHolder1_RadDataForm1_ctrl0_ExtensionTextBox2");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(
                    "//*[@id='dataFormDiv']/div/div[5]/a[1]");
            }
        }

        public HtmlTable Grid
        {
            get
            {
                return this.Find.ById<HtmlTable>(
                    "ctl00_ContentPlaceHolder1_RadGrid1_ctl00");
            }
        }
    }
}
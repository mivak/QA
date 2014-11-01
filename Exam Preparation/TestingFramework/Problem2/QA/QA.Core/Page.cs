namespace QA.Core
{
    using ArtOfTest.WebAii.Core;

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

        public void GoToDataForm()
        {
            this.PageMap.AllControls.Click();
            this.PageMap.DataForm.Click();
        }

        public void GoToIntegrationWithRadGrid()
        {
            this.GoToDataForm();
            this.PageMap.ApplicationScenarios.Click();
            this.PageMap.IntegrationWithRadGrid.Click();
        }

        public void EditRecord(string firstName,
            string lastName, string homePhone, string extension)
        {
            this.GoToIntegrationWithRadGrid();
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.PageMap.EditButton.MouseClick();
            
            Manager.Current.ActiveBrowser.WaitForElement(5000,
                "id=ctl00_ContentPlaceHolder1_RadDataForm1_ctrl0_ButtonUpdate");

            this.PageMap.EditFirstNameInput.MouseClick();
            this.PageMap.EditFirstNameInput.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(firstName);

            this.PageMap.EditLastNameInput.MouseClick();
            this.PageMap.EditLastNameInput.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(lastName);

            this.PageMap.EditHomePhoneInput.MouseClick();
            this.PageMap.EditHomePhoneInput.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(homePhone);

            this.PageMap.EditExtensionInput.MouseClick();
            this.PageMap.EditExtensionInput.Text = string.Empty;
            Manager.Current.Desktop.KeyBoard.TypeText(extension);

            this.PageMap.UpdateButton.MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.PageMap.Grid.BodyRows[0].Cells[1].Wait.ForContent(
                ArtOfTest.WebAii.ObjectModel.FindContentType.InnerText,
                firstName);
        }
    }
}
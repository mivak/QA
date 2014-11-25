namespace QA.TelerikAcademy.Core.Pages.Base
{
    using ArtOfTest.WebAii.Core;

    public abstract class BasePage : IPage
    {
        public BasePage(string url)
        {
            this.Url = url;
        }

        public string Url { get; set; }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }
    }
}
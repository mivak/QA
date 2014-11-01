namespace QA.Core
{
    using ArtOfTest.WebAii.Core;

    public class BasePage
    {
        protected readonly string url;

        public BasePage(string url)
        {
            this.url = url;
        }
        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.url);
        }
    }
}
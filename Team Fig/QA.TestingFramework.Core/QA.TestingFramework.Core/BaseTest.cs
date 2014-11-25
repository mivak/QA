namespace QA.TelerikAcademy.Core
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ArtOfTest.WebAii.Core;

    [TestClass]
    public class BaseTest
    {
        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        [ClassInitialize]
        public static void CoreClassInit()
        {
        }

        [TestInitialize]
        public void CoreTestInit()
        {
            this.InitializeBrowser();
            this.TestInit();
        }

        [TestCleanup]
        public void CoreTestCleanUp()
        {
            this.TestCleanUp();
        }

        [ClassCleanup]
        public void CoreClassCleanUp()
        {
            this.DisposeBrowser();
        }

        protected virtual void TestCleanUp()
        {
        }

        protected virtual void TestInit()
        {
        }

        private void InitializeBrowser()
        {
            if (Manager.Current == null)
            {
                Settings mySettings = new Settings();
                mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
                mySettings.Web.RecycleBrowser = true;
                mySettings.UnexpectedDialogAction = UnexpectedDialogAction.HandleAndContinue;
                var manager = new Manager(mySettings);
                manager.Start();
            }

            Manager.Current.LaunchNewBrowser();
            Manager.Current.ActiveBrowser.Refresh();
            Manager.Current.ActiveBrowser.ClearCache(BrowserCacheType.Cookies);
            Manager.Current.ActiveBrowser.Window.Maximize();
        }

        public void DisposeBrowser()
        {
            foreach (var currentBrowser in Manager.Current.Browsers)
            {
                currentBrowser.Close();
            }

            Manager.Current.Dispose();
        }
    }
}
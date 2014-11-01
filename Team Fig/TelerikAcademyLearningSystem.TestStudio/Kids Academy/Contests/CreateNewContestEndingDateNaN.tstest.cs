using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TelerikAcademyLearningSystem
{

    public class CreateNewContestEndingDateNaN : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"Enter text '' in 'BGCoderContestIdNumber' - DataDriven: [$(BgCoderID)]")]
        //public void CreateNewUnofficialContest_CodedStep()
        //{
            //// Enter text '' in 'BGCoderContestIdNumber'
            //Actions.SetText(Pages.СъстезанияОтДетската.BGCoderContestIdNumber, ((System.Convert.ChangeType(Data["BgCoderID"], typeof(int))).ToString()));
            
        //}
    
        //[CodedStep(@"RefreshPage")]
        //public void CreateNewUnofficialContest_CodedStep1()
        //{
            //ActiveBrowser.Refresh();
        //}
    
        [CodedStep(@"Enter text '' in 'BGCoderContestIdNumber' - DataDriven: [$(BgCoderID)]")]
        public void CreateNewContestNoEndingDate_CodedStep()
        {
            // Enter text '' in 'BGCoderContestIdNumber'
            Actions.SetText(Pages.СъстезанияОтДетската.BGCoderContestIdNumber, ((System.Convert.ChangeType(Data["BgCoderID"], typeof(int))).ToString()));
            
        }
    
        [CodedStep(@"RefreshPage")]
        public void CreateNewContestNoEndingDate_CodedStep1()
        {
            ActiveBrowser.Refresh();
        }
    }
}

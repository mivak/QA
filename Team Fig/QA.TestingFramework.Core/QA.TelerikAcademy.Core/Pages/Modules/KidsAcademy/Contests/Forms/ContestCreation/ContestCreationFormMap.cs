namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.ContestCreation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class ContestCreationFormMap:BaseElementMap
    {
        public HtmlInputNumber BgCoderId 
        { 
            get
            {
                return this.Find.ById<HtmlInputNumber>("BGCoderContestId");
            }
        }

        public HtmlInputText ContestName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }


        public HtmlInputText StartTime
        {
            get
            {
                return this.Find.ById<HtmlInputText>("StartTime");
            }
        }

        public HtmlInputText EndTime
        {
            get
            {
                return this.Find.ById<HtmlInputText>("EndTime");
            }
        }

        public HtmlInputText ActiveTo
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ActiveTo");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("/html/body/div[9]/div[2]/div/div[13]/a[1]".XPath());
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("Cancel".InnerTextContaining());
            }
        }

        public HtmlAnchor CloseButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("Close".InnerTextContaining());
            }
        }

        public HtmlDiv BgCoderIdValidation
        {
            get
            {
                return this.Find.ById<HtmlDiv>("BGCoderContestId_validationMessage");
            }
        }

        public HtmlDiv StartTimeValidation
        {
            get
            {
                return this.Find.ById<HtmlDiv>("StartTime_validationMessage");
            }
        }

        public HtmlDiv EndTimeValidation
        {
            get
            {
                return this.Find.ById<HtmlDiv>("EndTime_validationMessage");
            }
        }
    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class AddUserToContestFormMap:BaseElementMap
    {
        public HtmlInputText Username
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlInputText Points
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Points");
            }
        }

        public HtmlSelect IsTaken
        {
            get
            {
                return this.Find.ById<HtmlSelect>("IsTaken");
            }
        }

        public HtmlDiv UsernameValidationMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("data-for=Username");
            }

        }

        public HtmlDiv PointsValidationMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("data-for=Points");
            }

        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("k-button k-button-icontext k-primary k-grid-update".Class());
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("k-button k-button-icontext k-grid-cancel".Class());
            }
        }
    }
}

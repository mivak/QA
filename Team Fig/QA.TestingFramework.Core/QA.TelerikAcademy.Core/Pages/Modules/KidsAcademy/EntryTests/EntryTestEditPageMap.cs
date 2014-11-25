namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.EntryTests
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using System.Linq;

    public class EntryTestEditPageMap : BaseElementMap
    {
        public HtmlSelect TestConfiguration
        {
            get
            {
                return this.Find.ById<HtmlSelect>(
                    "TestConfigurationId");
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

        public HtmlSelect TrainingRoom
        {
            get
            {
                return this.Find.ById<HtmlSelect>("TrainingRoomId");
            }
        }

        public HtmlSelect CandidateForCity
        {
            get
            {
                return this.Find.ById<HtmlSelect>("CandidateForCityId");
            }
        }
        public HtmlInputText CandidatesCountLimit
        {
            get
            {
                return this.Find.ById<HtmlInputText>("CandidatesCountLimit");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Update");
            }
        }
    }
}
using ArtOfTest.Common.UnitTesting;
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.EntryTests
{
    public class EntryTestsPageValidator
    {
        public EntryTestsPageMap PageMap
        {
            get
            {
                return new EntryTestsPageMap();
            }
        }

        public EntryTestEditPageMap EditPageMap
        {
            get
            {
                return new EntryTestEditPageMap();
            }
        }

        public void EntryTestCreated(string testConfiguration, string startDateTime, string endDateTime, string city, string trainingRoom, string candidateCountLimit)
        {
            this.PageMap.Grid.BodyRows[0].Cells[12].Click();

            Assert.AreEqual(startDateTime, this.EditPageMap.StartTime.Value);
            Assert.AreEqual(endDateTime, this.EditPageMap.EndTime.Value);
            Assert.AreEqual(candidateCountLimit, this.EditPageMap.CandidatesCountLimit.Value);

        }
    }
}

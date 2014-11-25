using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System.Threading;
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContestForm
{
    public class AddUserToContestFormValidator
    {
        public AddUserToContestFormMap Map
        {
            get
            {
                return new AddUserToContestFormMap();
            }
        }

        public void Username()
        {
            Assert.IsFalse(this.Map.UsernameValidationMessage.IsVisible());
        }

        public void UserDoesNotExist()
        {
            Assert.AreEqual("Няма такъв потребител!", this.Map.UsernameValidationMessage.TextContent);
        }

        public void DuplicateUser()
        {
            Assert.AreEqual("Потребителят вече е записан за това състезание!", this.Map.UsernameValidationMessage.InnerText);
        }

        public void Points()
        {
            Assert.AreEqual("Въведента стойност трябва да е число.", this.Map.PointsValidationMessage.TextContent);
        }
    }
}

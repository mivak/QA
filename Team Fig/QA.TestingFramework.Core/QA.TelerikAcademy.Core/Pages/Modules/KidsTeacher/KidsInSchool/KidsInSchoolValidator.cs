namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class KidsInSchoolValidator
    {
        public KidsInSchoolMap Map
        {
            get
            {
                return new KidsInSchoolMap();
            }
        }

        public void ModuleTitle()
        {
            Assert.IsTrue(this.Map.ModuleTitle.InnerText.Contains("Деца в школа"));
        }

        public void UserIsRegistered(string username)
        {
            var usernameLink = this.Map.KidsInSchoolGrid.Find.ByContent<HtmlAnchor>(username);

            Assert.IsNotNull(usernameLink);
        }

        public void UserIsNotRegistered(string username)
        {
            var usernameLink = this.Map.KidsInSchoolGrid.Find.ByContent<HtmlAnchor>(username);

            Assert.IsNull(usernameLink);
        }
    }
}

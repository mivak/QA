namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ContestCreationFormValidator
    {
        public ContestCreationFormMap ContestCreationForm 
        { 
            get
            {
                return new ContestCreationFormMap();
            }
        }

        public void BgCoderIdIsValid()
        {
            Assert.IsFalse(this.ContestCreationForm.BgCoderIdValidation.IsVisible());
        }

        public void StartTimeIsValid()
        {
            Assert.IsFalse(this.ContestCreationForm.StartTimeValidation.IsVisible());
        }

        public void EndTimeIsValid()
        {
            Assert.IsFalse(this.ContestCreationForm.EndTimeValidation.IsVisible());
        }
    }
}

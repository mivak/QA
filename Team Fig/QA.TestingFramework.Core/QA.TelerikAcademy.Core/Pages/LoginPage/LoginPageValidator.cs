namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Data;

    public class LoginPageValidator
    {
        public NavigationMap NavigationMap
        {
            get
            {
                return new NavigationMap();
            }
        }

        public void UserLabel(User user)
        {
            Assert.AreEqual(user.Username,
                this.NavigationMap.UsernameLabel.InnerText);
        }
    }
}
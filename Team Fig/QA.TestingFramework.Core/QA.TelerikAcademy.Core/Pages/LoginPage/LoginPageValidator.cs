namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Navigation;

    public class LoginPageValidator
    {
        public NavigationMap NavigationMap
        {
            get
            {
                return new NavigationMap();
            }
        }

        public void UserLabel(IUser user)
        {
            Assert.AreEqual(user.Username,
                this.NavigationMap.UsernameLabel.InnerText);
        }
    }
}
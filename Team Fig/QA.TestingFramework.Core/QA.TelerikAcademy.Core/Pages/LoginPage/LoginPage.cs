namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Base;
    using QA.TelerikAcademy.Core.Pages.Navigation;

    public class LoginPage : BasePage
    {
        public LoginPage()
            :base("http://test.telerikacademy.com/Users/Auth/Login")
        {
        }

        public LoginPageMap Map
        {
            get
            {
                return new LoginPageMap();
            }
        }

        public NavigationMap NavigationMap
        {
            get
            {
                return new NavigationMap();
            }
        }

        public LoginPageValidator Validator
        {
            get
            {
                return new LoginPageValidator();
            }
        }

        public void LoginUser(IUser user)
        {
            this.Navigate();
            this.Map.Email.Text = user.Email;
            this.Map.Password.Text = user.Password;
            this.Map.Submit.Click();
            this.NavigationMap.UsernameLabel.Wait.ForExists();
        }
    }
}
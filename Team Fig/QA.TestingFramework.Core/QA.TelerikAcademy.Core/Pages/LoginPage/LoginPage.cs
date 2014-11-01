namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Data;

    public class LoginPage : BasePage
    {
        private const string LoginPageUrl = "http://test.telerikacademy.com/Users/Auth/Login";
        public LoginPage()
            :base(LoginPageUrl)
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

        public void LoginUser(User user)
        {
            this.Navigate();
            this.Map.Email.Text = user.Email;
            this.Map.Password.Text = user.Password;
            this.Map.Submit.Click();
            this.NavigationMap.UsernameLabel.Wait.ForExists();
        }
    }
}
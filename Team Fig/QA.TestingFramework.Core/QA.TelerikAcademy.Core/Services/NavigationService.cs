namespace QA.TelerikAcademy.Core.Services
{
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Base;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using QA.TelerikAcademy.Core.Providers;

    public static class NavigationService
    {
        public static void NavigateToPage(IUser user, IPage page)
        {
            var loginPage = PageProvider<LoginPage>.Instance;
            loginPage.LoginUser(user);
            page.Navigate();
        }

        public static void NavigateToPage(IPage page)
        {
            page.Navigate();
        }
    }
}
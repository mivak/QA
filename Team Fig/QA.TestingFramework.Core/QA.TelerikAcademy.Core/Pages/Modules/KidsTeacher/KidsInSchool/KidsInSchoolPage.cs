namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool
{
    using System;
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.MainNavigation;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool.RegistrationFormKS;
    using QA.TelerikAcademy.Core.Pages.Base;

    public class KidsInSchoolPage : BasePage
    {
        public KidsInSchoolPage() :
            base("http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/9")
        {
        }

        public KidsInSchoolMap Map
        {
            get
            {
                return new KidsInSchoolMap();
            }
        }

        public KidsInSchoolValidator Validator
        {
            get
            {
                return new KidsInSchoolValidator();
            }
        }

        public MainNavigationMap MainNavigationMap
        {
            get
            {
                return new MainNavigationMap();
            }
        }

        public RegistrationFormPage RegistrationForm
        {
            get
            {
                return new RegistrationFormPage();
            }
        }

        public void RegisterExistingUserToSchool(RegistrationEntry userToRegister, Action validate, bool validRegistration)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForElement(3000, "role=treegrid");

            this.Validator.UserIsNotRegistered(userToRegister.Username);

            this.Map.RegisterExistingUserButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.RegistrationForm.RegisterNewUser(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            validate();

            if (!validRegistration)
            {
                this.RegistrationForm.Map.CancelRegistrationButton.MouseClick();

                Manager.Current.ActiveBrowser.RefreshDomTree();

                this.Validator.UserIsNotRegistered(userToRegister.Username);
            }
        }

        public void RegisterDuplicateUserToSchool(RegistrationEntry userToRegister)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            Manager.Current.ActiveBrowser.WaitForElement(5000, "role=treegrid");
            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.Validator.UserIsNotRegistered(userToRegister.Username);

            this.Map.RegisterExistingUserButton.MouseClick();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.RegistrationForm.RegisterNewUser(userToRegister);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Validator.UserIsRegistered(userToRegister.Username);

            Manager.Current.ActiveBrowser.WaitForAjax(5000);

            this.Map.RegisterExistingUserButton.MouseClick();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.RegistrationForm.RegisterNewUser(userToRegister);

            this.RegistrationForm.Map.CancelRegistrationButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.RemoveUserFromSchool(userToRegister.Username);

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Validator.UserIsNotRegistered(userToRegister.Username);
        }

        public void RemoveUserFromSchool(string username)
        {
            var usernameLink = this.Map.KidsInSchoolGrid.Find.ByContent<HtmlAnchor>(username);
            var rowContainingUsername = usernameLink.Parent<HtmlTableRow>();

            var deleteButton = rowContainingUsername.Find.ByExpression<HtmlAnchor>("k-button k-button-icontext k-grid-delete".Class());

            AlertDialog alert = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            deleteButton.Focus();
            deleteButton.MouseClick(MouseClickType.LeftDoubleClick);

            try
            {
                alert.WaitUntilHandled(1000);
            }
            catch (TimeoutException)
            {
                Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);
            }

            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Validator.UserIsNotRegistered(username);
        }
    }
}
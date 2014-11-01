namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.ContestCreation;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContest;
    using System.Threading;
    using System.Drawing;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool.RegistrationFormKS;

    public class KidsInSchoolPage
    {
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

        public void Navigate()
        {
            this.MainNavigationMap.TeacherLink.MouseClick();
            this.MainNavigationMap.TestSchoolLink.MouseClick();
        }

        public RegistrationFormPage RegistrationForm
        {
            get
            {
                return new RegistrationFormPage();
            }

        }

        public void RegisterExistingUserToSchool(RegistrationEntry userProfile)
        {
            this.Map.RegisterExistingUserButton.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.RegistrationForm.RegisterNewUser(userProfile);
        }

        public void RemoveUserFromSchool(string username)
        {
            var usernameLink = this.Map.KidsInSchoolGrid.Find.ByContent<HtmlAnchor>(username);
            var rowContainingUsername = usernameLink.Parent<HtmlTableRow>();

            var deleteButton = rowContainingUsername.Find.ByExpression<HtmlAnchor>("k-button k-button-icontext k-grid-delete".Class());

            AlertDialog alert = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            deleteButton.Click();

            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
        }


    }
}

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests.Forms.AddUserToContest
{
    using System;
    using System.Threading;
    using ArtOfTest.WebAii.Core;

    public class AddUserToContestForm
    {
        public AddUserToContestFormMap Map
        {
            get
            {
                return new AddUserToContestFormMap();
            }
        }

        public AddUserToContestFormValidator Validator
        {
            get
            {
                return new AddUserToContestFormValidator();
            }
        }

        public void RegisterUser(string username, int points, string isTaken)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Map.Username.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(username);
            Thread.Sleep(1000);

            this.Map.Points.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(points.ToString());
            
            this.Map.IsTaken.Focus();
            this.Map.IsTaken.MouseClick();

            this.Map.IsTaken.MouseClick();
            this.Map.IsTaken.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(isTaken);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.IsTaken.Focus();

            this.Map.UpdateButton.MouseClick();
            Thread.Sleep(1000);
        }

        public void RegisterUserEmptyPoints(string username, string isTaken)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Map.Username.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(username);
            Thread.Sleep(1000);

            this.Map.IsTaken.Focus();
            this.Map.IsTaken.MouseClick();

            this.Map.IsTaken.MouseClick();
            this.Map.IsTaken.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(isTaken);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.IsTaken.Focus();

            this.Map.UpdateButton.MouseClick();
            Thread.Sleep(1000);
        }

        public void RegisterUserStringPoints(string username, string points, string isTaken)
        {
            Manager.Current.ActiveBrowser.RefreshDomTree();

            this.Map.Username.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(username);
            Thread.Sleep(1000);

            this.Map.Points.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(points);

            this.Map.IsTaken.Focus();
            this.Map.IsTaken.MouseClick();

            this.Map.IsTaken.MouseClick();
            this.Map.IsTaken.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(isTaken);
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            this.Map.IsTaken.Focus();

            this.Map.UpdateButton.MouseClick();
            Thread.Sleep(1000);
        }
    }
}
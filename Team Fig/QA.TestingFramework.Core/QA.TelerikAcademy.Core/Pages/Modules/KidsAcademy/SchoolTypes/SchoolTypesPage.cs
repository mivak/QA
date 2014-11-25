namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes
{
    using System.Windows.Forms;
    
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Base;

    public class SchoolTypesPage : BasePage
    {
        public SchoolTypesPage()
            : base("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsSchoolsTypes")
        {
        }

        public SchoolTypesPageMap PageMap
        {
            get
            {
                return new SchoolTypesPageMap();
            }
        }

        public SchoolTypesPageValidator Validator
        {
            get
            {
                return new SchoolTypesPageValidator();
            }
        }

        public void CreateSchoolType(string id, string name)
        {
            this.PageMap.CreateSchoolTypeButton.Click();
            this.PageMap.KidsSchoolTypeId.MouseClick();
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Back);
            Manager.Current.Desktop.KeyBoard.TypeText(id, 10);
            this.PageMap.Name.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(name, 10);
            this.PageMap.UpdateButton.Click();
        }

        public void ChangeId(string id)
        {
            this.PageMap.ChangeButton.Click();
            this.PageMap.KidsSchoolTypeId.Text = string.Empty;
            this.PageMap.KidsSchoolTypeId.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(id, 10);
            this.PageMap.UpdateButton.Click();
        }

        public void ChangeName(string name)
        {
            this.PageMap.ChangeButton.Click();
            this.PageMap.Name.Text = string.Empty;
            this.PageMap.Name.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(name, 10);
            this.PageMap.UpdateButton.Click();
        }

        public string GetRowNameContent(int row)
        {
            return this.PageMap.Grid.Rows[row].Cells[1].InnerText;
        }

        public void DeleteSecondRow()
        {
            Manager.Current.ActiveBrowser.WaitForElement(5000, "xpath=//*[@id='DataGrid']/table");
            AlertDialog alert = AlertDialog.CreateAlertDialog(
                Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            this.PageMap.DeleteButtonSecondRow.Click();

            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
        }

        public void DeleteFirstRow()
        {
            AlertDialog alert = AlertDialog.CreateAlertDialog(
                Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(alert);
            Manager.Current.DialogMonitor.Start();

            this.PageMap.DeleteButtonFirstRow.Click();

            alert.WaitUntilHandled();
            Manager.Current.DialogMonitor.RemoveDialog(alert);
            Manager.Current.DialogMonitor.Stop();
            Manager.Current.ActiveBrowser.Refresh();
        }
    }
}
namespace QA.TelerikAcademy.Tests.SchoolTypesTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Data;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using ArtOfTest.WebAii.Core;

    [TestClass]
    public class SchoolTypesTests : BaseTest
    {
        public SchoolTypesPage SchoolTypesPage { get; set; }

        public LoginPage LoginPage { get; set; }

        protected override void TestInit()
        {
            this.LoginPage = new LoginPage();

            var kidsAdminUser = User.Get(UserRoles.KidsAdmin);
            this.LoginPage.LoginUser(kidsAdminUser);
            this.LoginPage.Validator.UserLabel(kidsAdminUser);

            this.SchoolTypesPage = new SchoolTypesPage();
            this.SchoolTypesPage.GoToSchoolTypesModule();
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void VerifySchoolTypesBackToAdministrationButtonWorksCorrectly()
        {
            this.SchoolTypesPage.PageMap
                .BackToAdministrationButton.Click();
            this.SchoolTypesPage.Validator.AdminPageHeader();
        }

        [TestMethod]
        public void VerifyPagingIsCorrect()
        {
            this.SchoolTypesPage.Validator.RowsCountPerPage();
        }

        [TestMethod]
        public void VerifySortingByIdIsCorrect()
        {
            this.SchoolTypesPage.PageMap.ColumnHeaderId.Click();
            this.SchoolTypesPage.Validator.SortByColumnHeaderId();
        }

        [TestMethod]
        public void VerifySortingByNameIsCorrect()
        {
            this.SchoolTypesPage.PageMap.ColumnHeaderName.Click();
            this.SchoolTypesPage.Validator.SortByColumnHeaderName();
        }

        [TestMethod]
        // Reported bug
        public void VerifyCreatingSchoolTypeCreatesSchoolTypeWithTheSameIdAndName()
        {
            var id = "5";
            var name = "someName";
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator
                .SchoolTypeIsCreatedSuccessfully(id, name);
        }

        [TestMethod]
        public void VerifySchoolTypeIdCannotBeEmpty()
        {
            var id = string.Empty;
            var name = "text";
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.IdFieldIsRequired(id, name);
        }

        [TestMethod]
        public void VerifySchoolTypeIdCannotBeString()
        {
            var id = "text";
            var name = "text";
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator
                .SchoolTypeIsNotCreated();
        }
        
        [TestMethod]
        // Reported bug
        public void VerifyMessageIsCorrect()
        {
            var id = "text";
            var name = "text";
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.IdIsInvalid();
        }

        [TestMethod]
        public void VerifySchoolTypesNameCannotBeEmpty()
        {
            var id = "4";
            var name = string.Empty;
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator
                .SchoolTypeIsNotCreated();
        }

        [TestMethod]
        public void VerifyIdChanges()
        {
            var id = "12";
            this.SchoolTypesPage.ChangeId(id);
            this.SchoolTypesPage.Validator.IdIsChanged(id);
        }

        [TestMethod]
        public void VerifyNameChanges()
        {
            var name = "newName";
            this.SchoolTypesPage.ChangeName(name);
            this.SchoolTypesPage.Validator.NameIsChanged(name);
        }

        [TestMethod]
        public void VerifyDeleteSchoolType()
        {
            var row = 1;
            var name = 
                this.SchoolTypesPage.GetRowNameContent(row);
            this.SchoolTypesPage.DeleteSecondRow();
            this.SchoolTypesPage.Validator
                .SchoolTypeIsDeleted(name, row);
        }

        [TestMethod]
        // Reported bug
        public void VerifyDeleteFirstSchoolType()
        {
            var row = 0;
            var name =
                this.SchoolTypesPage.GetRowNameContent(row);
            this.SchoolTypesPage.DeleteFirstRow();
            this.SchoolTypesPage.Validator
                .SchoolTypeIsDeleted(name, row);
        }
    }
}
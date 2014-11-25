namespace QA.TelerikAcademy.Tests.SchoolTypes
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core;
    using QA.TelerikAcademy.Core.Attributes;
    using QA.TelerikAcademy.Core.Data.RandomDataProvider;
    using QA.TelerikAcademy.Core.Data.Users;
    using QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes;
    using QA.TelerikAcademy.Core.Providers;
    using QA.TelerikAcademy.Core.Services;

    [TestClass]
    public class SchoolTypes : BaseTest
    {
        public SchoolTypesPage SchoolTypesPage { get; set; }

        public IUser User { get; set; }

        protected override void TestInit()
        {
            this.SchoolTypesPage = PageProvider<SchoolTypesPage>.Instance;
            this.User = UserFactory.GetUser(UserRoles.KidsAdmin);
            NavigationService.NavigateToPage(this.User, SchoolTypesPage);
        }

        [ClassCleanup]
        public static void CloseBrowser()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(115), Priority(2)]
        public void VerifySchoolTypesBackToAdministrationButtonWorksCorrectly()
        {
            this.SchoolTypesPage.PageMap
                .BackToAdministrationButton.Click();
            this.SchoolTypesPage.Validator.AdminPageHeader();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(133), Priority(3)]
        public void VerifyPagingIsCorrect()
        {
            this.SchoolTypesPage.Validator.RowsCountPerPage();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(117), Priority(3)]
        public void VerifySortingByIdIsCorrect()
        {
            this.SchoolTypesPage.PageMap.ColumnHeaderId.Click();
            this.SchoolTypesPage.Validator.SortByColumnHeaderId();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(116), Priority(3)]
        public void VerifySortingByNameIsCorrect()
        {
            this.SchoolTypesPage.PageMap.ColumnHeaderName.Click();
            this.SchoolTypesPage.Validator.SortByColumnHeaderName();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(120), Priority(1)]
        [KnownIssue(2178)]
        public void VerifyCreatingSchoolTypeCreatesSchoolTypeWithTheSameIdAndName()
        {
            var id = "5";
            var name = RandomStringProvider.GetRandomStringLatin(8);
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator
                .SchoolTypeIsCreatedSuccessfully(id, name);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(125), Priority(2)]
        public void VerifySchoolTypeIdCannotBeEmpty()
        {
            var id = string.Empty;
            var name = RandomStringProvider.GetRandomStringLatin(4);
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.IdFieldIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(494), Priority(2)]
        public void VerifySchoolTypeIdCannotBeString()
        {
            var id = RandomStringProvider.GetRandomStringLatin(4);
            var name = RandomStringProvider.GetRandomStringLatin(4);
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.SchoolTypeIsNotCreated();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(124), Priority(2)]
        [KnownIssue(2186)]
        public void VerifyMessageIsCorrect()
        {
            var id = RandomStringProvider.GetRandomStringLatin(4);
            var name = RandomStringProvider.GetRandomStringLatin(4);
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.IdIsInvalid();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(126), Priority(2)]
        public void VerifySchoolTypesNameCannotBeEmpty()
        {
            var id = "4";
            var name = string.Empty;
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.SchoolTypeIsNotCreated();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(495), Priority(2)]
        [KnownIssue(2187)]
        public void VerifySchoolTypesEmptyNameValidationMessage()
        {
            var id = "4";
            var name = string.Empty;
            this.SchoolTypesPage.CreateSchoolType(id, name);
            this.SchoolTypesPage.Validator.NameFieldIsRequired();
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(127), Priority(2)]
        public void VerifyIdChanges()
        {
            var id = "12";
            this.SchoolTypesPage.ChangeId(id);
            this.SchoolTypesPage.Validator.IdIsChanged(id);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(128), Priority(2)]
        public void VerifyNameChanges()
        {
            var name = RandomStringProvider.GetRandomStringLatin(5);
            this.SchoolTypesPage.ChangeName(name);
            this.SchoolTypesPage.Validator.NameIsChanged(name);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(131), Priority(2)]
        public void VerifyDeleteSchoolType()
        {
            var row = 1;
            var name = this.SchoolTypesPage.GetRowNameContent(row);
            this.SchoolTypesPage.DeleteSecondRow();
            this.SchoolTypesPage.Validator.SchoolTypeIsDeleted(name, row);
        }

        [TestMethod]
        [Owner("Mihail")]
        [TestCase(444), Priority(2)]
        [KnownIssue(2244)]
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
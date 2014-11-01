using ArtOfTest.WebAii.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.SchoolTypes
{
    public class SchoolTypesPageValidator
    {
        public SchoolTypesPageMap PageMap
        {
            get
            {
                return new SchoolTypesPageMap();
            }
        }

        public void AdminPageHeader()
        {
            Assert.AreEqual(
                "Администрация на детската академия на Телерик", 
                this.PageMap.AdminPageHeader.InnerText);
        }

        public void RowsCountPerPage()
        {
            var rows = this.PageMap.Grid.Rows.Count;
            Assert.IsTrue(rows == 25);
        }

        public void SortByColumnHeaderId()
        {
            this.PageMap.Grid.Wait.ForExists();
            
            var table = this.PageMap.Grid;

            int rowsCount = table.Rows.Count;

            List<int> idValues = new List<int>();

            for (int i = 0; i < rowsCount; i++)
            {
                HtmlTableRow row = table.Rows[i];
                HtmlTableCell cell = row.Cells[0];
                idValues.Add(int.Parse(cell.TextContent));
            }

            for (int j = 0; j < idValues.Count; j++)
            {
                if (j + 1 == idValues.Count)
                {
                    break;
                }
                else
                {
                    Assert.IsTrue(idValues[j + 1] <= idValues[j]);
                }
            }
        }

        public void SortByColumnHeaderName()
        {
            this.PageMap.Grid.Wait.ForExists();
            var table = this.PageMap.Grid;
            int rowsCount = table.Rows.Count;

            List<string> itemNames = new List<string>();

            //Place the text content of the Order ID cell from each row into the string list.
            for (int i = 0; i < rowsCount; i++)
            {
                HtmlTableRow row = table.Rows[i];
                HtmlTableCell cell = row.Cells[1];
                itemNames.Add(cell.TextContent);
            }

            //Assert each string in the list is greater than the string before it.
            for (int j = 0; j < itemNames.Count; j++)
            {
                if (j + 1 == itemNames.Count)
                {
                    break;
                }
                else
                {
                    Assert.IsTrue(itemNames[j + 1].CompareTo(itemNames[j]) >= 0);
                }
            }
        }

        public void SchoolTypeIsCreatedSuccessfully(string id, string name)
        {
            this.PageMap.Grid.Rows[0].Cells[0].Wait.ForExists();
            var idCell = this.PageMap.Grid.Rows[0].Cells[0];
            var nameCell = this.PageMap.Grid.Rows[0].Cells[1];

            Assert.AreEqual(name, nameCell.TextContent);
            Assert.AreEqual(id, idCell.TextContent);
        }

        public void IdFieldIsRequired(string id, string name)
        {
            Assert.AreEqual(
                "The KidsSchoolTypeId field is required.", 
                this.PageMap.IdValidationMessage.InnerText);
            Assert.IsTrue(this.PageMap.IdValidationMessage.IsVisible());
        }

        public void SchoolTypeIsNotCreated()
        {
            Assert.IsTrue(this.PageMap.UpdateButton.IsVisible(), 
            "The school type is created");
        }

        public void IdIsInvalid()
        {
            Assert.AreEqual(
                "The KidsSchoolTypeId is invalid.",
                this.PageMap.IdValidationMessage.InnerText);
            Assert.IsTrue(this.PageMap.IdValidationMessage.IsVisible());
        }

        public void IdIsChanged(string id)
        {
            Assert.AreEqual(id,
                this.PageMap.Grid.Rows[0].Cells[0].InnerText);
        }

        public void NameIsChanged(string name)
        {
            Assert.AreEqual(name,
                this.PageMap.Grid.Rows[0].Cells[1].InnerText);
        }

        public void SchoolTypeIsDeleted(string name, int row)
        {
            Assert.AreNotEqual(name,
                this.PageMap.Grid.Rows[row].Cells[1].InnerText);
        }
    }
}
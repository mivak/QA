using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Documents
{
    public class DocumentsPage : BasePage
    {
        private const string DocumentsPageUrl = "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsSchoolsDocuments";

        public DocumentsPage()
            : base(DocumentsPageUrl)
        {
        }

        public DocumentsPageMap Map
        {
            get
            {
                return new DocumentsPageMap();
            }
        }

        public DocumentsPageValidator Validator
        {
            get
            {
                return new DocumentsPageValidator();
            }
        }
    }
}

using System;
using System.Linq;

namespace QA.TelerikAcademy.Core.Attributes
{

    public class KnownIssue : System.Attribute
    {
        private int bugID;

        public KnownIssue(int id)
        {
            this.bugID = id;
        }
    }
}

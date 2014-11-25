using System;
using System.Linq;

namespace QA.TelerikAcademy.Core.Attributes
{
    public class TestCase : System.Attribute
    {
        private int testID;

        public TestCase(int id)
        {
            this.testID = id;
        }
    }
}
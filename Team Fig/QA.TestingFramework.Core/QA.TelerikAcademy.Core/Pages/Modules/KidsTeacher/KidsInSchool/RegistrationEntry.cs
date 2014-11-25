namespace QA.TelerikAcademy.Core.Pages.Modules.KidsTeacher.KidsInSchool
{
    public class RegistrationEntry
    {
        public RegistrationEntry(string username = "random.user", string email = "a4188689@trbvm.com",
            string parentFirstName="ИмеНаРодител", string parentLastName="ФамилияНаРодител",
            string parentEmail="roditel@yahoo.com", string parentMobilePhone="")
        {
            this.Username = username;
            this.Email = email;
            this.ParentFirstName = parentFirstName;
            this.ParentLastName = parentLastName;
            this.ParentEmail = parentEmail;
            this.ParentPhone = parentMobilePhone;
        }

        public string Username { get; set; }

        public string Email { get; set; }

        public string ParentFirstName { get; set; }

        public string ParentLastName { get; set; }

        public string ParentEmail { get; set; }

        public string ParentPhone { get; set; }
    }
}
namespace QA.TelerikAcademy.Core.Data
{
    public class User
    {
        private static User admin;
        private static User kidsAdmin;
        private static User teacher;
        private static User standard;

        public static User Get(UserRoles role)
        {
            if (role == UserRoles.Admin)
            {
                if (admin == null)
                {
                    admin = new User()
                    {
                        Email = "mlq@start.bg",
                        Username = "TestUser",
                        Password = "testtest"
                    };
                }

                return admin;
            }

            if (role == UserRoles.KidsAdmin)
            {
                if (kidsAdmin == null)
                {
                    kidsAdmin = new User()
                    {
                        Email = "demo12@demo.com",
                        Username = "demo12",
                        Password = "qwerty"
                    };
                }

                return kidsAdmin;
            }

            if (role == UserRoles.Teacher)
            {
                if (teacher == null)
                {
                    teacher = new User()
                    {
                        Email = "teacher@teacher.com",
                        Username = "teacher",
                        Password = "qwerty"
                    };
                }

                return teacher;
            }
            else
            {
                if (standard == null)
                {
                    standard = new User()
                    {
                        Email = "orduser@abv.bg",
                        Username = "OrdinaryUser",
                        Password = "qwerty"
                    };
                }

                return standard;
            }
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
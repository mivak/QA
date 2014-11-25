namespace QA.TelerikAcademy.Core.Data.Users
{
   public static class UserFactory
    {
        private static IUser admin;
        private static IUser kidsAdmin;
        private static IUser teacher;
        private static IUser standard;

        public static IUser GetUser(UserRoles role)
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
    }
}
using QA.TelerikAcademy.Core.Data.RandomDataProvider;
namespace QA.TelerikAcademy.Core.Pages.Modules.KidsAcademy.Contests
{
    public class UserContestEntry
    {
        public UserContestEntry(string username, string points, string isTaken)
        {
            this.Username = username;
            this.Points = points;
            this.IsTaken = isTaken;
        }

        public static UserContestEntry GetRandomEntry(string username="random.user",int minPointsValue=10, int maxPointsValue=150, string isTaken="True")
        {
            var userPoints = RandomStringProvider.GetRandomInt(minPointsValue, maxPointsValue);

            var userEntry = new UserContestEntry(username, userPoints, isTaken);

            return userEntry;
        }

        public string Username { get; set; }

        public string Points { get; set; }

        public string IsTaken { get; set; }
    }
}

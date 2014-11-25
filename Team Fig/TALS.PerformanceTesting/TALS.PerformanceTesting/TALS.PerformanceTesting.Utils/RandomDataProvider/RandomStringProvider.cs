namespace TALS.PerformanceTesting.Utils.RandomDataProvider
{
    using System;
    using System.Globalization;
    using System.Text;

    public static class RandomStringProvider
    {
        private static readonly string englishLetters = 
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private static readonly string bulgarianLetters =
            "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯабвгдежзийклмнопрстуфхцчшщъьюя";

        private static readonly Random random = new Random();

        private static readonly string dateFormat = "dd/MM/yyyy";

        private static readonly string dateTimeFormat = "dd/MM/yyyy hh:00:00";

        public static string GetRandomInt(int min, int max)
        {
            var randomInt = random.Next(min, max);

            return randomInt.ToString();
        }
        public static string GetRandomString(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(englishLetters[random.Next(englishLetters.Length)]);
            }

            return text.ToString();
        }

        public static string GetRandomBulgarianString(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(bulgarianLetters[random.Next(bulgarianLetters.Length)]);
            }

            return text.ToString();
        }

        public static string GetRandomDateAfter(string startDateString)
        {
            DateTime start = DateTime.ParseExact(startDateString,dateFormat,CultureInfo.InvariantCulture);
            var randomDate = start.AddDays(random.Next(1, 100));
            return randomDate.ToString(dateFormat, CultureInfo.InvariantCulture);
        }

        public static string GetRandomDateTime(string startDateString)
        {
            DateTime start = DateTime.ParseExact(startDateString, dateFormat, CultureInfo.InvariantCulture);
            var randomDate = start.AddDays(random.Next(1, 100));
            var randomDateTime = randomDate.AddHours(random.Next(1, 23));
            return randomDate.ToString(dateTimeFormat, CultureInfo.InvariantCulture);
        }

        public static string GetRandomEmail()
        {
            StringBuilder email = new StringBuilder();
            email.Append(GetRandomString(5));
            email.Append("@");
            email.Append(GetRandomString(4));
            email.Append(".");
            email.Append(GetRandomString(3));

            return email.ToString();
        }

        public static string GetRandomPhoneNumber()
        {
            string phoneNumber = "0888" +
                random.Next(100000, 999999).ToString();

            return phoneNumber;
        }
    }
}
namespace QA.TelerikAcademy.Core.Data.RandomDataProvider
{
    using System;
    using System.Globalization;
    using System.Text;

    public static class RandomStringProvider
    {
        private static readonly string latinLetters = 
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private static readonly string cyrillicLetters =
            "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯабвгдежзийклмнопрстуфхцчшщъьюя";

        private static readonly Random random = new Random();

        private static readonly string dateFormat = "dd/MM/yyyy";

        private static readonly string dateTimeFormat = "dd/MM/yyyy hh:mm:ss";

        public static readonly string DateTimeNow = DateTime.Now.ToString(dateTimeFormat, CultureInfo.InvariantCulture);

        public static string GetRandomInt(int min, int max)
        {
            return random.Next(min, max).ToString();
        }

        public static string GetRandomStringLatin(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(latinLetters[random.Next(latinLetters.Length)]);
            }

            return text.ToString();
        }

        public static string GetRandomStringCyrillic(int size)
        {
            StringBuilder text = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                text.Append(cyrillicLetters[random.Next(cyrillicLetters.Length)]);
            }

            return text.ToString();
        }

        public static string GetRandomDate(string from)
        {
            DateTime start = DateTime.Parse(from);
            var randomDate = start.AddDays(random.Next(1, 100));
            return randomDate.ToString(dateFormat, CultureInfo.InvariantCulture);
        }

        public static string GetRandomDateTime(string from)
        {
            DateTime start = DateTime.Parse(from);
            var randomDateTime = RandomDateTimeProvider.GetRandomDateTime(start);
            return randomDateTime.ToString(dateTimeFormat, CultureInfo.InvariantCulture);
        }

        public static string GetRandomDateTime(string from, string dateTimeFormatString)
        {
            DateTime start = DateTime.ParseExact(from, dateTimeFormatString, CultureInfo.InvariantCulture);
            var randomDate = start.AddDays(random.Next(1, 10));
            var randomDateTime = randomDate.AddHours(random.Next(1, 23));
            return randomDate.ToString(dateTimeFormat, CultureInfo.InvariantCulture);
        }

        public static string GetRandomEmail()
        {
            StringBuilder email = new StringBuilder();
            email.Append(GetRandomStringLatin(5));
            email.Append("@");
            email.Append(GetRandomStringLatin(4));
            email.Append(".");
            email.Append(GetRandomStringLatin(3));

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
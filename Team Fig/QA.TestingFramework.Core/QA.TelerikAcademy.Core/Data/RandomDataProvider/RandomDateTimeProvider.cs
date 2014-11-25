namespace QA.TelerikAcademy.Core.Data.RandomDataProvider
{
    using System;

    public static class RandomDateTimeProvider
    {
        private static readonly Random random = new Random();

        public static DateTime GetRandomDateTime(DateTime? min = null, DateTime? max = null)
        {
            min = min ?? new DateTime(1753, 01, 01);
            max = max ?? new DateTime(2020, 12, 31);

            var range = max.Value - min.Value;
            var randomUpperBound = (Int32)range.TotalSeconds;
            if (randomUpperBound <= 0)
            {
                randomUpperBound = random.Next(1, Int32.MaxValue);
            }

            var randTimeSpan = TimeSpan.FromSeconds((Int64)(randomUpperBound - random.Next(0, randomUpperBound)));
            return min.Value.Add(randTimeSpan);
        }
    }
}

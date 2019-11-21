using Bridge.Interfaces;
using System;

namespace Bridge.Services
{
    public class GermanyDataService : IDataService
    {
        public string GetCountry()
        {
            return "Germany";
        }

        public DateTime GetLocalTime()
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

            if (timeZoneInfo == null)
                throw new TimeZoneNotFoundException("Germany timezone was not found.");

            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, timeZoneInfo);
        }
    }
}

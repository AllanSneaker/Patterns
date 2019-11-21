using Bridge.Interfaces;
using System;

namespace Bridge.Services
{
    public class RussianDataService : IDataService
    {
        public string GetCountry()
        {
            return "Russia";
        }

        public DateTime GetLocalTime()
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");

            if (timeZone == null)
                throw new TimeZoneNotFoundException("Russian timezone was not found.");

            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, timeZone);
        }
    }
}

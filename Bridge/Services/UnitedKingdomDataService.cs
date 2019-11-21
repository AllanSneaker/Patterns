using Bridge.Interfaces;
using System;

namespace Bridge.Services
{
    public class UnitedKingdomDataService : IDataService
    {
        public string GetCountry()
        {
            return "United Kingdom";
        }

        public DateTime GetLocalTime()
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            //Russian Standard Time

            if (timeZone == null)
                throw new TimeZoneNotFoundException("United Kingdom timezone was not found.");

            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, timeZone);
        }
    }
}

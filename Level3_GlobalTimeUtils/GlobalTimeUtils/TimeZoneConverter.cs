namespace GlobalTimeUtils;

public class TimeZoneConverter
{
    /// <summary>
    /// Get the current time in different time zones.
    /// 1. London UTC+0
    /// 2. New York UTC-5
    /// 3. Taipei UTC+8
    /// 4. Tokyo UTC+9
    /// 5. Toronto UTC-4
    /// </summary>
    /// <returns>different time zones</returns>
    public static Dictionary<string, DateTime> GetDifferentTimeZones()
    {
        var timeZones = new List<string>
        {
            "Europe/London", // London
            "America/New_York", // New York
            "Asia/Taipei", // Taipei
            "Asia/Tokyo", // Tokyo
            "America/Toronto" // Toronto
        };

        var utcNow = DateTime.UtcNow;
        var localTimes = new Dictionary<string, DateTime>();

        foreach (var timeZone in timeZones)
        {
            var tzInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, tzInfo);
            localTimes.Add(tzInfo.Id, localTime);
        }

        return localTimes;
    }
}
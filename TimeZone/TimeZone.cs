using System;

public class TimeZone
{
    public DateTime ConvertToUtc(DateTime localTime, string timeZoneId)
    {
        var timeZoneInfo = System.TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return System.TimeZoneInfo.ConvertTimeToUtc(localTime, timeZoneInfo);
    }

    public DateTime ConvertFromUtc(DateTime utcTime, string timeZoneId)
    {
        var timeZoneInfo = System.TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return System.TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZoneInfo);
    }
}
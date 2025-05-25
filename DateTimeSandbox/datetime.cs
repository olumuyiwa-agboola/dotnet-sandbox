Console.WriteLine("DateTime.Now: " + DateTime.Now);
Console.WriteLine("DateTime.Now.Millisecond: " + DateTime.Now.Millisecond);

Console.WriteLine("DateTimeOffset.Now: " + DateTimeOffset.Now);
Console.WriteLine("DateTimeOffset.Now.ToUnixTimeMilliseconds(): " + DateTimeOffset.Now.ToUnixTimeMilliseconds());

// Console.WriteLine("DateTimeOffset.FromUnixTimeMilliseconds(1748160959515): " + DateTimeOffset.FromUnixTimeMilliseconds(1748160959515));

string id = "Custom_UTC_Plus_0100";
TimeSpan offset = TimeSpan.FromHours(1);
TimeZoneInfo customTimeZone = TimeZoneInfo.CreateCustomTimeZone(id, offset, "", "");
// Console.WriteLine("TimeZoneInfo.ConvertTime(DateTimeOffset, TimeZoneInfo): " + TimeZoneInfo.ConvertTime(DateTimeOffset.FromUnixTimeMilliseconds(1748160959515), customTimeZone));
Console.WriteLine("TimeZoneInfo.ConvertTime(DateTimeOffset, TimeZoneInfo): " + TimeZoneInfo.ConvertTime(DateTimeOffset.FromUnixTimeMilliseconds(253402300799998), customTimeZone));

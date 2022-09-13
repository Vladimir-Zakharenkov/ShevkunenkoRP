using System;

// Define two dates.
DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);

// Calculate the interval between the two dates.
TimeSpan interval = date2 - date1;
Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());

// Display individual properties of the resulting TimeSpan object.
Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
Console.WriteLine("   {0,-35} {1,20}", "Value of Hours Component:", interval.Hours);
Console.WriteLine("   {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
Console.WriteLine("   {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
Console.WriteLine("   {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
Console.WriteLine("   {0,-35} {1,20:N0}", "TimeSpan.MinValue:", TimeSpan.MinValue.ToString());
Console.WriteLine("   {0,-35} {1,20:N0}", "TimeSpan.MixValue:", TimeSpan.MaxValue.ToString());


// This example displays the following output:
//       8/18/2010 1:30:30 PM - 1/1/2010 8:00:15 AM = 229.05:30:15
//          Value of Days Component:                             229
//          Total Number of Days:                   229.229340277778
//          Value of Hours Component:                              5
//          Total Number of Hours:                  5501.50416666667
//          Value of Minutes Component:                           30
//          Total Number of Minutes:                       330090.25
//          Value of Seconds Component:                           15
//          Total Number of Seconds:                      19,805,415
//          Value of Milliseconds Component:                       0
//          Total Number of Milliseconds:             19,805,415,000
//          Ticks:                               198,054,150,000,000

Console.WriteLine();

TimeSpan interval2 = new TimeSpan();
Console.WriteLine(interval2.Equals(TimeSpan.Zero));    // Displays "True".

Console.WriteLine();

TimeSpan interval3 = new TimeSpan(2, 14, 18);
Console.WriteLine(interval3.ToString());

Console.WriteLine();

DateTime departure = new DateTime(2010, 6, 12, 18, 32, 0);
DateTime arrival = new DateTime(2010, 6, 13, 22, 47, 0);
TimeSpan travelTime = arrival - departure;
Console.WriteLine("{0} - {1} = {2}", arrival, departure, travelTime);

// The example displays the following output:
//       6/13/2010 10:47:00 PM - 6/12/2010 6:32:00 PM = 1.04:15:00

Console.WriteLine();

Random rnd = new Random();

TimeSpan timeSpent = TimeSpan.Zero;

timeSpent += GetTimeBeforeLunch();
timeSpent += GetTimeAfterLunch();

Console.WriteLine("Total time: {0}", timeSpent);

TimeSpan GetTimeBeforeLunch()
{ 
    return new TimeSpan(rnd.Next(3, 6), 0, 0);
}

TimeSpan GetTimeAfterLunch()
{
    return new TimeSpan(rnd.Next(3, 6), 0, 0);
}

// The example displays output like the following:
//        Total time: 08:00:00

Console.WriteLine();

string[] values = { "12", "31.", "5.8:32:16", "12:12:15.95", ".12" };
foreach (string value in values)
{
    try
    {
        TimeSpan ts = TimeSpan.Parse(value);
        Console.WriteLine("'{0}' --> {1}", value, ts);
    }
    catch (FormatException)
    {
        Console.WriteLine("Unable to parse '{0}'", value);
    }
    catch (OverflowException)
    {
        Console.WriteLine("'{0}' is outside the range of a TimeSpan.", value);
    }
}

// The example displays the following output:
//       '12' --> 12.00:00:00
//       Unable to parse '31.'
//       '5.8:32:16' --> 5.08:32:16
//       '12:12:15.95' --> 12:12:15.9500000
//       Unable to parse '.12'

Console.WriteLine();

// Instantiating a TimeSpan Value

// By calling its implicit parameterless constructor.
// This creates an object whose value is TimeSpan.Zero, as the following example shows.

TimeSpan interval10 = new TimeSpan();
Console.WriteLine(interval10.Equals(TimeSpan.Zero));

// Displays "True".

//By calling one of its explicit constructors.
//The following example initializes a TimeSpan value to a specified
//number of hours, minutes, and seconds.

TimeSpan interval11 = new TimeSpan(2, 14, 18);
Console.WriteLine(interval11.ToString());

// Displays "02:14:18".

// By calling a method or performing an operation that returns a TimeSpan value.
// For example, you can instantiate a TimeSpan value that represents the interval
// between two date and time values, as the following example shows.

DateTime departure12 = new DateTime(2010, 6, 12, 18, 32, 0);
DateTime arrival12 = new DateTime(2010, 6, 13, 22, 47, 0);
TimeSpan travelTime12 = arrival12 - departure12;
Console.WriteLine("{0} - {1} = {2}", arrival12, departure12, travelTime12);

// The example displays the following output:
// 6/13/2010 10:47:00 PM - 6/12/2010 6:32:00 PM = 1.04:15:00

// You can also initialize a TimeSpan object to a zero time value in this way,
// as the following example shows.

Random rnd14 = new Random();

TimeSpan timeSpent14 = TimeSpan.Zero;

timeSpent14 += GetTimeBeforeLunch14();
timeSpent14 += GetTimeAfterLunch14();

Console.WriteLine("Total time: {0}", timeSpent14);

TimeSpan GetTimeBeforeLunch14()
{
    return new TimeSpan(rnd14.Next(3, 6), 0, 0);
}

TimeSpan GetTimeAfterLunch14()
{
    return new TimeSpan(rnd14.Next(3, 6), 0, 0);
}

// The example displays output like the following:
// Total time: 08:00:00

// TimeSpan values are returned by arithmetic operators and methods of the DateTime,
// DateTimeOffset, and TimeSpan structures.

// By parsing the string representation of a TimeSpan value.
// You can use the Parse and TryParse methods to convert strings that contain time intervals
// to TimeSpan values. The following example uses the Parse method to convert
// an array of strings to TimeSpan values.

string[] values15 = { "12", "31.", "5.8:32:16", "12:12:15.95", ".12" };
foreach (string value in values15)
{
    try
    {
        TimeSpan ts = TimeSpan.Parse(value);
        Console.WriteLine("'{0}' --> {1}", value, ts);
    }
    catch (FormatException)
    {
        Console.WriteLine("Unable to parse '{0}'", value);
    }
    catch (OverflowException)
    {
        Console.WriteLine("'{0}' is outside the range of a TimeSpan.", value);
    }
}

// The example displays the following output:
//       '12' --> 12.00:00:00
//       Unable to parse '31.'
//       '5.8:32:16' --> 5.08:32:16
//       '12:12:15.95' --> 12:12:15.9500000
//       Unable to parse '.12'

// In addition, you can define the precise format of the input string
// to be parsed and converted to a TimeSpan value by calling the ParseExact
// or TryParseExact method.

// Performing Operations on TimeSpan Values

// You can add and subtract time durations either by using the Addition and Subtraction operators,
// or by calling the Add and Subtract methods. You can also compare two time durations by calling
// the Compare, CompareTo, and Equals methods. The TimeSpan structure also includes the Duration
// and Negate methods, which convert time intervals to positive and negative values,

// The range of TimeSpan values is MinValue to MaxValue.

// Formatting a TimeSpan Value

// A TimeSpan value can be represented as [-] d.hh:mm: ss.ff, where the optional minus sign
// indicates a negative time interval, the d component is days, hh is hours as measured
// on a 24-hour clock, mm is minutes, ss is seconds, and ff is fractions of a second.
// That is, a time interval consists of a positive or negative number of days
// without a time of day, or a number of days with a time of day, or only a time of day.

// Beginning with the .NET Framework 4, the TimeSpan structure supports culture-sensitive
// formatting through the overloads of its ToString method, which converts a TimeSpan value
// to its string representation. The default TimeSpan.ToString() method returns a time interval
// by using an invariant format that is identical to its return value in previous versions
// of the .NET Framework. The TimeSpan.ToString(String) overload lets you specify
// a format string that defines the string representation of the time interval.
// The TimeSpan.ToString(String, IFormatProvider) overload lets you specify a format string
// and the culture whose formatting conventions are used to create the string representation
// of the time interval. TimeSpan supports both standard and custom format strings.
// (For more information, see Standard TimeSpan Format Strings and Custom TimeSpan Format Strings.)
// However, only standard format strings are culture-sensitive.

// Restoring Legacy TimeSpan Formatting

// In some cases, code that successfully formats TimeSpan values in .NET Framework 3.5
// and earlier versions fails in .NET Framework 4. This is most common in code
// that calls a <TimeSpan_LegacyFormatMode> element method to format a TimeSpan value
// with a format string. The following example successfully formats a TimeSpan value
// in .NET Framework 3.5 and earlier versions, but throws an exception in .NET Framework 4
// and later versions. Note that it attempts to format a TimeSpan value by using an
// unsupported format specifier, which is ignored in .NET Framework 3.5 and earlier versions.


Console.WriteLine();

ShowFormattingCode();
// Output from .NET Framework 3.5 and earlier versions:
//       12:30:45
// Output from .NET Framework 4:
//       Invalid Format    

Console.WriteLine("---");

ShowParsingCode();
// Output:
//       000000006 --> 6.00:00:00

void ShowFormattingCode()
{
    TimeSpan interval16 = new TimeSpan(12, 30, 45);
    string output;
    try
    {
        output = String.Format("{0:r}", interval16);
    }
    catch (FormatException)
    {
        output = "Invalid Format";
    }
    Console.WriteLine(output);
}

void ShowParsingCode()
{
    string value = "000000006";
    try
    {
        TimeSpan interval17 = TimeSpan.Parse(value);
        Console.WriteLine("{0} --> {1}", value, interval17);
    }
    catch (FormatException)
    {
        Console.WriteLine("{0}: Bad Format", value);
    }
    catch (OverflowException)
    {
        Console.WriteLine("{0}: Overflow", value);
    }
}

// If you cannot modify the code, you can restore the legacy formatting of TimeSpan values
// in one of the following ways:

// By creating a configuration file that contains the <TimeSpan_LegacyFormatMode> element.
// Setting this element's enabled attribute to true restores legacy TimeSpan formatting
// on a per-application basis.

// By setting the "NetFx40_TimeSpanLegacyFormatMode" compatibility switch when you create
// an application domain. This enables legacy TimeSpan formatting on a per-application-domain
// basis. The following example creates an application domain that uses
// legacy TimeSpan formatting.

//using System;

//public class Example
//{
//    public static void Main()
//    {
//        AppDomainSetup appSetup = new AppDomainSetup();
//        appSetup.SetCompatibilitySwitches(new string[] { "NetFx40_TimeSpanLegacyFormatMode" });
//        AppDomain legacyDomain = AppDomain.CreateDomain("legacyDomain",
//                                                        null, appSetup);
//        legacyDomain.ExecuteAssembly("ShowTimeSpan.exe");
//    }
//}

// When the following code executes in the new application domain,
// it reverts to legacy TimeSpan formatting behavior.

//using System;

//public class Example
//{
//    public static void Main()
//    {
//        TimeSpan interval = DateTime.Now - DateTime.Now.Date;
//        string msg = String.Format("Elapsed Time Today: {0:d} hours.",
//                                   interval);
//        Console.WriteLine(msg);
//    }
//}

//  Elapsed Time Today: 01:40:52.2524662 hours.
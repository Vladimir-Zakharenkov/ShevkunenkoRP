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
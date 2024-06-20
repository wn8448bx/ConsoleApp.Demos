namespace ConsoleApp.DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* DateTime manipulation *******");

            //Empty DateTime object
            DateTime dateTime = new DateTime();

            //Create a DateTime from date and time
            var dateOfBirth = new DateTime(1980, 12, 31);
            Console.WriteLine($"My DOB is: {dateOfBirth} ");

            var exactDateAndTimeOfBirth = new DateTime(1980, 12, 31, 02, 45, 00, DateTimeKind.Local);
            Console.WriteLine($"My DOB is: {exactDateAndTimeOfBirth}");

            Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
            Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
            Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
            Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
            Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

            //Create a DateTime from current timestamp
            DateTime now = DateTime.Now;
            //Console.WriteLine("The time now is: " + now);

            ////Create a DateTime from a String
            //Console.WriteLine("What is your DOB (dd/MM/yyyy: ");
            //string dob = Console.ReadLine();
            
            //var userDob = DateTime.Parse( dob );
            //Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
            //Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
            //Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
            //Console.WriteLine($"Tick: {userDob.Ticks}");
            //Console.WriteLine($"Kind: {userDob.Kind}");

            ////Change Format DateTime
            //Console.WriteLine($"Formatted Date: {userDob.ToString("dddd/MMMM/yyyy")}");
            //Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
            //Console.WriteLine($"Formatted Date: {userDob.ToString("MMMM dd, yyyy")}");

            ////Add Additional Time
            //Console.WriteLine("One hour from now is: " + now.AddHours(1));
            //Console.WriteLine("One day from now is: " + now.AddDays(1));
            //Console.WriteLine("One day from now is: " + now.AddDays(-1));

            Console.WriteLine("******* DateTime Offset manipulation *******");
            //UTC - Coordinated Universal Time
            var utcNow = DateTime.UtcNow;
            Console.WriteLine($"Now Date Time: {now}");
            Console.WriteLine($"UTC Now Date Time: {utcNow}");

            //DateTimeOffSet and TimeZone Info
            var tz = TimeZoneInfo.Local.GetUtcOffset( utcNow );
            Console.WriteLine($"User Time Zone: {tz}");

            var dto = new DateTimeOffset(now, tz);
            Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
            Console.WriteLine($"Utc Time of Action: {dto.UtcDateTime}");

            var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
            Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

            Console.WriteLine("******* Date Only and Time Only manipulation *******");

            //DateOnly
            //var dateOnly = new DateOnly(1980, 12, 20);
            //var nextDay = dateOnly.AddDays(1);
            //var previousDay = dateOnly.AddDays(-1);
            //var decadeLater = dateOnly.AddYears(10);
            //var lastMonth = dateOnly.AddMonths(-1);

            //Console.WriteLine($"The Date: {dateOnly}");
            //Console.WriteLine($"The Next day: {nextDay}");
            //Console.WriteLine($"The Previous day: {previousDay}");
            //Console.WriteLine($"A Decade later: {decadeLater}");
            //Console.WriteLine($"Last month: {lastMonth}");

            //var dateOnlyFromDateTime = DateOnly.FromDateTime(now);
            //Console.WriteLine($"Date only from DateTime: {dateOnlyFromDateTime}");

            //Console.WriteLine("What is your DOB (dd MMM yyyy): ");
            //string dobDateOnly = Console.ReadLine();

            //var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy");
            //Console.WriteLine($"The Date Only: {theDateOnly}");

            //TimeOnly
            var timeNow = TimeOnly.FromDateTime(now);
            Console.WriteLine("The time is: " +  timeNow);

            //Date Comparisons

            var date1 = new DateTime(1985, 11, 23);
            var date2 = new DateTime(1965, 1, 20);

            Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
            Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
            Console.WriteLine($"Is {date2} after? {date2 > date1}");
            Console.WriteLine($"Is {date2} before? {date2 < date1}");

        }
    }
}
var h = int.Parse(Console.ReadLine());
var day = Console.ReadLine();

var isOpen = IsOfficeOpen(h, day);

if (isOpen)
{
    Console.WriteLine("open");
}

else
{
    Console.WriteLine("closed");
}

static bool IsOfficeOpen(int hour, string dayOfWeek)
{
    bool isWeekend = (dayOfWeek == "Sunday");
    bool isWorkingHour = (hour >= 10 && hour <= 18);

    if (!isWeekend && isWorkingHour)
    {
        return true;
    }

    return false;
}
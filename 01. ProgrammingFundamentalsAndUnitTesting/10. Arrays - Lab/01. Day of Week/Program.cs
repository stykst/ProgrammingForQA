string[] days =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

var day = int.Parse(Console.ReadLine());

var output = day > 0 && 8 > day ? days[day - 1] : "Invalid day!";

Console.WriteLine(output);
var grade = double.Parse(Console.ReadLine());

Console.WriteLine(GetSignOfIntegerNumber(grade));

static string GetSignOfIntegerNumber(double g)
{
    if (g < 3) return "Fail";
    else if (g < 3.5) return "Average";
    else if (g < 4.5) return "Good";
    else if (g < 5.5) return "Very good";
    else return "Excellent";
}
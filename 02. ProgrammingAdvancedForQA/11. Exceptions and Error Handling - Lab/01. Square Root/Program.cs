var number = int.Parse(Console.ReadLine()); 

try
{
    if (number < 0)
    {
        throw new FormatException();
    }

    Console.WriteLine(Math.Sqrt(number));
}

catch (FormatException)
{
    Console.WriteLine($"Invalid number.");
}

finally
{
    Console.WriteLine("Goodbye.");
}
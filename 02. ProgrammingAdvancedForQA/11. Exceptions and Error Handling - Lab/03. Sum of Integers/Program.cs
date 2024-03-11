var input = Console.ReadLine().Split();
var sum = 0;

foreach (var item in input)
{
    try
    {
        var number = int.Parse(item);
        sum += number;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{item}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{item}' is out of range!");
    }

    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
}

Console.WriteLine($"The total sum of all integers is: {sum}");
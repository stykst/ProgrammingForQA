while (true)
{
    var input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    var num = int.Parse(input);

    var sum = 0;

    while (num > 0)
    {
        var digit = num % 10;
        sum += digit;
        num /= 10;
    }

    Console.WriteLine($"Sum of digits = {sum}");
}

Console.WriteLine("Goodbye");
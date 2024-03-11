var input = Console.ReadLine();

var balance = 0.0;

while (input != "End")
{
    balance += double.Parse(input);

    if (double.Parse(input) < 0) Console.WriteLine($"Decrease: {Math.Abs(double.Parse(input)):F2}");
    else Console.WriteLine($"Increase: {double.Parse(input):F2}");

    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {balance:F2}");
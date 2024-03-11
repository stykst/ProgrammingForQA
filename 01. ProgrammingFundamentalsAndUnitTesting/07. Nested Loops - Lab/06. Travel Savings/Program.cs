while (true)
{
    var destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    var neededBudget = double.Parse(Console.ReadLine());

    var collectedMoney = 0.0;

    while (collectedMoney < neededBudget)
    {
        var collectedAmount = double.Parse(Console.ReadLine());

        collectedMoney += collectedAmount;

        Console.WriteLine($"Collected: {collectedMoney:F2}");
    }

    Console.WriteLine($"Going to {destination}!");
}
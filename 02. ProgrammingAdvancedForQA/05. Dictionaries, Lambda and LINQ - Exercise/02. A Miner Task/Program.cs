var resources = new Dictionary<string, long>();

while (true)
{
    var input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }

    var quantity = long.Parse(Console.ReadLine());

    if (!resources.ContainsKey(input))
    {
        resources[input] = 0;
    }

    resources[input] += quantity;
}

foreach (var kvp in resources)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}
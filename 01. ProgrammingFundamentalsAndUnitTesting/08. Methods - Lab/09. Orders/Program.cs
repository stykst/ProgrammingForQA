var product = Console.ReadLine();
var quantity = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateTotalPrice(product, quantity));
static string CalculateTotalPrice(string product, int quantity)
{
    double price = 0.0;

    switch (product)
    {
        case "coffee": price = 1.50; break;
        case "water": price = 1.00; break;
        case "coke": price = 1.40; break;
        case "snacks": price = 2.00; break;
    }

    return $"{price * quantity:F2}";
}
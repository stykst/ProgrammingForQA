var n = int.Parse(Console.ReadLine());
var products = new List<string>();

for (int i = 0; i < n; i++)
{
    products.Add(Console.ReadLine());
}

products.Sort();
var position = 1;

foreach (var product in products)
{
    Console.WriteLine($"{position}.{product}");
    position++;
}
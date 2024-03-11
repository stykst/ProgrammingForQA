class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new Dictionary<string, Product>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "buy")
            {
                break;
            }

            var productInfo = input.Split(' ');
            var productName = productInfo[0];
            var price = double.Parse(productInfo[1]);
            var quantity = int.Parse(productInfo[2]);

            if (!products.ContainsKey(productName))
            {
                Product newProduct = new Product
                {
                    Name = productName,
                    Price = price,
                    Quantity = quantity
                };
                products[productName] = newProduct;
            }
            else
            {
                products[productName].Quantity += quantity;
                if (products[productName].Price != price)
                {
                    products[productName].Price = price;
                }
            }
        }

        foreach (var kvp in products)
        {
            var totalPrice = kvp.Value.Price * kvp.Value.Quantity;
            Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
        }
    }
}
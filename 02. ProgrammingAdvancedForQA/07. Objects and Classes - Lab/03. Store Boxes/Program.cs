using System.Globalization;
using System.Text;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal BoxPrice => ItemQuantity * Item.Price;

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(SerialNumber);
        sb.AppendLine($"-- {Item.Name} - ${Item.Price.ToString("0.00", CultureInfo.InvariantCulture)}: {ItemQuantity}");
        sb.AppendLine($"-- ${BoxPrice.ToString("0.00", CultureInfo.InvariantCulture)}");

        return sb.ToString().TrimEnd();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var boxes = new List<Box>();
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var data = input.Split();
            var serialNumber = data[0];
            var itemName = data[1];
            var itemQuantity = int.Parse(data[2]);
            var itemPrice = decimal.Parse(data[3]);

            var item = new Item { Name = itemName, Price = itemPrice };
            var box = new Box { SerialNumber = serialNumber, Item = item, ItemQuantity = itemQuantity };

            boxes.Add(box);
        }

        boxes.Sort((b1, b2) => b2.BoxPrice.CompareTo(b1.BoxPrice));

        foreach (var box in boxes)
        {
            Console.WriteLine(box);
        }
    }
}

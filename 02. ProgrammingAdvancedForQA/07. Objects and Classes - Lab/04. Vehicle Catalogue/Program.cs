class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalog
{
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public void AddVehicle(string input)
    {
        var data = input.Split('/');
        var type = data[0];
        var brand = data[1];
        var model = data[2];
        var value = int.Parse(data[3]);

        if (type == "Car")
        {
            Cars.Add(new Car { Brand = brand, Model = model, HorsePower = value });
        }
        else if (type == "Truck")
        {
            Trucks.Add(new Truck { Brand = brand, Model = model, Weight = value });
        }
    }

    public void PrintCatalog()
    {
        if (Cars.Any())
        {
            Console.WriteLine("Cars:");
            foreach (var car in Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }

        if (Trucks.Any())
        {
            Console.WriteLine("Trucks:");
            foreach (var truck in Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var catalog = new Catalog();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            catalog.AddVehicle(input);
        }

        catalog.PrintCatalog();
    }
}

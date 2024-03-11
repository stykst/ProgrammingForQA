namespace _04._Vehicle_Catalogue
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var vehicleData = input.Split();
                var type = vehicleData[0];
                var model = vehicleData[1];
                var color = vehicleData[2];
                var horsepower = int.Parse(vehicleData[3]);

                var vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsepower
                };

                vehicles.Add(vehicle);
            }

            var models = new List<string>();

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                models.Add(input);
            }

            foreach (var model in models)
            {
                var foundVehicle = vehicles.FirstOrDefault(v => v.Model == model);

                if (foundVehicle != null)
                {
                    Console.WriteLine($"Type: {Char.ToUpper(foundVehicle.Type[0]) + foundVehicle.Type.Substring(1)}");
                    Console.WriteLine($"Model: {foundVehicle.Model}");
                    Console.WriteLine($"Color: {foundVehicle.Color}");
                    Console.WriteLine($"Horsepower: {foundVehicle.Horsepower}");
                }
            }

            double carSumHorsepower = vehicles
                .Where(v => v.Type == "car")
                .Sum(v => v.Horsepower);
            var carCount = vehicles
                .Count(v => v.Type == "car");
            double truckSumHorsepower = vehicles
                .Where(v => v.Type == "truck")
                .Sum(v => v.Horsepower);
            var truckCount = vehicles
                .Count(v => v.Type == "truck");

            var averageCarHorsepower = carCount > 0 ? carSumHorsepower / carCount : 0;
            var averageTruckHorsepower = truckCount > 0 ? truckSumHorsepower / truckCount : 0;

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:f2}.");
        }
    }

}
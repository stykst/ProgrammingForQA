using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            var fuelNeeded = distance * FuelConsumption;

            if (fuelQuantity - fuelNeeded >= 0) fuelQuantity -= fuelNeeded;
            else Console.WriteLine("Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"Fuel: {fuelQuantity:F2}");

            return sb.ToString().TrimEnd();
        }
    }
}

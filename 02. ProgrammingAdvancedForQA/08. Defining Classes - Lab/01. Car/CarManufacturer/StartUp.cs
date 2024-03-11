using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            var sb = new StringBuilder();

            sb.AppendLine($"Make: {car.Make}");
            sb.AppendLine($"Model: {car.Model}");
            sb.AppendLine($"Year: {car.Year}");

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
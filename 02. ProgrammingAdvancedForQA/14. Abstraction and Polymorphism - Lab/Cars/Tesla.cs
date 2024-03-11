using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
        public int Battery { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Color} Tesla Model {Model} with {Battery} Batteries");
            sb.AppendLine("Engine start");
            sb.AppendLine("Break!");

            return sb.ToString().TrimEnd();
        }
    }
}

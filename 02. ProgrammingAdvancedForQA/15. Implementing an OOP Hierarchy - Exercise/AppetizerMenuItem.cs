namespace ExerciseOopHierarchy
{
    public class AppetizerMenuItem : MenuItem
    {
        public AppetizerMenuItem(string name, string description, decimal price)
            : base(name, description, price) 
        {
        }

        public override string ToString()
        {
            return $"Appetizer: {base.ToString()}";
        }
    }
}

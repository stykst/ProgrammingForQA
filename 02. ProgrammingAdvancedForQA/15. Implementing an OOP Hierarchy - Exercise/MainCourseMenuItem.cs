namespace ExerciseOopHierarchy
{
    public class MainCourseMenuItem : MenuItem
    {
        public MainCourseMenuItem(string name, string description, decimal price) 
            : base(name, description, price)
        { 
        }

        public override string ToString()
        {
            return $"Main Course: {base.ToString()}";
        }
    }
}

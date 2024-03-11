namespace _01._Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var firstName = input[0];
                var lastName = input[1];
                var grade = double.Parse(input[2]);

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);
            }

            var sortedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}
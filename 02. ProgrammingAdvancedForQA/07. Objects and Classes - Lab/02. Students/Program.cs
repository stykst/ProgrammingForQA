class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            var studentInfo = input.Split();
            var firstName = studentInfo[0];
            var lastName = studentInfo[1];
            var age = int.Parse(studentInfo[2]);
            var homeTown = studentInfo[3];

            students.Add(new Student(firstName, lastName, age, homeTown));
        }

        var city = Console.ReadLine();

        foreach (var student in students)
        {
            if (student.HomeTown == city)
            {
                Console.WriteLine(student);
            }
        }
    }
}

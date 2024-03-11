var n = int.Parse(Console.ReadLine());

var students = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    var name = Console.ReadLine();
    var grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name)) students[name] = new List<double>();

    students[name].Add(grade);
}

var filteredStudents = students
    .Where(s => s.Value.Average() >= 4.5)
    .ToDictionary(s => s.Key, s => s.Value);

foreach (var student in filteredStudents)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
}
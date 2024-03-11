var n = int.Parse(Console.ReadLine());

var totalGrade = 0.0;

for (int i = 0; i < n; i++)
{
    var grade = double.Parse(Console.ReadLine());
    totalGrade += grade;
}

var averageGrade = totalGrade / n;
Console.WriteLine($"{averageGrade:F2}");
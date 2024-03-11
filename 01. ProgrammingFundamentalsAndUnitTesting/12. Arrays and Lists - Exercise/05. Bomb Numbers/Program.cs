var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var specialNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (numbers.Contains(specialNumbers[0]))
{
    int bombIndex = numbers.IndexOf(specialNumbers[0]);
    int leftBound = Math.Max(bombIndex - specialNumbers[1], 0);
    int rightBound = Math.Min(bombIndex + specialNumbers[1], numbers.Count - 1);

    numbers.RemoveRange(leftBound, rightBound - leftBound + 1);
}

Console.WriteLine(numbers.Sum());
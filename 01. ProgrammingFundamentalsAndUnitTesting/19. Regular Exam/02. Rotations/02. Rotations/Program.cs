var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
var n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var lastNumber = numbers[numbers.Length - 1];

    for (int j = numbers.Length - 1; j > 0; j--)
    {
        numbers[j] = numbers[j - 1];
    }

    numbers[0] = lastNumber;
}

Console.WriteLine(string.Join(", ", numbers));
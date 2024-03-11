var n = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var numbers = new List<int>();

for (int i = 0; i < n.Count / 2; i++)
{
    int sum = n[0 + i] + n[n.Count - 1 - i];
    numbers.Add(sum);
}

if (n.Count % 2 != 0)
{
    var num = n[n.Count / 2];
    numbers.Add(num);
}

Console.WriteLine(string.Join(" ", numbers));
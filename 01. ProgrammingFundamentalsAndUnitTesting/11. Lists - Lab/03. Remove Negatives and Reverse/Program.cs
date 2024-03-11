var integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

integers.RemoveAll(x => x < 0);
integers.Reverse();

Console.WriteLine(integers.Any() ? string.Join(" ", integers) : "empty");
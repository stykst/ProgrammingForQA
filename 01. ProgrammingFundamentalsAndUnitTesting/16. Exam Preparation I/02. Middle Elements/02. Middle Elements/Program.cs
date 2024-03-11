var input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var numbers = new int[input.Length];

for (int i = 0; i < input.Length; i++)
{
    numbers[i] = input[i];
}

var middleStart = numbers.Length / 2 - 1;
var middleEnd = numbers.Length / 2;

var sum = 0.0;

for (int i = middleStart; i <= middleEnd; i++)
{
    sum += numbers[i];
}

var average = sum / (middleEnd - middleStart + 1);

Console.WriteLine(average.ToString("F2"));
var numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var n = int.Parse(Console.ReadLine());

var max = int.MinValue;
var min = int.MaxValue;

for (int i = 0; i < n; i++)
{
    if (numbers[i] > max) max = numbers[i];
    if (numbers[i] < min) min = numbers[i];
}

Console.WriteLine(max);
Console.WriteLine(min);
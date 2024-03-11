var input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
var n = int.Parse(Console.ReadLine());

var average = CalculateAverageOfLastNElements(input, n);

Console.WriteLine($"{average:F2}");

static double CalculateAverageOfLastNElements(int[] numbers, int n)
{
    var sum = 0.0;
    var count = 0;

    for (int i = numbers.Length - n; i < numbers.Length; i++)
    {
        sum += numbers[i];
        count++;
    }

    return sum / count;
}
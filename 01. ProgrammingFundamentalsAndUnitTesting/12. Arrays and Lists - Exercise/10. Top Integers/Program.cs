var numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

var topIntegers = FindTopIntegers(numbers);

Console.WriteLine(string.Join(" ", topIntegers));

static List<int> FindTopIntegers(int[] numbers)
{
    var topIntegers = new List<int>();
    var maxRight = int.MinValue;

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        if (numbers[i] > maxRight)
        {
            topIntegers.Add(numbers[i]);
            maxRight = numbers[i];
        }
    }

    topIntegers.Reverse();

    return topIntegers;
}
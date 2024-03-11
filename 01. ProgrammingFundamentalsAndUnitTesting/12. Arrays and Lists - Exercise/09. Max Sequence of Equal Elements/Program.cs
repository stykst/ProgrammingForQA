var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var longestSequence = FindLongestEqualSequence(numbers);

Console.WriteLine(string.Join(" ", longestSequence));

static int[] FindLongestEqualSequence(int[] numbers)
{
    var maxLength = 0;
    var currentLength = 1;
    var longestStartIndex = 0;
    var currentStartIndex = 0;

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] == numbers[i - 1])
        {
            currentLength++;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                longestStartIndex = currentStartIndex;
            }
        }

        else
        {
            currentLength = 1;
            currentStartIndex = i;
        }
    }

    var longestSequence = new int[maxLength];
    Array.Copy(numbers, longestStartIndex, longestSequence, 0, maxLength);

    return longestSequence;
}
var n = int.Parse(Console.ReadLine());

var firstArray = new int[n];
var secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    var numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    var numOne = numbers[0];
    var numTwo = numbers[1];

    if (i % 2 == 0)
    {
        firstArray[i] = numOne;
        secondArray[i] = numTwo;
    }

    else
    {
        firstArray[i] = numTwo;
        secondArray[i] = numOne;
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));
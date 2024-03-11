var n = int.Parse(Console.ReadLine());

PrintDigitsInWords(n);

static void PrintDigitsInWords(int number)
{
    while (number > 0)
    {
        var digit = number % 10;
        var digitWord = GetDigitWord(digit);
        Console.WriteLine(digitWord);
        number /= 10;
    }
}

static string GetDigitWord(int digit)
{
    switch (digit)
    {
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "zero";
    }
}
var number = int.Parse(Console.ReadLine());

Console.WriteLine(GetMultipleOfEvenAndOdds(number));
static int GetMultipleOfEvenAndOdds(int n)
{
    n = Math.Abs(n);

    int sumOfEvenDigits = GetSumOfEvenDigits(n);
    int sumOfOddDigits = GetSumOfOddDigits(n);

    return sumOfEvenDigits * sumOfOddDigits;
}

static int GetSumOfEvenDigits(int n)
{
    int sum = 0;

    while (n > 0)
    {
        int digit = n % 10;

        if (digit % 2 == 0)
        {
            sum += digit;
        }

        n /= 10;
    }

    return sum;
}

static int GetSumOfOddDigits(int n)
{
    int sum = 0;

    while (n > 0)
    {
        int digit = n % 10;

        if (digit % 2 != 0)
        {
            sum += digit;
        }

        n /= 10;
    }

    return sum;
}
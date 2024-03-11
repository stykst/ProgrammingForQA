var start = int.Parse(Console.ReadLine());
var end = int.Parse(Console.ReadLine());

PrintPrimeNumbersInRange(start, end);

static bool IsPrime(int number)
{
    for (int divisor = 2; divisor * divisor <= number; divisor++)
    {
        if (number % divisor == 0)
        {
            return false;
        }
    }

    return true;
}

static void PrintPrimeNumbersInRange(int start, int end)
{
    for (int num = start; num <= end; num++)
    {
        if (IsPrime(num))
        {
            Console.Write(num + " ");
        }
    }
}
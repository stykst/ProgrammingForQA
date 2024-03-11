var number = int.Parse(Console.ReadLine());

var sumOfFactorials = 0;

while (number > 0)
{
    var digit = number % 10;

    if (digit % 2 == 0)
    {
        sumOfFactorials += CalculateFactorial(digit);
    }

    number /= 10;
}

Console.WriteLine(sumOfFactorials);

static int CalculateFactorial(int n)
{
    if (n <= 1) return 1;
    else return n * CalculateFactorial(n - 1);
}
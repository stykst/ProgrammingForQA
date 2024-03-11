var n = int.Parse(Console.ReadLine());

var foundMagicNumber = false;

for (int i = 1; i <= n; i++)
{
    if (IsMagicNumber(i))
    {
        Console.Write(i + " ");
        foundMagicNumber = true;
    }
}

if (!foundMagicNumber) Console.WriteLine("no");

static bool IsPrime(int n)
{
    if (n <= 1) return false;
    if (n <= 3) return true;
    if (n % 2 == 0 || n % 3 == 0) return false;

    return true;
}

static bool IsMagicNumber(int number)
{
    var sumOfDigits = 0;

    while (number > 0)
    {
        var digit = number % 10;

        if (!IsPrime(digit))  return false;

        sumOfDigits += digit;
        number /= 10;
    }

    return sumOfDigits % 2 == 0;
}
var input = Console.ReadLine();

if (int.TryParse(input, out int number) && number >= 0)
{
    int digitSum = SumDigitsWithArray(number);
    Console.WriteLine(digitSum);
}

static int SumDigitsWithArray(int number)
{
    char[] digits = number.ToString().ToCharArray();
    var sum = 0;

    foreach (char digit in digits)
    {
        if (char.IsDigit(digit))
        {
            var d = int.Parse(digit.ToString());
            sum += d;
        }
    }

    return sum;
}
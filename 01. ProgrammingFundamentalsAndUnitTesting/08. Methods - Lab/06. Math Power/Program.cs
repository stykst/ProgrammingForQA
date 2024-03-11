var number = int.Parse(Console.ReadLine());
var power = int.Parse(Console.ReadLine());

Console.WriteLine(CalculatePower(number, power));
static int CalculatePower(int num, int pow)
{
    int result = 1;

    for (int i = 1; i <= pow; i++)
    {
        result *= num;
    }

    return result;
}
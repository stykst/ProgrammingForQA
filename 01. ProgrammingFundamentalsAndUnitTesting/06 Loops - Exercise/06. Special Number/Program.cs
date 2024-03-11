var n = int.Parse(Console.ReadLine());

var output = "is special";
var num = n;

while (n > 0)
{
    int digit = n % 10;

    if (num % digit != 0)
    {
        output = "is not special";
        break;
    }

    n /= 10;
}

Console.WriteLine(num + " " + output);
var a = char.Parse(Console.ReadLine());
var b = char.Parse(Console.ReadLine());
var c = char.Parse(Console.ReadLine());

var count = 0;

for (char i = a; i <= b; i++)
{
    for (char j = a; j <= b; j++)
    {
        for (char k = a; k <= b; k++)
        {
            if (i != c && j != c && k != c)
            {
                count++;
                Console.Write($"{i}{j}{k} ");
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine(count);
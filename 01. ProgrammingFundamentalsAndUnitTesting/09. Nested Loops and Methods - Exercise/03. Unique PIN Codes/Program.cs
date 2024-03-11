var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());

for (int i = 2; i <= a; i += 2)
{
    for (int j = 2; j <= b; j++)
    {
        for (int k = 2; k <= c; k += 2)
        {
            if (j == 2 || j == 3 || j == 5 || j == 7) Console.WriteLine($"{i}{j}{k}");
        }
    }
}
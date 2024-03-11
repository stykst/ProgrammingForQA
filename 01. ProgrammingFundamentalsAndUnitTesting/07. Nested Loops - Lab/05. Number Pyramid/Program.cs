var n = int.Parse(Console.ReadLine());

var m = 1;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (m > n)
        {
            break;
        }

        Console.Write(m + " ");

        m++;
    }

    Console.WriteLine();
}
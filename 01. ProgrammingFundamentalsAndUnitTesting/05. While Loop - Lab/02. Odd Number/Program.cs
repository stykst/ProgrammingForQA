var n = int.Parse(Console.ReadLine());

while (true)
{
    if (n % 2 != 0) break;
    n = int.Parse(Console.ReadLine());
}

Console.WriteLine(n);
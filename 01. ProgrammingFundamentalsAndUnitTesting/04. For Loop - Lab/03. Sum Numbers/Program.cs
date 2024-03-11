var n = int.Parse(Console.ReadLine());

var total = 0.0;

for (int i = 1; i <= n; i++)
{
    var m = double.Parse(Console.ReadLine());
    total += m;
}

Console.WriteLine(total);
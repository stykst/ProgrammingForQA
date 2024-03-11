var n = int.Parse(Console.ReadLine());

var biggest = int.MinValue;

for (int i = 0; i < n; i++)
{
    var m = int.Parse(Console.ReadLine());
    if (m > biggest) biggest = m;
}

Console.WriteLine(biggest);
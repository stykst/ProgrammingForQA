var n = int.Parse(Console.ReadLine());

var divBy2 = 0.0;
var divBy3 = 0.0;
var divBy4 = 0.0;

for (int i = 0; i < n; i++)
{
    var num = int.Parse(Console.ReadLine());

    if (num % 2 == 0) divBy2++;
    if (num % 3 == 0) divBy3++;
    if (num % 4 == 0) divBy4++;
}

var perDivBy2 = divBy2 / n * 100;
var perDivBy3 = divBy3 / n * 100;
var perDivBy4 = divBy4 / n * 100;

Console.WriteLine($"{perDivBy2:F2}%");
Console.WriteLine($"{perDivBy3:F2}%");
Console.WriteLine($"{perDivBy4:F2}%");
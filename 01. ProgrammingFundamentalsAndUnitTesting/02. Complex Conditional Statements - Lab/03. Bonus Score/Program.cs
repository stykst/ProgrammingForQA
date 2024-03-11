var points = int.Parse(Console.ReadLine());

var bonus = points;

if (points < 4)
{
    bonus += 5;
}

else if (points < 7)
{
    bonus += 15;
}

else if (points < 10)
{
    bonus += 20;
}

Console.WriteLine(bonus);
var n = int.Parse(Console.ReadLine());

var result = 0;

for (int i = 0; i < n; i++)
{
    var m = Console.ReadLine();

    switch (m)
    {
        case "a": result += 1; break;
        case "e": result += 2; break;
        case "i": result += 3; break;
        case "o": result += 4; break;
        case "u": result += 5; break;

        default: break;
    }
}

Console.WriteLine(result);
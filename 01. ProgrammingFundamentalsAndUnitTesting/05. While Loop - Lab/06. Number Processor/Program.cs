var n = int.Parse(Console.ReadLine());

while (true)
{
    var command = Console.ReadLine();
    if (command == "End") break;
    n = command == "Inc" ? ++n : --n;
}

Console.WriteLine(n);
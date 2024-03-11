var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
var command = Console.ReadLine();

while(command != "end")
{
    var tokens = command.Split();
    
    if (tokens[0] == "Delete")
    {
        var element = int.Parse(tokens[1]);
        numbers.RemoveAll(n => n == element);
    }

    else
    {
        var element = int.Parse(tokens[1]);
        var position = int.Parse(tokens[2]);

        numbers.Insert(position, element);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
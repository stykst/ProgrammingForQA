List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    string[] tokens = command.Split(' ');
    var number = 0;
    var index = 0;

    switch (tokens[0])
    {
        case "Add":
            number = int.Parse(tokens[1]);
            numbers.Add(number);
            break;

        case "Remove":
            number = int.Parse(tokens[1]);
            numbers.Remove(number);
            break;

        case "RemoveAt":
            number = int.Parse(tokens[1]);
            numbers.RemoveAt(number);
            break;

        case "Insert":
            number = int.Parse(tokens[1]);
            index = int.Parse(tokens[2]);
            numbers.Insert(index, number);
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));
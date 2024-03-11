var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

while (true)
{
    var command = Console.ReadLine();

    if (command == "end") break;

    var tokens = command.Split();

    switch (tokens[0])
    {
        case "Contains":
            var number = int.Parse(tokens[1]);
            Console.WriteLine(numbers.Contains(number) ? "Yes" : "No such number");
            break;

        case "PrintEven":
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
            break;

        case "PrintOdd":
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
            break;

        case "GetSum":
            Console.WriteLine(numbers.Sum());
            break;

        case "Filter":
            var condition = tokens[1];
            number = int.Parse(tokens[2]);

            switch (condition)
            {
                case "<": numbers.RemoveAll(n => n >= number); break;
                case ">": numbers.RemoveAll(n => n <= number); break;
                case "<=": numbers.RemoveAll(n => n > number); break;
                case ">=": numbers.RemoveAll(n => n < number); break;
            }

            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));
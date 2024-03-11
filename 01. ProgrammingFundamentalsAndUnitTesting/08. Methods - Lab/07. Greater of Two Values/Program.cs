switch (Console.ReadLine())
{
    case "int":
        Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        break;

    case "char":
        Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
        break;

    case "string":
        Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));
        break;
}
static T GetMax<T>(T value1, T value2) where T : IComparable<T>
{
    return value1.CompareTo(value2) > 0 ? value1 : value2;
}
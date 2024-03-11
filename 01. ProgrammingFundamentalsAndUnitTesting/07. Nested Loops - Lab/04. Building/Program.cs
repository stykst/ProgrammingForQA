var floorsCount = int.Parse(Console.ReadLine());
var estatesCountPerFloor = int.Parse(Console.ReadLine());

for (int floor = floorsCount; floor > 0; floor--)
{
    var type = floor % 2 == 1 ? 'A' : 'O';
    if (floor == floorsCount) type = 'L';

    for (int estate = 0; estate < estatesCountPerFloor; estate++)
    {
        Console.Write($"{type}{floor}{estate} ");
    }

    Console.WriteLine();
}
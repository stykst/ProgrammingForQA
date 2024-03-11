var n = int.Parse(Console.ReadLine());

var parkingLot = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    var command = Console.ReadLine().Split();

    if (command[0] == "register")
    {
        var username = command[1];
        var licensePlate = command[2];

        if (parkingLot.ContainsKey(username)) Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
        else
        {
            parkingLot[username] = licensePlate;
            Console.WriteLine($"{username} registered {licensePlate} successfully");
        }
    }
    else if (command[0] == "unregister")
    {
        var username = command[1];

        if (!parkingLot.ContainsKey(username)) Console.WriteLine($"ERROR: user {username} not found");
        else
        {
            Console.WriteLine($"{username} unregistered successfully");
            parkingLot.Remove(username);
        }
    }
}

foreach (var kvp in parkingLot)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}
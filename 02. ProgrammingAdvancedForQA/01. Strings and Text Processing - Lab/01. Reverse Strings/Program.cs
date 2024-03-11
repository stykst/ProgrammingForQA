var input = Console.ReadLine();

while (true)
{
	if (input == "end") break;

    var word = input.ToCharArray();
    Array.Reverse(word);

    Console.WriteLine($"{input} = {new string(word)}");

    input = Console.ReadLine();
}
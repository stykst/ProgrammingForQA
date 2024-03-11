var firstString = Console.ReadLine();
var secondString = Console.ReadLine();

while (secondString.Contains(firstString))
{
    secondString = secondString.Replace(firstString, string.Empty);
}

Console.WriteLine(secondString);
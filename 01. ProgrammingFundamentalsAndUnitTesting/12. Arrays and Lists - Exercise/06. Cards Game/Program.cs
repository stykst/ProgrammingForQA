var firstHand = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var secondHand = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (firstHand.Count > 0 && secondHand.Count > 0)
{
    var firstCard = firstHand[0];
    var secondCard = secondHand[0];

    if (firstCard > secondCard)
    {
        firstHand.Add(firstCard);
        firstHand.Add(secondCard);
    }
    else if (firstCard < secondCard)
    {
        secondHand.Add(secondCard);
        secondHand.Add(firstCard);
    }

    firstHand.RemoveAt(0);
    secondHand.RemoveAt(0);
}

if (firstHand.Count > secondHand.Count)
{
    Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
}
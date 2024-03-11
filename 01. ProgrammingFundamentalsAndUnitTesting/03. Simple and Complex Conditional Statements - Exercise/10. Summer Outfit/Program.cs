var temperature = int.Parse(Console.ReadLine());
var timeOfDay = Console.ReadLine();

var clothing = string.Empty;
var shoes = string.Empty;

if (temperature >= 10 && temperature <= 18)
{
    if (timeOfDay == "Morning")
    {
        clothing = "Sweatshirt";
        shoes = "Sneakers";
    }

    else
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}

else if (temperature > 18 && temperature <= 24)
{
    if (timeOfDay == "Afternoon")
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }

    else
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}

else if (temperature >= 25)
{
    if (timeOfDay == "Morning")
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }

    else if (timeOfDay == "Afternoon")
    {
        clothing = "Swim Suit";
        shoes = "Barefoot";
    }

    else
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
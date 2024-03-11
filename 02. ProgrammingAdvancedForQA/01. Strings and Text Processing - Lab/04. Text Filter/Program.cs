var textList = Console.ReadLine()
    .Split(", ")
    .ToArray();
var text = Console.ReadLine();

foreach (var txt in textList)
{    
    text = text.Replace(txt, new string ('*', txt.Length));
}

Console.WriteLine (text);
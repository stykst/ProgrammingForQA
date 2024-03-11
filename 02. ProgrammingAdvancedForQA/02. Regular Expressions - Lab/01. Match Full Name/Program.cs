using System.Text.RegularExpressions;

var inputText = Console.ReadLine();

var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
var matches = Regex.Matches(inputText, pattern);

foreach (Match match in matches)
{
    Console.Write(match.Value + " ");
}
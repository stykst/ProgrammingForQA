using System.Text.RegularExpressions;

var inputText = Console.ReadLine();

var pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
var matches = Regex.Matches(inputText, pattern);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["day"].Value}, " +
        $"Month: {match.Groups["month"].Value}, " +
        $"Year: {match.Groups["year"].Value}");
}
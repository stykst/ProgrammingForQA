using System.Text.RegularExpressions;

var inputText = Console.ReadLine();

var pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
var matches = Regex.Matches(inputText, pattern);

var validPhones = matches
    .Cast<Match>()
    .Select(a => a.Value.Trim())
    .ToArray();

Console.WriteLine(string.Join(", ", validPhones));
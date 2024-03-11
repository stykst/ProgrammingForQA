using System.Text;

var input = Console.ReadLine();

var digits = string.Empty;
var letters = string.Empty;
var otherChars = string.Empty;

foreach (char c in input)
{
    if (char.IsDigit(c))
    {
        digits += c;
    }

    else if (char.IsLetter(c))
    {
        letters += c;
    }

    else
    {
        otherChars += c;
    }
}

var sb = new StringBuilder();

sb.AppendLine(digits);
sb.AppendLine(letters);
sb.AppendLine(otherChars);

Console.WriteLine(sb.ToString());
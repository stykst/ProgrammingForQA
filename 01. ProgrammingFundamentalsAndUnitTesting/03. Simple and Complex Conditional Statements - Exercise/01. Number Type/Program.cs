var a = int.Parse(Console.ReadLine());

var output = string.Empty;

if (a < 0) output = "negative";
else if (a > 1) output = "positive";
else output = "zero";

Console.WriteLine(output);
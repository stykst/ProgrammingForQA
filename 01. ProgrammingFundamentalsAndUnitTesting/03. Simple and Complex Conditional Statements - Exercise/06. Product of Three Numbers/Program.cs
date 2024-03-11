var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());

var output = string.Empty;
var count = 0;

if (a < 0) count++;
if (b < 0) count++;
if (c < 0) count++;

if (a == 0 || b == 0 || c == 0) output = "zero";
else if (count % 2 == 0) output = "positive";
else output = "negative";

Console.WriteLine(output);
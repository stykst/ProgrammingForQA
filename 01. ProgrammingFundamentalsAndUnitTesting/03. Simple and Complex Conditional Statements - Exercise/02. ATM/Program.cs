var b = int.Parse(Console.ReadLine());
var w = int.Parse(Console.ReadLine());
var l = int.Parse(Console.ReadLine());

var output = string.Empty;

if (w <= b && w <= l) output = "The withdraw was successful.";
else if (w > l) output = "The limit was exceeded.";
else output = "Insufficient availability.";

Console.WriteLine(output);
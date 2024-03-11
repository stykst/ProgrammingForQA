var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());
var d = int.Parse(Console.ReadLine());
var e = int.Parse(Console.ReadLine());

var output = a;

if (b > output) output = b;
if (c > output) output = c;
if (d > output) output = d;
if (e > output) output = e;

Console.WriteLine(output);
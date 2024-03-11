var n = int.Parse(Console.ReadLine());

var output = (n < 100 || n > 200) && n != 0 ? "invalid" : null;

Console.WriteLine(output);
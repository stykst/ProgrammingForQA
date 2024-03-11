var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());

int total = a + b + c;

int minutes = total / 60;
int seconds = total % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");
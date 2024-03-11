var stop = int.Parse(Console.ReadLine());

var prev = 0;
var curr = 0;

while (true)
{
    curr = int.Parse(Console.ReadLine());

    if (curr == stop) break;
    prev = curr;
}

Console.WriteLine(prev * 1.2);
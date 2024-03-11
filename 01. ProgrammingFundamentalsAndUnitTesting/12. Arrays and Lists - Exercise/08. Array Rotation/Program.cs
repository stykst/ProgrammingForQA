var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse);
var queue = new Queue<int>(numbers);

var n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    queue.Enqueue(queue.Dequeue());
}

Console.WriteLine(string.Join(" ", queue));
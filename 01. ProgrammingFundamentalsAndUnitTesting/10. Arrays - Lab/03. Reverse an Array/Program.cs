var n = int.Parse(Console.ReadLine());

var arr = new int[n];

for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

Array.Reverse(arr);

foreach (int i in arr) Console.Write(i + " ");
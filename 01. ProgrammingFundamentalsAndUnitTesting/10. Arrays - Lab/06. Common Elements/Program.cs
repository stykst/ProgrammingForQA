var arr1 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

var arr2 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
.ToArray();

var commonElements = FindCommonElements(arr1, arr2);

Console.WriteLine(string.Join(" ", commonElements));

static int[] FindCommonElements(int[] arr1, int[] arr2)
{
    var commonElements = new List<int>();

    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr1[i] == arr2[j] && !commonElements.Contains(arr1[i]))
            {
                commonElements.Add(arr1[i]);
            }
        }
    }

    return commonElements.ToArray();
}
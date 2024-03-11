var arr1 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

var arr2 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

var output = AreArraysIdentical(arr1, arr2) ? "Arrays are identical." : "Arrays are not identical.";

Console.WriteLine(output);

static bool AreArraysIdentical(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }

    return true;
}
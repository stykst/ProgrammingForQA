var listOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
var listTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Console.WriteLine(string.Join(" ", GetMergingList(listOne, listTwo)));

static List<int> GetMergingList(List<int> sequence1, List<int> sequence2)
{
    var resultList = new List<int>();
    var minLength = Math.Min(sequence1.Count, sequence2.Count);

    for (int i = 0; i < minLength; i++)
    {
        resultList.Add(sequence1[i]);
        resultList.Add(sequence2[i]);
    }

    resultList.AddRange(sequence1.GetRange(minLength, sequence1.Count - minLength));
    resultList.AddRange(sequence2.GetRange(minLength, sequence2.Count - minLength));

    return resultList;
}
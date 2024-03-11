var companies = new Dictionary<string, HashSet<string>>();

while (true)
{
    var input = Console.ReadLine();
    if (input == "End")
    {
        break;
    }

    var tokens = input.Split(" -> ");
    var companyName = tokens[0];
    var employeeId = tokens[1];

    if (!companies.ContainsKey(companyName))
    {
        companies[companyName] = new HashSet<string>();
    }

    companies[companyName].Add(employeeId);
}

foreach (var company in companies)
{
    Console.WriteLine(company.Key);
    foreach (var employeeId in company.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}
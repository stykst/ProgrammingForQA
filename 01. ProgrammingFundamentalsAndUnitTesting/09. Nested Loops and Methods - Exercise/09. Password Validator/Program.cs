var password = Console.ReadLine();

if (IsPasswordValid(password))
{
    Console.WriteLine("Password is valid");
}

else
{
    PrintInvalidPasswordMessages(password);
}

static bool IsPasswordValid(string password)
{
    if (password.Length < 6 || password.Length > 10)
    {
        return false;
    }

    foreach (char c in password)
    {
        if (!char.IsLetterOrDigit(c))
        {
            return false;
        }
    }

    var digitCount = 0;

    foreach (char c in password)
    {
        if (char.IsDigit(c))
        {
            digitCount++;

            if (digitCount >= 2)
            {
                return true;
            }
        }
    }

    return false;
}

static void PrintInvalidPasswordMessages(string password)
{
    if (password.Length < 6 || password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    if (!password.All(char.IsLetterOrDigit))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    var digitCount = password.Count(char.IsDigit);

    if (digitCount < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}
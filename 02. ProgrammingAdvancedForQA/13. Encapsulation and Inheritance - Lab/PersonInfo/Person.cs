using System;

namespace PersonInfo;
public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public Person(string firstName, string lastName, int age)
    {
        ValidateName(firstName, "First name");
        ValidateName(lastName, "Last name");
        ValidateAge(age);

        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    private void ValidateName(string name, string fieldName)
    {
        if (string.IsNullOrEmpty(name) || name.Length < 3)
        {
            throw new ArgumentException($"{fieldName} cannot contain fewer than 3 symbols!");
        }
    }

    private void ValidateAge(int age)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Age cannot be zero or a negative integer!");
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}

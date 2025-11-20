using System;

// ******************************
// 1. CLASS
// ******************************
class Person
{
    public string? FirstName;
    public string? LastName;

    public void ShowPerson()
    {
        Console.WriteLine("Person: " + FirstName + " " + LastName);
    }
}

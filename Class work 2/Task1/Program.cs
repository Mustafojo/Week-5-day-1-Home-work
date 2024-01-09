using System.ComponentModel;

var person = new Person();
System.Console.WriteLine(person.GetFullName());
System.Console.WriteLine(person.GetBirthYear());


public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Address;
    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName}";
    }
    public string GetBirthYear()
    {
        return $"My birth year is {2024 - Age}";
    }
} 
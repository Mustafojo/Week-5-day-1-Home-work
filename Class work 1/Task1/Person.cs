public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string GetInfo()
    {
        return $"FirstName: {FirstName}\n LastName: {LastName}\n Age: {Age}";
    }
}
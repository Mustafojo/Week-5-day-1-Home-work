public class Author
{
    string name;
    int age;
    string nationality;
    public Author(){}
    public Author(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Author(string name, int age, string nationality)
    {
        this.name = name;
        this.age = age;
        this.nationality = nationality;
    }
    public string GetName()
    {
        return name;
    }
        public int GetAge()
    {
        return age;
    }
        public string GetNationality()
    {
        return nationality;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"Номи ман {name}. Ман {age} сола ҳастам. Ман аз {nationality} ҳастам.");
    }
    public void CelebrateBirthday()
    {
        System.Console.WriteLine(age + 1);
    }

}
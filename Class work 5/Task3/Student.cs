public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Average { get; set; }
    Student(int id, string name, int age, double avarage)
    {
        Id = id;
        Name = name;
        Age = age;
        Average = avarage;
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Id = {Id} Name: {Name}, Age: {Age}, Average Grade: {Average}");
    }
    public bool IsExcellentStudent()
    {
        if(Average >= 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
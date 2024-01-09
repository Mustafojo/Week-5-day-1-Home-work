class Student
{
    string fullName;
    int age;
    int grade;

    public Student() 
    {

    }
    public Student(string name,int age)
    {
        fullName = name;

        this.age = age;
    }
    public Student(string name, string subjec, int grade)
    {
        fullName = name;

        this.age = age;

        this.grade = grade;
    }
    public string Study()
    {
        return $"{fullName} is studyng";
    }
    public void SetGrade(int years)
    {
        grade = years; 
    }
    public int GetGrade()
    {
        return grade;
    }
}
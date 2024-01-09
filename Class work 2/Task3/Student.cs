class Student 
{
    public string Name;
    public string SurName;
    public int GradeLevel;
    public List<double> TestScores ;  
    public double AverageScores()
    {
        double sum = 0;
        foreach (var score in TestScores)
        {
            sum+=score;
        }
        return sum/TestScores.Count;
    }
    public string FullName()
    {
        return $"{Name} {SurName}";
    }
}
var student1 = new Student();
student1.Name = "Yusufjon";
student1.SurName = "Mirzoev";
student1.GradeLevel = 9;
student1.TestScores = new List<double>(){100,100,100,100};

var student2 = new Student();
student2.Name = "Davron";
student2.SurName = "Ziyoyev";
student2.GradeLevel = 9;
student2.TestScores = new List<double>(){0,90,80,100};

var student3 = new Student();
student3.Name = "Mustafo";
student3.SurName = "Barotov";
student3.GradeLevel = 9;
student3.TestScores = new List<double>(){50,100,90,20};



var students =  new List<Student>();
students.Add(student1); 
students.Add(student2); 
students.Add(student3); 

 
foreach (var student in students)
{
    var average = student.AverageScores();
    if(average >= 85) System.Console.WriteLine($" Congratulations {student.FullName} on achieving above average scores ({average}) in grade {student.GradeLevel} !  Keep up the good work!   ");
    else if(average >= 70 && average < 85 ) System.Console.WriteLine($"  {student.FullName} if you're having difficulties with your studies, don't hesitate to  seek help. Your current average score is   ({average}) in grade {student.GradeLevel} !  ");

}
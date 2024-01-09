public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public User(string firstName, string lastName, string userName, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        Password = password;
    }
    public void GetInfo(){}
    public void Login(string userName, string password) 
    {
        if(UserName == userName && Password == password)
        {
            System.Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");
        }
        else
        {
            System.Console.WriteLine("Login failed !");
        }
    }
}
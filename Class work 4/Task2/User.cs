public class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public string Password;
    public bool IsLoggedIn;
    public void Login(string username, string password)
    {
        if(UserName == username && Password == password)
        {
            IsLoggedIn = true;
            System.Console.WriteLine("User logged in successfully");
        }
        else
        {
            System.Console.WriteLine("Your password or username is incorrect");
        }
    }
    public void Logout()
    {
        IsLoggedIn = false;
    }
    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} - {IsLoggedIn}";
    }
}
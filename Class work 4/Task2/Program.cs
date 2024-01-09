var user = new User();
user.FirstName = "Mustafo";
user.LastName = "Barotov";
user.UserName = "BarotovMustafo";
user.Password = "1234";
user.IsLoggedIn = false;

user.Login("BM","1111");
user.GetFullInfo();
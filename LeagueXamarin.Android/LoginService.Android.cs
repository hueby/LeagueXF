using System;
namespace LeagueXamarin.Droid
{
    public class LoginService : ILogin
    {
        public LoginService()
        {
        }

        public void Login(string username, string password)
        {
            Console.WriteLine("From Android");
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);
        }
    }
}

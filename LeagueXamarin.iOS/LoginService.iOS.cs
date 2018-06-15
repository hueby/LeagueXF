using System;
namespace LeagueXamarin.iOS
{
    public class LoginService : ILogin
	{
		public LoginService()
		{
            
		}

        public void Login(string username, string password)
        {
            Console.WriteLine("From iOS");
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);
        }
    }
}

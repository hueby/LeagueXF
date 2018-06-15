using System;
using Firebase.Auth;
using Foundation;

namespace LeagueXamarin.iOS
{
    public class LoginService : ILogin
	{
        Auth auth;
		public LoginService()
		{
            auth = Auth.DefaultInstance;
		}

        public void Login(string username, string password)
        {
            auth.SignIn(username, password, SignInCompletion);
        }

        private void SignInCompletion(User user, NSError error)
        {
            if (error == null)
            {
                Console.WriteLine("Logged in.");
                // Load main menu
            } else {
                // creds wrong?
                Console.WriteLine("Something went wrong: " + error.LocalizedDescription);
                Console.WriteLine(error.UserInfo);
            }
        }
    }
}

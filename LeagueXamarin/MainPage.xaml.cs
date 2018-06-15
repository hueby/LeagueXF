using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LeagueXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            loginButton.Clicked += LoginButton_Clicked;
        }

        void LoginButton_Clicked(object sender, EventArgs e)
        {
            App.Login.Login(userName.Text, password.Text);
        }

    }
}

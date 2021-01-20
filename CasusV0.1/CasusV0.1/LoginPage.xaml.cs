using CasusV0._1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CasusV0._1
{
public partial class LoginPage : ContentPage
{
        private const string Query = "select * from Login where LogId = 1";

        public LoginPage()
    {
        InitializeComponent();

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Login>();
                
                
            }
        }

        private void createaccountButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountCreationPage());
        }
    }
}
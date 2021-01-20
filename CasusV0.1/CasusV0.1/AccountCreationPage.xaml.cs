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
public partial class AccountCreationPage : ContentPage
{
    public AccountCreationPage()
    {
        InitializeComponent();
    }

        private void createaccountButton_Clicked(object sender, EventArgs e)
        {
            var nullTextEmail = string.IsNullOrEmpty(emailInput.Text);
            var nullTextUsername = string.IsNullOrEmpty(usernameInput.Text);
            var nullTextPassword = string.IsNullOrEmpty(passwordInput.Text);
            var nullTextConfirmpass = string.IsNullOrEmpty(confirmpassInput.Text);

            if(nullTextUsername || nullTextUsername || nullTextPassword ||nullTextConfirmpass)
            {
                DisplayAlert("Warning!", "You cannot leave these entries empty!", "Ok");
            }
            else if (passwordInput.Text != confirmpassInput.Text)
            {
                DisplayAlert("Warning!", "Passwords do not match!", "Ok");
            }
            else
            {
                Users user = new Users() { Email = emailInput.Text, Username = usernameInput.Text, Password = passwordInput.Text, Weight=0, Length=0 };

                using(SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation) )
                {
                    connection.CreateTable<Users>();
                    int rows = connection.Insert(user);
                    if (rows > 0)
                    {
                        DisplayAlert("Succes", "Succes", "Ok");
                    }
                    else
                    {
                        DisplayAlert("Failure", "You... Failure...", "Ok");
                    }
                }

            }
        }
    }
}
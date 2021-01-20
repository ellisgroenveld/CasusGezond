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
public partial class FriendPage : ContentPage
{
    public FriendPage()
    {
        InitializeComponent();
    }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Users>();
                var list = connection.Query<Users>("select * from Users");
                friendsListView.ItemsSource = list;
            }
        }
    }
}
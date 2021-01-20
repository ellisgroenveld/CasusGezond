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
            
            /// using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            /// {
            ///    connection.CreateTable<xxx>();
            ///    var list = connection.Query<>("select * from xxx");
            ///    friendsListView.ItemsSource = list;
            /// }
        }
    }
}
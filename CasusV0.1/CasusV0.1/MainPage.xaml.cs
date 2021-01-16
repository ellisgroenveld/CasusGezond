using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CasusV0._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            homeButton.IconImageSource = new UriImageSource { CachingEnabled = false, Uri = new Uri("https://static.thenounproject.com/png/1407802-200.png") };
            settingsButton.IconImageSource = new UriImageSource { CachingEnabled = false, Uri = new Uri("https://icons-for-free.com/iconfiles/png/512/configuration+settings+icon-1320191040059302570.png") };
        }
    }
}

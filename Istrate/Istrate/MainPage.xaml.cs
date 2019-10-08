using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Istrate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ConvertorToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertorPage());
        }

        private void DespreToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesprePage());

        }

        private void FavoriteToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FavoritePage());

        }

        private void IstoricToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IstoricPage());

        }
    }
}

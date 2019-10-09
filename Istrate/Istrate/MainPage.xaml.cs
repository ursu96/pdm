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
        List<Curs> listaCursuri = new List<Curs>();

        public MainPage()
        {
            InitializeComponent();

            Curs cursEUR = new Curs
            {
                Valoare = 4.75,
                Valuta = "EUR",
                Data = "2019-10-09"
            };

            Curs cursHUF = new Curs
            {
                Valoare = 4.75,
                Valuta = "EUR",
                Data = "2019-10-09"
            };

            Curs cursUSD = new Curs
            {
                Valoare = 4.32,
                Valuta = "USD",
                Data = "2019-10-09"
            };

            listaCursuri.Add(cursEUR);
            listaCursuri.Add(cursHUF);
            listaCursuri.Add(cursUSD);

            listViewCurs.ItemsSource = listaCursuri;
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

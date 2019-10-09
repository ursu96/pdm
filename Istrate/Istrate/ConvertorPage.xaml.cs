using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Istrate
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConvertorPage : ContentPage
	{
        List<Curs> listaCurs;

        public ConvertorPage(List<Curs> listaCurs)
		{
			InitializeComponent ();

            this.listaCurs = listaCurs;
            Curs cursRon = new Curs
            {
                Valoare = 1,
                Valuta = "RON"
            };

            listaCurs.Add(cursRon);
            //List<string> valute = new List<string>();
            //valute.Add("EUR");
            //valute.Add("USD");
            //valute.Add("RON");

            pickerValutaSursa.ItemsSource = listaCurs;
            pickerValutaDestinatie.ItemsSource = listaCurs;
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonConverteste_Clicked(object sender, EventArgs e)
        {
            double valDeConvertit;
            valDeConvertit = Convert.ToDouble(entryValDeConvertit.Text);

            Curs cursS = (Curs)pickerValutaSursa.SelectedItem;
            Curs cursD = (Curs)pickerValutaDestinatie.SelectedItem;

            double rezultat = (valDeConvertit * cursS.Valoare) / cursD.Valoare;
            valoareConvertitaNoua.Text = Convert.ToString(rezultat);
        }
    }
}
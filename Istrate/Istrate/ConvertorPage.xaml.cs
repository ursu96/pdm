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
		public ConvertorPage()
		{
			InitializeComponent ();
            List<string> valute = new List<string>();
            valute.Add("EUR");
            valute.Add("USD");
            valute.Add("RON");

            pickerValutaSursa.ItemsSource = valute;
            pickerValutaDestinatie.ItemsSource = valute;
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonConverteste_Clicked(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hachathon2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CountryPage : ContentPage
	{
        CountriesViewModel CountriesViewModel = new CountriesViewModel(); 
        private List<string> countriesList;
		public CountryPage ()
		{
            countriesList = CountriesViewModel.CountriesList;
			InitializeComponent ();
            CountryPicker.ItemsSource = countriesList;
		}

        private async void CountryButton_Clicked(object sender, EventArgs e)
        {
            if (CountryPicker.SelectedIndex != -1 )
                {
                    await Navigation.PushAsync(new CampaignListPage());
                }
                else
                {
                    await DisplayAlert("Warning", "You need to choose a country", "Try Again");
                   
                }
        }
    }
}
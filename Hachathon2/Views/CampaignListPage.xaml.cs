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
	public partial class CampaignListPage : ContentPage
	{
        private string[] SortTypeList = { "Ascending Price", "Descending Price", "Ascending Stars", "Descending Stars" };

        public CampaignListPage ()
		{
			InitializeComponent ();
            BindingContext = new campaignDatabaseTest();
            SortPicker.ItemsSource = SortTypeList;
		}
	}
}
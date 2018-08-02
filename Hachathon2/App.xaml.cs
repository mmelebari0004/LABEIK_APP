using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Hachathon2
{
	public partial class App : Application
	{
        static campaignDatabaseMethods campaigndatabase;
        static PilgrimDatabaseMethods Pilgrimdatabase;
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new CountryPage());
		}

        public static campaignDatabase campaignDatabase
        {
            get
            {
                if (campaigndatabase == null)
                {
                    campaigndatabase = new campaignDatabaseMethods(DependencyService.Get<ICampaignLocalDatabase>().GetLocalFilePath("campaign.dp3"));
                }
                return campaignDatabase;
            }
        }

        public static PilgrimDatabase PilgrimDatabase
        {
            get
            {
                if (Pilgrimdatabase == null)
                {
                    campaigndatabase = new campaignDatabaseMethods(DependencyService.Get<ICampaignLocalDatabase>().GetLocalFilePath("order2.dp3"));
                }
                return PilgrimDatabase;
            }
        }
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

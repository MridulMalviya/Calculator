using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Calculator
{
	public partial class App : Application
	{
        public static bool IsUserLoggedIn { get; internal set; }
        public static NavigationPage navPage { set; get; }

        public App ()
		{
			InitializeComponent();
            navPage = new NavigationPage(new LoginPage());
            Application.Current.MainPage = navPage;
            //MainPage = new LoginPage();
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

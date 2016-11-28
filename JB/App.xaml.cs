using Xamarin.Forms;

namespace JB
{
	public partial class App : Application
	{
		public App()
		{
			//Spustí hlavni stranku projektu (Menu.cs)
			MainPage = new NavigationPage(new Menu());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

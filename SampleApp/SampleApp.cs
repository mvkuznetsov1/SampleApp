using System;

using Xamarin.Forms;

namespace SampleApp
{
	public class App : Application
	{
		public App ()
		{			
			MainPage = new NavigationPage();
			MainPage.Navigation.PushAsync (new ImageListPage ());
		}

		protected override void OnStart ()
		{
			
		}

		protected override void OnSleep ()
		{
			
		}

		protected override void OnResume ()
		{
			
		}
	}
}


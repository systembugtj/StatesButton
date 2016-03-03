using System;
using StatesButton.Forms;
using Xamarin.Forms;

namespace StatesButton.Test
{
	public class App : Application
	{
		StatesButtonControl Button {
			get;
			set;
		}

		public App()
		{
			Button = new StatesButtonControl () {
				Text = "Hello",
				BackgroundColor = Color.Red,
				DisableBackgroundColor = Color.Blue,
				PressedBackgroundColor = Color.Fuchsia,
				TextColor = Color.White
			};

			/*Button = new StatesButtonControl () {
				Text = "Hello",
				NormalImage = "boton",
				DisableImage = "boton_disabled",
				PressedImage = "boton_press",
				TextColor = Color.White
			};*/

			// The root page of your application
			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Padding = new Thickness(20, 0),
					Children = {
						Button
					}
				}
			};
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


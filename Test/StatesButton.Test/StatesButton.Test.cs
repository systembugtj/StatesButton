using System;
using System.Threading.Tasks;
using StatesButton.Forms;
using Xamarin.Forms;

namespace StatesButton.Test
{
	public class App : Application
	{
		StatesButtonControl ColorButton
        {
			get;
			set;
		}

        StatesButtonControl ImageButton
        {
            get;
            set;
        }

		public App()
		{
            ColorButton = new StatesButtonControl
            {
				Text = "Hello Color",
				BackgroundColor = Color.Red,
				DisableBackgroundColor = Color.Blue,
				PressedBackgroundColor = Color.Fuchsia,
				TextColor = Color.White
			};

            ImageButton = new StatesButtonControl
            {
				Text = "Hello Image",
				NormalImage = "button",
				DisableImage = "button_disabled",
				PressedImage = "button_press",
				TextColor = Color.White
			};

			// The root page of your application
			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Padding = new Thickness(20, 0),
					Children = {
                        ColorButton,
                        ImageButton
					}
				}
			};
		}


        protected override void OnStart()
        {

            Task.Run(async () =>
            {
                // Handle when your app starts
                await Task.Delay(5000);
                ColorButton.IsEnabled = false;
                ImageButton.IsEnabled = false;
            });

            base.OnStart();
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


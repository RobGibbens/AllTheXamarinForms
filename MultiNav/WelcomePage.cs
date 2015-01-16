using System;

using Xamarin.Forms;

namespace MultiNav
{
	public class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			this.Title = "AppTitle";
			var layout = new StackLayout ();

			layout.Children.Add(new Label { Text = "Welcome X", HorizontalOptions = LayoutOptions.CenterAndExpand }); 
			layout.Children.Add(new Label { Text = "Latest News", HorizontalOptions = LayoutOptions.CenterAndExpand }); 


			this.Content = layout;
		}
	}
	
}

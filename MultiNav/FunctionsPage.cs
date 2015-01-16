using System;

using Xamarin.Forms;

namespace MultiNav
{
	public class FunctionsPage : ContentPage
	{
		public FunctionsPage ()
		{
			var layout = new StackLayout () { 
				Orientation = StackOrientation.Vertical
			};
			this.Title = "MenuItemX";
			var functionA = new Button () { 
				Text = "Function A",
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};			
			var functionB = new Button () { 
				Text = "Function B",
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			var functionC = new Button () { 
				Text = "Function C",
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			functionB.Clicked += async (sender, e) => {
				this.Navigation.PushAsync(new MyTabbedPage());
			};
			layout.Children.Add (functionA);
			layout.Children.Add (functionB);
			layout.Children.Add (functionC);
			this.Content = layout;
		}
	}
	
}

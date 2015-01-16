using System;

using Xamarin.Forms;

namespace MultiNav
{
	public class CarouselContent2 : ContentPage
	{
		public CarouselContent2 ()
		{
			this.BackgroundColor = Color.Red;
			this.Content = new Label { 
				Text = "Part 2 of Carousel",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}
	
}

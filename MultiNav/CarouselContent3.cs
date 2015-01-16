using System;

using Xamarin.Forms;

namespace MultiNav
{

	public class CarouselContent3 : ContentPage
	{
		public CarouselContent3 ()
		{
			this.BackgroundColor = Color.Green;
			this.Content = new Label { 
				Text = "Part 3 of Carousel",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}
	
}

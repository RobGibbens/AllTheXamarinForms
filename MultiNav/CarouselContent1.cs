using System;

using Xamarin.Forms;

namespace MultiNav
{

	public class CarouselContent1 : ContentPage
	{
		public CarouselContent1 ()
		{
			this.BackgroundColor = Color.Blue;
			this.Content = new Label { 
				Text = "Part 1 of Carousel",
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}

	
}

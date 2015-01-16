using System;

using Xamarin.Forms;

namespace MultiNav
{
	public class MyCarouselPage2 : CarouselPage
	{
		public MyCarouselPage2 ()
		{
			this.Children.Add (new CarouselContent1 ());
			this.Children.Add (new CarouselContent2 ());

		}
	}
	
}

using System;

using Xamarin.Forms;

namespace MultiNav
{
	public class MyCarouselPage1 : CarouselPage
	{
		public MyCarouselPage1 ()
		{
			this.Children.Add (new CarouselContent1 ());
			this.Children.Add (new CarouselContent2 ());
			this.Children.Add (new CarouselContent3 ());

		}
	}
	
}

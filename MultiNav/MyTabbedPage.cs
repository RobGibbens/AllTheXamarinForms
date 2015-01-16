using System;
using Xamarin.Forms;

namespace MultiNav
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
			this.Title = "Function B";

			this.Children.Add (new MyCarouselPage1 () { Title = "Tab 1" });
			this.Children.Add (new MyCarouselPage2 () { Title = "Tab 2" });
			this.Children.Add (new MyCarouselPage2 () { Title = "Tab 3" });
		}
	}
}
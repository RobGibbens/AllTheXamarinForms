using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace MultiNav
{
	public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
			this.Add (new MenuItem () { 
				Title = "MenuItem 1", 
				IconSource = "contracts.png", 
				TargetType = typeof(WelcomePage)
			});

			this.Add (new MenuItem () { 
				Title = "MenuItem 2", 
				IconSource = "Lead.png", 
				TargetType = typeof(FunctionsPage)
			});

			this.Add (new MenuItem () { 
				Title = "MenuItem 3", 
				IconSource = "Accounts.png", 
				TargetType = typeof(AccountsPage)
			});

			this.Add (new MenuItem () {
				Title = "MenuItem X",
				IconSource = "Opportunity.png",
				TargetType = typeof(OpportunitiesPage)
			});
		}
	}
	
}

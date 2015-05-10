using System;
using Xamarin.Forms;

namespace XForms
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new HelloView (
				new HelloViewModel("Hello, XForms")
			);
		}
	}
}


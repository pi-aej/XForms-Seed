using System;
using Xamarin.Forms;

namespace XForms
{
	public class HelloView : ContentPage
	{
		public HelloView ()
		{
			Content = new Label {
				Text = "Hello, Forms!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}


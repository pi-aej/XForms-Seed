using System;
using Xamarin.Forms;

namespace XForms
{
	public class HelloView : ContentPage
	{
		public HelloView (HelloViewModel context)
		{
			Content = new Label {
				Text = context.Words,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}


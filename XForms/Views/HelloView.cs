using System;
using Xamarin.Forms;

namespace XForms
{
	public class HelloView : ContentPage
	{
		public HelloView (HelloViewModel context)
		{
			var title = new Label {
				Text = context.Words,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			var blemessage = new Label {
				Text = context.HowManyDevices,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			Content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Children = { 
					title, 
					blemessage }
			};
		}
	}
}


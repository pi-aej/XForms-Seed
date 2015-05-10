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
			//Note: This no databinding yet!
			var blemessage = new Label {
				Text = context.HowManyDevices,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			var scanbutton = new Button {
				Text = "Scan for Devices",
				Command = new Command (() => context.ScanForDevices ())
			};
			Content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Children = { 
					title, 
					blemessage,
					scanbutton
				}
			};
		}
	}
}


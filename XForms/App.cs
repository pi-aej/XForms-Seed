using System;
using Xamarin.Forms;
using IBLEAdapter = Robotics.Mobile.Core.Bluetooth.LE.IAdapter;

namespace XForms
{
	public class App
	{
		static IBLEAdapter BLEAdapter;

		public static void SetBluetoothAdapter (IBLEAdapter adapter) {
			BLEAdapter = adapter;
		}

		public static Page GetMainPage ()
		{	
			return new HelloView (
				new HelloViewModel(
					"Hello, XForms", 
					new BLEService(App.BLEAdapter))
			);
		}
	}
}


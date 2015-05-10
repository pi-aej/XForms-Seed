using System;
using System.Linq;
using System.ComponentModel;

namespace XForms
{
	public class HelloViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string Words { get; private set; }

		IBLEService bleservice;

		public HelloViewModel (string wordmodel, IBLEService blemodel)
		{
			Words = wordmodel;
			bleservice = blemodel;
		}

		public void ScanForDevices()
		{
			bleservice.Scan();
			PropertyChanged (this, new PropertyChangedEventArgs ("HowManyDevices"));
		}

		public string HowManyDevices
		{
			get{
				return String.Format ("There are {0} devices connected!", bleservice.Devices.Count());
			}
		}
	}
}


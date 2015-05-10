using System;
using System.Linq;

namespace XForms
{
	public class HelloViewModel
	{
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
		}

		public string HowManyDevices
		{
			get{
				return String.Format ("There are {0} devices connected!", bleservice.Devices.Count());
			}
		}
	}
}


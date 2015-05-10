using System;
using System.Collections.Generic;
using Robotics.Mobile.Core.Bluetooth.LE;

namespace XForms
{
	public class MockBLEService : IBLEService
	{
		List<IDevice> devices = new List<IDevice>();

		public MockBLEService ()
		{
			
		}

		#region IBLEService implementation

		public void Scan ()
		{
			devices.Add (new MockDevice ());
		}

		public IEnumerable<IDevice> Devices 
		{
			get 
			{
				return devices;
			}
		}

		#endregion
	}
}


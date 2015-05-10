using System;
using Robotics.Mobile.Core.Bluetooth.LE;
using System.Collections.Generic;

namespace XForms
{
	public class BLEService
	{
		IAdapter Adapter;
		public BLEService (IAdapter adapter)
		{
			Adapter = adapter;
		}

		public void Scan()
		{
			Adapter.StartScanningForDevices(Guid.Empty);
		}

		public IEnumerable<IDevice> Devices
		{
			get 
			{
				return Adapter.ConnectedDevices;
			}
		}
	}
}


using System;
using System.Collections.Generic;
using Robotics.Mobile.Core.Bluetooth.LE;

namespace XForms
{
	public interface IBLEService
	{
		void Scan();
		IEnumerable<IDevice> Devices { get; }
	}
}


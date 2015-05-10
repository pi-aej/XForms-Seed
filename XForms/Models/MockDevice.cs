using System;
using Robotics.Mobile.Core.Bluetooth.LE;

namespace XForms
{
	public class MockDevice : IDevice
	{
		public MockDevice ()
		{
		}

		#region IDevice implementation

		public event EventHandler ServicesDiscovered;

		public void DiscoverServices ()
		{
			throw new NotImplementedException ();
		}

		public Guid ID {
			get {
				throw new NotImplementedException ();
			}
		}

		public string Name {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Rssi {
			get {
				throw new NotImplementedException ();
			}
		}

		public object NativeDevice {
			get {
				throw new NotImplementedException ();
			}
		}

		public DeviceState State {
			get {
				throw new NotImplementedException ();
			}
		}

		public System.Collections.Generic.IList<IService> Services {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion
	}
}


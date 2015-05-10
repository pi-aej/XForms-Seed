using System;

namespace XForms
{
	public class HelloViewModel
	{
		public string Words { get; private set; }

		public HelloViewModel (string wordmodel)
		{
			Words = wordmodel;
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Session
{
	public class Global : System.Web.HttpApplication
	{
		protected void Session_Start(object sender, EventArgs e)
		{
			Session["Skin"] = "YellowPanorama";
			Session["Culture"] = Thread.CurrentThread.CurrentUICulture;
			Session["Photo"] = Photo.Unknown;
		}
	}

	public class Photo
	{
		public byte[] ImageData { get; private set; }
		public string ImageFormat { get; private set; }
		public int Width { get; private set; }
		public int Height { get; private set; }

		public static Photo Unknown
		{
			get
			{
				return new Photo()
				{
					ImageData = Enumerable.Range(0, 120000).Select(i => (byte)(i % 256)).ToArray(), // fake 120kB
					ImageFormat = "bmp",
					Width = 400,
					Height = 300
				};

			}
		}

	}

}
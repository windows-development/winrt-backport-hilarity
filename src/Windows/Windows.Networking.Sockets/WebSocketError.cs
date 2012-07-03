using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Web;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IWebSocketErrorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class WebSocketError
	{
		public static extern WebErrorStatus GetStatus([In] int hresult);
	}
}

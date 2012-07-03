using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DoubleTappedRoutedEventArgs : RoutedEventArgs, IDoubleTappedRoutedEventArgs
	{
		public extern bool Handled
		{
			get;
			set;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern DoubleTappedRoutedEventArgs();
		public extern Point GetPosition([In] UIElement relativeTo);
	}
}

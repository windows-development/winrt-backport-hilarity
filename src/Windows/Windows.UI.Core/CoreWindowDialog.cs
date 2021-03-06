using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.UI.Core
{
	[Activatable(typeof(ICoreWindowDialogFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class CoreWindowDialog : ICoreWindowDialog
	{
		public extern event TypedEventHandler<CoreWindow, CoreWindowPopupShowingEventArgs> Showing
		{
			add;
			remove;
		}
		public extern UICommandInvokedHandler BackButtonCommand
		{
			get;
			set;
		}
		public extern uint CancelCommandIndex
		{
			get;
			set;
		}
		public extern IVector<IUICommand> Commands
		{
			get;
		}
		public extern uint DefaultCommandIndex
		{
			get;
			set;
		}
		public extern int IsInteractionDelayed
		{
			get;
			set;
		}
		public extern Size MaxSize
		{
			get;
		}
		public extern Size MinSize
		{
			get;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern CoreWindowDialog([In] string title);
		public extern CoreWindowDialog();
		public extern IAsyncOperation<IUICommand> ShowAsync();
	}
}

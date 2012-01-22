// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace ProteinTracker
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel TotalProtein { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField EnteredProtein { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Goal { get; set; }

		[Action ("showInfo:")]
		partial void showInfo (MonoTouch.Foundation.NSObject sender);

		[Action ("enter:")]
		partial void enter (MonoTouch.Foundation.NSObject sender);
	}
}

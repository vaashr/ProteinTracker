using MonoTouch.UIKit;
using System;
using MonoTouch.Foundation;

namespace ProteinTracker
{
	public partial class MainViewController : UIViewController
	{
		public MainViewController () : base ("MainViewController", null)
		{
			// Custom initialization
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			TotalProtein.Text = "200 grams";
			EnteredProtein.EditingDidBegin += EnteredDidBegin;
			//any additional setup after loading the view, typically from a nib.
		}

		void EnteredDidBegin (object sender, EventArgs e)
		{
			TotalProtein.Text = "Entering Text";
		}
		
		public override void ViewWillAppear (bool animated)
		{
			Goal.Text = NSUserDefaults.StandardUserDefaults.StringForKey("goal") + " grams";
			base.ViewWillAppear (animated);
			
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Release any retained subviews of the main view.
			// e.g. myOutlet = null;
		}
		
		partial void enter (NSObject sender)
		{
			TotalProtein.Text = EnteredProtein.Text + " grams";
		}
		
		partial void showInfo (NSObject sender)
		{
			var controller = new FlipsideViewController () {
				ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
			};
			controller.Done += delegate {
				DismissModalViewControllerAnimated (true);
			};
			PresentModalViewController (controller, true);
		}
	}
}

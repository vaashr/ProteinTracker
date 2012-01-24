using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.IO;

namespace ProteinTracker
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		//MainViewController mainViewController;
		//UITabBarController tabController;
		UINavigationController NavigationController;
		//UITabBarController TabController;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		
		public static void RegisterDefaultsFromSettingsBundle() 
		{
		    string settingsBundle = NSBundle.MainBundle.PathForResource("Settings", @"bundle");
		    if(settingsBundle == null) {
		        System.Console.WriteLine(@"Could not find Settings.bundle");
		        return;
		    }
		    NSString keyString = new NSString(@"Key");
		    NSString defaultString = new NSString(@"DefaultValue");
		    NSDictionary settings = NSDictionary.FromFile(Path.Combine(settingsBundle,@"Root.plist"));
		    NSArray preferences = (NSArray) settings.ValueForKey(new NSString(@"PreferenceSpecifiers"));
		    NSMutableDictionary defaultsToRegister = new NSMutableDictionary();
		    for (uint i=0; i<preferences.Count; i++) {
		        NSDictionary prefSpecification = new NSDictionary(preferences.ValueAt(i));
		        NSString key = (NSString) prefSpecification.ValueForKey(keyString);
		        if(key != null) {
		            NSObject def = prefSpecification.ValueForKey(defaultString);
		            if (def != null) {
		                defaultsToRegister.SetValueForKey(def, key);
		            }
		        }
		    }
		    NSUserDefaults.StandardUserDefaults.RegisterDefaults(defaultsToRegister);
		}
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			//load defaults
			RegisterDefaultsFromSettingsBundle();
			this.NavigationController = new UINavigationController();
			MainViewController mainviewcontroller = new MainViewController();
			//HistoryViewController historyviewcontroller = new HistoryViewController();
			NavigationController.PushViewController(mainviewcontroller, false);
			//this.TabController = new UITabBarController();
			//TabController.ViewControllers = new UIViewController[] {
			//	NavigationController,
			//	historyviewcontroller
			//};
			window.RootViewController = this.NavigationController;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}


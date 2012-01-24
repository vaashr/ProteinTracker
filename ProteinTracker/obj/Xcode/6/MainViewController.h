// WARNING
// This file has been generated automatically by MonoDevelop to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>
#import <CoreGraphics/CoreGraphics.h>


@interface MainViewController : UIViewController {
	UILabel *_TotalProtein;
	UITextField *_EnteredProtein;
	UILabel *_Goal;
	UIButton *_History;
}

@property (nonatomic, retain) IBOutlet UILabel *TotalProtein;

@property (nonatomic, retain) IBOutlet UITextField *EnteredProtein;

@property (nonatomic, retain) IBOutlet UILabel *Goal;

@property (nonatomic, retain) IBOutlet UIButton *History;

- (IBAction)showInfo:(id)sender;

- (IBAction)enter:(id)sender;

@end

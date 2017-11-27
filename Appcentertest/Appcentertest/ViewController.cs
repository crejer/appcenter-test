using System;

using UIKit;

namespace Appcentertest
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        public override void ViewDidAppear(bool animated)
        {
            //Create Alert
            var okAlertController = UIAlertController.Create("OK Alert", "Ik ben jeroen: " + System.Environment.GetEnvironmentVariable("TestVariable"), UIAlertControllerStyle.ActionSheet);

            //Add Action
            okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));

            // Present Alert
            PresentViewController(okAlertController, true, null);
        }
    }
        
        
}

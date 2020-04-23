using Foundation;
using System;
using UIKit;

namespace TrackingApp
{
    public partial class ViewController : UIViewController
    {
        int counter = 0;

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            ClickButton.TouchUpInside += ClickButton_TouchUpInside;
        }

        private void ClickButton_TouchUpInside(object sender, EventArgs e)
        {
            counter++;
            ClickButton.SetTitle($"You Tapped The Button {counter} times!", UIControlState.Normal);
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
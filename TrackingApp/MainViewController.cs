using Foundation;
using System;
using UIKit;

namespace TrackingApp
{
    public partial class MainViewController : UIViewController
    {
        int counter = 0;

        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ClickButton.TouchUpInside += IncrementButton_TouchUpInside;
        }

        public void IncrementButton_TouchUpInside(object sender, EventArgs e)
        {
            counter++;
            ClickButton.SetTitle($"You've clicked {counter} times!", UIControlState.Normal);
        }

    }
}
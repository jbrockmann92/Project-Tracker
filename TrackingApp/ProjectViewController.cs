using Foundation;
using System;
using UIKit;

namespace TrackingApp
{
    public partial class ProjectViewController : UIViewController
    {
        public ProjectViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ProjectName.Text = "This Project";
        }
    }
}
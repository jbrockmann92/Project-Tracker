using Foundation;
using RestSharp;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using UIKit;

namespace TrackingApp
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Project1Button.TouchUpInside += Project1Button_TouchUpInside;
        }

        public void Project1Button_TouchUpInside(object sender, EventArgs e)
        {
            ProjectViewController project = this.Storyboard.InstantiateViewController("ProjectViewController") as ProjectViewController;
            this.NavigationController.PushViewController(project, true);
        }

    }
}
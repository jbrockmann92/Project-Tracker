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

            ProjectName.Text = "This Project"; //Can change to the right name here. When API call is working and JSON is formatted correctly
            ReceiptsButton.TouchUpInside += ReceiptsButton_TouchUpInside;
            ExpensesButton.TouchUpInside += ExpensesButton_TouchUpInside;
        }

        public void ReceiptsButton_TouchUpInside(object sender, EventArgs e)
        {
            ReceiptsViewController receipts = this.Storyboard.InstantiateViewController("ReceiptsViewController") as ReceiptsViewController;
            this.NavigationController.PushViewController(receipts, true);
        }

        public void ExpensesButton_TouchUpInside(object sender, EventArgs e)
        {
            ExpensesViewController expenses = this.Storyboard.InstantiateViewController("ExpensesViewController") as ExpensesViewController;
            this.NavigationController.PushViewController(expenses, true);
        }
    }
}
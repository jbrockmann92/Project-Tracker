using Foundation;
using System;
using System.Net.Http;
using UIKit;

namespace TrackingApp
{
    public partial class ProjectViewController : UIViewController
    {
        public ProjectViewController (IntPtr handle) : base (handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            HttpClient client = new HttpClient();

            var response = client.GetAsync("https://localhost:44322/api/home");
            Console.WriteLine(response);

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
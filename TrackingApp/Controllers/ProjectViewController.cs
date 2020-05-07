using Foundation;
using System;
using System.Net;
using System.Net.Http;
using UIKit;
using TrackingApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrackingApp
{
    public partial class ProjectViewController : UIViewController
    {
        public Project project = new Project(); //Ideally I want to assign this in the constructor so I can leave it private. But I can worry about that later

        public ProjectViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ProjectName.Text = project.Title; //Can change to the right name here. When API call is working and JSON is formatted correctly
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
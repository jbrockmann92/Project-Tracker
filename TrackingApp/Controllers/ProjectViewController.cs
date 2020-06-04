using System;
using UIKit;
using TrackingApp.Models;
using CoreGraphics;

namespace TrackingApp
{
    public partial class ProjectViewController : UIViewController
    {
        public Project project = new Project(); //Need to get from the api again? Should be able t

        public ProjectViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ProjectName.Text = project.Title;
            ProjectNumber.Text = project.Id.ToString();
            Mileage.Text = "Total Mileage: " + project.Mileage.ToString() + "mi";
            Budget.Text = "Budget: $" + project.BudgetUsed.ToString() + "/" + project.Budget.ToString();

            ReceiptsButton.TouchUpInside += ReceiptsButton_TouchUpInside;
            ExpensesButton.TouchUpInside += ExpensesButton_TouchUpInside;

            for (int i = 0; i < project.Notes.Count; i++)
            {
                UILabel label = new UILabel();
                label.Text = project.Notes[i].Title + project.Notes[i].Text;
                label.Frame = new CGRect(41, (396 + (45 * (i + 1))), 353, 21);

                View.Add(label);
            }
        }

        public void ReceiptsButton_TouchUpInside(object sender, EventArgs e)
        {
            ReceiptsViewController receiptsController = this.Storyboard.InstantiateViewController("ReceiptsViewController") as ReceiptsViewController;
            receiptsController.receipts = project.Receipts;
            this.NavigationController.PushViewController(receiptsController, true);
        }

        public void ExpensesButton_TouchUpInside(object sender, EventArgs e)
        {
            ExpensesViewController expensesController = this.Storyboard.InstantiateViewController("ExpensesViewController") as ExpensesViewController;
            expensesController.expenses = project.Expenses;
            expensesController.Title = project.Title;
            this.NavigationController.PushViewController(expensesController, true);
        }
    }
}
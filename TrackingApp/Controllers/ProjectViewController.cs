using Foundation;
using System;
using System.Net;
using System.Net.Http;
using UIKit;
using TrackingApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ProjectAPI.Models;
using System.Collections.Generic;

namespace TrackingApp
{
    public partial class ProjectViewController : UIViewController
    {
        public Project project = new Project(); //Ideally I want to assign this in the constructor so I can leave it private. But I can worry about that later
        List<Expense> expenses = new List<Expense>();
        List<HoursSpent> hours = new List<HoursSpent>();
        List<Note> notes = new List<Note>();
        List<Receipt> receipts = new List<Receipt>();

        public ProjectViewController (IntPtr handle) : base (handle)
        {
            expenses = project.Expenses;
            hours = project.HoursSpent;
            notes = project.Notes;
            receipts = project.Receipts;
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
        }

        public void ReceiptsButton_TouchUpInside(object sender, EventArgs e)
        {
            ReceiptsViewController receiptsController = this.Storyboard.InstantiateViewController("ReceiptsViewController") as ReceiptsViewController;
            receiptsController.receipts = receipts;
            this.NavigationController.PushViewController(receiptsController, true);
        }

        public void ExpensesButton_TouchUpInside(object sender, EventArgs e)
        {
            ExpensesViewController expensesController = this.Storyboard.InstantiateViewController("ExpensesViewController") as ExpensesViewController;
            expensesController.expenses = expenses;
            expensesController.Title = project.Title;
            this.NavigationController.PushViewController(expensesController, true);
        }
    }
}
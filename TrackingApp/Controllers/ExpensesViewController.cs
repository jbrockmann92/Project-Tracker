using Foundation;
using System;
using TrackingApp.Models;
using UIKit;
using ProjectAPI.Models;
using System.Collections.Generic;

namespace TrackingApp
{
    public partial class ExpensesViewController : UIViewController
    {
        public List<Expense> expenses = new List<Expense>();
        public string projectTitle;

        public ExpensesViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Will need to make this a for loop later, but works now for testing
            ExpenseName.Text = expenses[0].Title.ToString();
            ExpenseTotal.Text = expenses[0].Cost.ToString();
            ExpenseProjectNumber.Text = expenses[0].Id.ToString();
            ExpenseProjectTitle.Text = projectTitle;
        }
    }
}
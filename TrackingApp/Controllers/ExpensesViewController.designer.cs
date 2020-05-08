// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TrackingApp
{
    [Register ("ExpensesViewController")]
    partial class ExpensesViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddExpenseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ExpenseName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ExpenseProjectNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ExpenseProjectTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ExpenseTotal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddExpenseButton != null) {
                AddExpenseButton.Dispose ();
                AddExpenseButton = null;
            }

            if (ExpenseName != null) {
                ExpenseName.Dispose ();
                ExpenseName = null;
            }

            if (ExpenseProjectNumber != null) {
                ExpenseProjectNumber.Dispose ();
                ExpenseProjectNumber = null;
            }

            if (ExpenseProjectTitle != null) {
                ExpenseProjectTitle.Dispose ();
                ExpenseProjectTitle = null;
            }

            if (ExpenseTotal != null) {
                ExpenseTotal.Dispose ();
                ExpenseTotal = null;
            }
        }
    }
}
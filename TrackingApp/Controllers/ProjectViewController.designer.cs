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
    [Register ("ProjectViewController")]
    partial class ProjectViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ExpensesButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ProjectName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ProjectNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ReceiptsButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ExpensesButton != null) {
                ExpensesButton.Dispose ();
                ExpensesButton = null;
            }

            if (ProjectName != null) {
                ProjectName.Dispose ();
                ProjectName = null;
            }

            if (ProjectNumber != null) {
                ProjectNumber.Dispose ();
                ProjectNumber = null;
            }

            if (ReceiptsButton != null) {
                ReceiptsButton.Dispose ();
                ReceiptsButton = null;
            }
        }
    }
}
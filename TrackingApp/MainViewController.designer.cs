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
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClickButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Hello { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ClickButton != null) {
                ClickButton.Dispose ();
                ClickButton = null;
            }

            if (Hello != null) {
                Hello.Dispose ();
                Hello = null;
            }
        }
    }
}
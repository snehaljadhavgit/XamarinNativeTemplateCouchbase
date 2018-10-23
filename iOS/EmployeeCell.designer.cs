// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinNativeTemplate.iOS
{
    [Register ("EmployeeCell")]
    partial class EmployeeCell
    {
        [Outlet]
        UIKit.UILabel lblName { get; set; }


        [Outlet]
        UIKit.UILabel lblNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }

            if (lblNumber != null) {
                lblNumber.Dispose ();
                lblNumber = null;
            }
        }
    }
}
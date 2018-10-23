// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinNativeTemplate.iOS.ViewCell
{
    [Register ("MyTableViewCell")]
    partial class MyTableViewCell
    {
        [Outlet]
        UIKit.UIImageView imgEmployee { get; set; }


        [Outlet]
        UIKit.UILabel txtEmployeeName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgEmployee != null) {
                imgEmployee.Dispose ();
                imgEmployee = null;
            }

            if (txtEmployeeName != null) {
                txtEmployeeName.Dispose ();
                txtEmployeeName = null;
            }
        }
    }
}
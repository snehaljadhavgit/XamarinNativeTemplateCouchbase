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
    [Register ("MyTableViewController")]
    partial class MyTableViewController
    {
        [Outlet]
        UIKit.UITableView tblHomeViewList { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (tblHomeViewList != null) {
                tblHomeViewList.Dispose ();
                tblHomeViewList = null;
            }
        }
    }
}
// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XamarinNativeTemplate.iOS
{
	[Register ("EmpViewController")]
	partial class EmpViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem btnAdd { get; set; }

		[Outlet]
		UIKit.UITableView tvEmployee { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tvEmployee != null) {
				tvEmployee.Dispose ();
				tvEmployee = null;
			}

			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
		}
	}
}

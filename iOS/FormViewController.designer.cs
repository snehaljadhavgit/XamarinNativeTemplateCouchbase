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
	[Register ("FormViewController")]
	partial class FormViewController
	{
		[Outlet]
		UIKit.UIButton btnAdd { get; set; }

		[Outlet]
		UIKit.UITextField txtDOB { get; set; }

		[Outlet]
		UIKit.UITextField txtEmailId { get; set; }

		[Outlet]
		UIKit.UITextField txtName { get; set; }

		[Outlet]
		UIKit.UITextField txtNumber { get; set; }

		[Action ("AddNewEmployee:")]
		partial void AddNewEmployee (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}

			if (txtNumber != null) {
				txtNumber.Dispose ();
				txtNumber = null;
			}

			if (txtEmailId != null) {
				txtEmailId.Dispose ();
				txtEmailId = null;
			}

			if (txtDOB != null) {
				txtDOB.Dispose ();
				txtDOB = null;
			}

			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
		}
	}
}

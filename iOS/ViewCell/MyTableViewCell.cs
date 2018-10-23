using System;

using Foundation;
using UIKit;

namespace XamarinNativeTemplate.iOS.ViewCell
{
    public partial class MyTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MyTableViewCell");
        public static readonly UINib Nib;

        static MyTableViewCell()
        {
            Nib = UINib.FromName("MyTableViewCell", NSBundle.MainBundle);
        }

        protected MyTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public static MyTableViewCell Create()
        {
            var cell = (MyTableViewCell)Nib.Instantiate(null, null)[0];

            return cell;
        }

        public void ConfigureHomeViewCell(int pintJobItemIndex, Employee pEmp)
        {
            //TODO: confirgure the cell data here...

        }
        //To attach the data to the cell of table view.
        public void SetDataforRow(Employee empModel)
        {
            if (empModel != null)
            {
                txtEmployeeName.Text = empModel.Name;               
            }
        }
    }
}

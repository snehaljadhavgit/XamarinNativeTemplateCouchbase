using System;

using UIKit;

namespace XamarinNativeTemplate.iOS
{
    public partial class ViewController : UIViewController
    {
        MainViewModel MainVm
        {
            get
            {
                return AppDelegate.Locator.MainVm;
            }
        }
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public ViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            //btnClickMe.AccessibilityIdentifier = "myButton";
            //btnClickMe.TouchUpInside += delegate
            //{
            //    var title = string.Format("{0} clicks!", count++);
            //    btnClickMe.SetTitle(title, UIControlState.Normal);
            //};
            MainVm.BuildEmployeeList();
          
            //tblEmployee.Source = new EmployeeTableViewSource(MainVm.AllEmployees);
            //tblEmployee.RowHeight = UITableView.AutomaticDimension;
            //tblEmployee.EstimatedRowHeight = 40f;
            //tblEmployee.ReloadData();

        }

    
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}

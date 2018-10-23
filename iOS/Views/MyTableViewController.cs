using System;
using CoreGraphics;
using Foundation;
using UIKit;
using XamarinNativeTemplate.iOS.ViewCell;

namespace XamarinNativeTemplate.iOS
{
    public partial class MyTableViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate
    {
        const string HomeViewCellIndentifier = "HomeViewCellIndentifier";

        MainViewModel MainVm
        {
            get
            {
                return AppDelegate.Locator.MainVm;
            }
        }

        public MyTableViewController() : base("MyTableViewController", null)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Set the page title
            Title = StringsConstants.EMPLOYEE_LIST_PAGETITLE;

            // Set the navigation bar
            NavigationController.NavigationBar.Translucent = false;
            NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes
            {
                ForegroundColor = UIColor.White
            };
            NavigationController.NavigationBar.TintColor = UIColor.White;
            NavigationController.NavigationBar.BarTintColor = UIColor.FromRGB(0, 68, 131);
            NavigationController.NavigationBarHidden = false;

            NavigationController.NavigationBar.Layer.ShadowOpacity = 1.0f;
            NavigationController.NavigationBar.Layer.ShadowRadius = 2;
            NavigationController.NavigationBar.Layer.ShadowOffset = new CGSize(0, 1);
            NavigationController.NavigationBar.Layer.ShadowColor = UIColor.DarkGray.CGColor;

            MainVm.BuildEmployeeList();

            tblHomeViewList.WeakDataSource = this;
            tblHomeViewList.WeakDelegate = this;

            tblHomeViewList.TableFooterView = new UIView(new CGRect(0, 0, 0, 0));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        #region Data source methods of Table View

        [Export("tableView:numberOfRowsInSection:")]
        public nint RowsInSection(UITableView tableView, nint section)
        {
            if (MainVm.AllEmployees != null && MainVm.AllEmployees.Count > 0)
                return MainVm.AllEmployees.Count;
            
            return 0;
        }

        [Export("tableView:heightForRowAtIndexPath:")]
        public nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 60;
        }

        [Export("tableView:cellForRowAtIndexPath:")]
        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var homeViewCell = (MyTableViewCell)tableView.DequeueReusableCell(HomeViewCellIndentifier);

            if (homeViewCell == null)
            {
                homeViewCell = MyTableViewCell.Create();

                homeViewCell.SelectionStyle = UITableViewCellSelectionStyle.None;
            }
            homeViewCell.SetDataforRow(MainVm.AllEmployees[indexPath.Row]);
          //  homeViewCell.ConfigureHomeViewCell(indexPath.Row, MainVm.AllEmployees[indexPath.Row]);

            homeViewCell.LayoutMargins = UIEdgeInsets.Zero;
            homeViewCell.PreservesSuperviewLayoutMargins = false;

            return homeViewCell;
        }

        #endregion

        #region Table View Delegate

        [Export("tableView:didSelectRowAtIndexPath:")]
        public void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //TODO: action for row selected...
        }

        #endregion
    }
}
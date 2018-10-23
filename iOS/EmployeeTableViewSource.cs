using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UIKit;

namespace XamarinNativeTemplate.iOS
{
    public class EmployeeTableViewSource  : UITableViewSource
    {
        private ObservableCollection<Employee> employees;
        protected string cellIdentifier = "cell_id";


        public EmployeeTableViewSource(ObservableCollection<Employee> employees)
        {
            this.employees = employees;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            //UITableViewCell cell = (EmployeeCelllClass)tableView.DequeueReusableCell(cellIdentifier);

            //string item = employees[indexPath.Row].Name;

            ////---- if there are no cells to reuse, create a new one
            //if (cell == null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

            //    cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
            //}

            //cell.LayoutMargins = UIEdgeInsets.Zero;
            //cell.PreservesSuperviewLayoutMargins = false;

            var cell = (EmployeeCell)tableView.DequeueReusableCell(cellIdentifier, indexPath);
            var employee = employees[indexPath.Row];
            cell.UpdateCell(employee);
            return cell;

        }
        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            //base.RowSelected(tableView, indexPath);
        }
        public override System.nint RowsInSection(UITableView tableview, System.nint section)
        {
            return employees.Count;
        }
    }
}

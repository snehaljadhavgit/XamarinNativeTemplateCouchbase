using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Android.App;
using Android.Views;
using Android.Widget;

namespace XamarinNativeTemplate.Droid.Adapter
{
    public class RowListAdapter : BaseAdapter<Employee>
    {
        readonly MainActivity _context;

        public RowListAdapter(MainActivity pContext)
        {
            _context = pContext;
        }

        public override Employee this[int position] => _context.MainVm.AllEmployees[position];

        public override int Count => _context.MainVm.AllEmployees.Count;

        public override long GetItemId(int position) => position;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var employeeItem = _context.MainVm.AllEmployees[position];

            var view = convertView;

            RowListAdapterHolder rowListAdapterHolder = null;

            if (view != null)
                rowListAdapterHolder = view.Tag as RowListAdapterHolder;

            if (rowListAdapterHolder == null)
            {
                rowListAdapterHolder = new RowListAdapterHolder();

                var inflater = LayoutInflater.From(_context);

                view = inflater.Inflate(Resource.Layout.row_listView, parent, false);

                rowListAdapterHolder.EmployeeName = view.FindViewById<TextView>(Resource.Id.empNameTextView);

                rowListAdapterHolder.EmployeePhone = view.FindViewById<TextView>(Resource.Id.empPhoneTextView);
                rowListAdapterHolder.EmployeeDOB = view.FindViewById<TextView>(Resource.Id.empDOBTextView);
                rowListAdapterHolder.EmailId = view.FindViewById<TextView>(Resource.Id.empEmailTextView);

                view.Tag = rowListAdapterHolder;
            }

            rowListAdapterHolder.EmployeeName.Text = employeeItem.Name;
            rowListAdapterHolder.EmployeePhone.Text = employeeItem.Phone;
            rowListAdapterHolder.EmployeeDOB.Text = employeeItem.EmployeeDOB;
            rowListAdapterHolder.EmailId.Text = employeeItem.EmailId;

            return view;
        }
    }

    public class RowListAdapterHolder : Java.Lang.Object
    {
        public TextView EmployeeName { get; set; }
        public TextView EmailId { get; set; }
        public TextView EmployeePhone { get; set; }
        public TextView EmployeeDOB { get; set; }
    }
}
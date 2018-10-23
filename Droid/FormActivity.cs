
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinNativeTemplate.Droid
{
    [Activity(Label = "FormActivity")]
    public class FormActivity : Activity
    {
        MainViewModel MainVm
        {
            get
            {
                return MainApplication.Locator.MainVm;
            }
        }
        Button btnSave;
        TextView txtName, txtEmail, txtDOB, txtNumber;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout_form);


        }

        public void SetControls()
        {
            btnSave = (Button)FindViewById(Resource.Id.txtName);
            btnSave.Click+=BtnSave_Click;
        }

        void BtnSave_Click(object sender, EventArgs e)
        {
            MainVm.AddEmployee(txtName.Text, txtNumber.Text, txtEmail.Text, txtDOB.Text);
        }

    }
}

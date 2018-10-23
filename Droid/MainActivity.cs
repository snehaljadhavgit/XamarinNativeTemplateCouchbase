using Android.App;
using Android.Widget;
using Android.OS;
using XamarinNativeTemplate.Droid.Adapter;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Content.PM;

namespace XamarinNativeTemplate.Droid
{
    [Activity(Label = "MyTableViewActivity", MainLauncher = false, Theme = "@style/MyTheme",
              ScreenOrientation = ScreenOrientation.Portrait,
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        ListView listView;
        ImageView imgAdd;
        public  MainViewModel MainVm
        {
            get
            {
                return MainApplication.Locator.MainVm;
            }
        }

       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LayoutListActivity);
            SetControls();
            // Get our button from the layout resource,
            // and attach an event to it
            // Initializing listview
         
            MainVm.BuildEmployeeList();
     
                    //listView.ItemClick += OnListItemClick;
            listView.Adapter = new RowListAdapter(this);
            imgAdd.Click+=(sender, e) => {
                StartActivity(typeof(FormActivity));
            };
           
            //var toolbar = FindViewById<SupportToolbar>(Resource.Id.t);

            //FindViewById<TextView>(Resource.Id.toolbar_title).Text = "My Jobs";
        }

        private void SetControls(){
            listView = (ListView)FindViewById(Resource.Id.lstEmployee);
            imgAdd = (ImageView)FindViewById(Resource.Id.imgAdd);
        }
    }
}


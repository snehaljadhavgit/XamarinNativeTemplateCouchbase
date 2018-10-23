using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Newtonsoft.Json;
using Plugin.Connectivity;
using PropertyChanged;

namespace XamarinNativeTemplate
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : ViewModelBase
    {
        INavigationService navigationService { get => ServiceLocator.Current.GetInstance<INavigationService>(); }

        public ObservableCollection<Employee> AllEmployees { get; set; } = new ObservableCollection<Employee>();

        public MainViewModel()
        {
            
        }

        public async Task<bool> DownloadAllEmployeesData()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                UserDialogs.Instance.ShowLoading("");

                if (await DownloadManager.DownloadManagerInstance.DownloadAllEmployeesData())
                {
                    UserDialogs.Instance.HideLoading();

                    return true;
                }

                UserDialogs.Instance.HideLoading();

                //Show error alert to the user 
                var tryAgain = await UserDialogs.Instance.ConfirmAsync(StringsConstants.DOWNLOAD_EMPLOYEE_FAIL,
                                                                       StringsConstants.DOWNLOAD_ERROR,
                                                                       StringsConstants.TRY_AGAIN,
                                                                       StringsConstants.CANCEL, null);

                if (tryAgain)
                {
                  await  DownloadAllEmployeesData();
                }
            }
            else
            {
                UserDialogs.Instance.HideLoading();

                //Show no connectivity alert to the user 
                await UserDialogs.Instance.AlertAsync(StringsConstants.NO_INTERNET_CONNECTION,
                                                      StringsConstants.CONNECTIVITY_ERROR,
                                                      StringsConstants.OK, null);
            }

            return false;
        }

        public void BuildEmployeeList()
        {
            Stream dataStream;

            string employeeList = string.Empty;

            var assembly = typeof(MainViewModel).GetTypeInfo().Assembly;

            dataStream = assembly.GetManifestResourceStream(StringsConstants.EMPLOYEE_JSON_FILE);

            if (dataStream != null)
            {
                using (var reader = new StreamReader(dataStream))
                {
                    employeeList = reader.ReadToEnd();
                }
            }

            XamarinNativeTemplate.Locator.MainVm.AllEmployees = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(employeeList);

        }

        public void AddEmployee(string txtName, string txtPhoneNum, string txtEmailId, string txtDOB )
        {
            Employee emp = new Employee();
            emp.Name = txtName;
            emp.Phone = txtPhoneNum;
            emp.EmailId = txtEmailId;
            emp.DOB = txtDOB;
           
            int a =   XamarinNativeTemplate.Locator.MainVm.AllEmployees.Count + 1;
            emp.Id = a + 100;
            XamarinNativeTemplate.Locator.MainVm.AllEmployees.Add(emp);

        }
    }
}

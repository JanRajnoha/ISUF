using ISUF.Base.Classes;
using ISUF.UI.App;
using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Template10.Mvvm;
using Windows.ApplicationModel;
using Windows.UI.Xaml;

namespace ISUF.UI.ViewModel
{
    public class MainPageVMBase : ViewModelBase
    {
        public string NavigatedPage { get; set; }

        public Version CurrentVersion { get; set; }

        private bool showMinorUpdate = false;

        public bool ShowMinorUpdate
        {
            get { return showMinorUpdate; }
            set
            {
                showMinorUpdate = value;
                RaisePropertyChanged(nameof(showMinorUpdate));
            }
        }

        private List<AppModuleItem> appModules = new List<AppModuleItem>();

        public List<AppModuleItem> AppModules
        {
            get => appModules;
            set
            {
                appModules = value;
                RaisePropertyChanged(nameof(appModules));
            }
        }

        public ApplicationBase ApplicationClass { get; set; }

        public ICommand CloseMinor { get; set; }

        public MainPageVMBase(ApplicationBase applicationClass)
        {
            ApplicationClass = applicationClass;
            CloseMinor = new RelayCommand(() => ShowMinorUpdate = false);

            var v = Package.Current.Id.Version;

            CurrentVersion = new Version(v.Major, v.Minor, v.Build);

            Messenger = ApplicationClass.VMLocator.GetMessenger();
        }

        public void LoadAppModules()
        {
            AppModules = ApplicationClass.ModuleManager.GetUIModules();
        }
    }
}

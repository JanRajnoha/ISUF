using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Service;
using ISUF.UI.App;
using ISUF.UI.Controls;
using ISUF.UI.Design;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Services.NavigationService;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;


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
                PropertyChangedNotifier.NotifyPropertyChanged(ShowMinorUpdate);
            }
        }

        public ApplicationBase ApplicationClass { get; set; }

        public ICommand CloseMinor { get; set; }

        public MainPageVMBase()
        {
            ApplicationClass = ApplicationBase.Current;
            CloseMinor = new RelayCommand(() => ShowMinorUpdate = false);

            var v = Package.Current.Id.Version;

            CurrentVersion = new Version(v.Major, v.Minor, v.Build);

            Messenger = ApplicationClass.VMLocator.GetMessenger();
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            var OldVer = new Version(SettingsService.Instance.CurrentAppVersion);
            var CurVer = new Version(Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build);

            if (OldVer != CurVer)
            {
                SettingsService.Instance.CurrentAppVersion = $"{CurVer.Major}.{CurVer.Minor}.{CurVer.Build}";

                if (CurVer.Minor != OldVer.Minor || OldVer.Major == 0)
                {
                    ModalWindow.SetVisibility(true, new ReleaseNotes(), useAnimation: false);
                }
                else
                {
                    ShowMinorUpdate = true;
                }
            }

            //Messenger.Register<ShowModalActivationMsg>(ShowModal);

            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            //Messenger.UnRegister<ShowModalActivationMsg>(ShowModal);

            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        //public RelayCommand GoToFeedback() => new RelayCommand(async () =>
        //{
        //    var launcher = StoreServicesFeedbackLauncher.GetDefault();
        //    await launcher.LaunchAsync();
        //});

        public void GoToPage(Type destinationPage)
        {
            if (destinationPage != null)
                NavigationService.Navigate(destinationPage, infoOverride: new SuppressNavigationTransitionInfo());
        }
    }
}

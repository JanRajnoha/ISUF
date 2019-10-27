using ISUF.UI.XamlStyles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ISUF.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public abstract partial class MainPageBase : Page
    {
        protected Type viewModelType;

        public MainPageBase(Type viewModelType)
        {
            //LoadResources();

            InitializeComponent();
            this.viewModelType = viewModelType;
            Loading += MainPage_Loading;
        }

        protected abstract void MainPage_Loading(FrameworkElement sender, object args);
    }
}

using ISUF.Interface.UI;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Views
{
    public abstract class PageBase : Page, IPageBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public abstract void AddControls();
    }
}

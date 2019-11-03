using ISUF.Interface.UI;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Views
{
    public abstract class PageBase : Page, IPageBase, INotifyPropertyChanged
    {
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract void AddControls();
    }
}

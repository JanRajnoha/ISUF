using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;


namespace ISUF.UI.Controls
{
    public sealed class NavigationView : Windows.UI.Xaml.Controls.NavigationView
    {
        public static readonly DependencyProperty ShowAdProperty = DependencyProperty.Register("ShowAd", typeof(Visibility), typeof(NavigationView), new PropertyMetadata(false));

        private static void OnShowAdChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is Visibility)
            {
                var control = (NavigationView)d;
                control.ShowAd = (Visibility)e.NewValue;
            }
        }

        public static void SetShowAd(UIElement element, Visibility value)
        {
            element.SetValue(ShowAdProperty, value);
        }

        public static Visibility GetShowAd(UIElement element)
        {
            return (Visibility)element.GetValue(ShowAdProperty);
        }

        public Visibility ShowAd
        {
            get => (Visibility)GetValue(ShowAdProperty);
            set
            {
                SetValue(ShowAdProperty, value);

                NotifyPropertyChanged(nameof(ShowAdProperty));
            }
        }

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;

        public NavigationView()
        {
            DefaultStyleKey = typeof(NavigationView);
        }
    }
}

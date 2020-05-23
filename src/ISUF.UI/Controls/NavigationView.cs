using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;


namespace ISUF.UI.Controls
{
    public sealed class NavigationView : Windows.UI.Xaml.Controls.NavigationView, INotifyPropertyChanged
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

        /// <summary>
        /// Set visibility of ad
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value">Visibility</param>
        public static void SetShowAd(UIElement element, Visibility value)
        {
            element.SetValue(ShowAdProperty, value);
        }

        /// <summary>
        /// Get visibility of ad
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Ad visibility</returns>
        public static Visibility GetShowAd(UIElement element)
        {
            return (Visibility)element.GetValue(ShowAdProperty);
        }

        /// <summary>
        /// Visibility of ad
        /// </summary>
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

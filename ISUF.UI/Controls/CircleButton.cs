using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Controls
{
    public sealed class CircleButton : Button, INotifyPropertyChanged
    {
        public static DependencyProperty SwitchButtonDP = DependencyProperty.Register("SwitchButton", typeof(bool), typeof(CircleButton), new PropertyMetadata(false, OnSwitchButtonChanged));
        public static DependencyProperty IsOnDP = DependencyProperty.Register("IsOn", typeof(bool), typeof(CircleButton), new PropertyMetadata(false, OnIsOnChanged));
        public static DependencyProperty IsOnColorDP = DependencyProperty.Register("IsOnColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(123, 9, 201, 0)), OnIsOnColorChanged));
        public static DependencyProperty FillColorDP = DependencyProperty.Register("FillColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0, 64, 64, 64)), OnFillColorChanged));
        public static DependencyProperty FillHoverColorDP = DependencyProperty.Register("FillHoverColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 64, 64, 64)), OnFillHoverColorChanged));
        public static DependencyProperty FillPressedColorDP = DependencyProperty.Register("FillPressedColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(123, 9, 201, 0)), OnFillPressedColorChanged));
        public static DependencyProperty ContentColorDP = DependencyProperty.Register("ContentColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 0, 0, 0)), OnContentColorChanged));
        public static DependencyProperty ContentHoverColorDP = DependencyProperty.Register("ContentHoverColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)), OnContentHoverColorChanged));
        public static DependencyProperty ContentPressedColorDP = DependencyProperty.Register("ContentPressedColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 0, 0, 0)), OnContentPressedColorChanged));

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private static void OnSwitchButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is bool switchValue)
            {
                var control = (CircleButton)d;
                control.SwitchButton = switchValue;
            }
        }

        private static void OnIsOnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is bool newValue)
            {
                var control = (CircleButton)d;
                control.IsOn = newValue;
            }
        }

        private static void OnIsOnColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.IsOnColor = colorValue;
            }
        }

        private static void OnFillColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.FillColor = colorValue;
            }
        }

        private static void OnFillHoverColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.FillHoverColor = colorValue;
            }
        }

        private static void OnFillPressedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.FillPressedColor = colorValue;
            }
        }

        private static void OnContentColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.ContentColor = colorValue;
            }
        }

        private static void OnContentPressedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.ContentPressedColor = colorValue;
            }
        }

        private static void OnContentHoverColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is SolidColorBrush colorValue)
            {
                var control = (CircleButton)d;
                control.ContentHoverColor = colorValue;
            }
        }

        public bool SwitchButton
        {
            get
            {
                return (bool)GetValue(SwitchButtonDP);
            }
            set
            {
                SetValue(SwitchButtonDP, value);
                NotifyPropertyChanged(nameof(SwitchButton));
            }
        }

        public bool IsOn
        {
            get
            {
                return (bool)GetValue(IsOnDP);
            }
            set
            {
                SetValue(IsOnDP, value);

                if (SwitchButton)
                    currentColor.Color = IsOn ? IsOnColor.Color : normalContentColor.Color;

                NotifyPropertyChanged(nameof(IsOn));
                NotifyPropertyChanged(nameof(currentColor));
            }
        }

        public SolidColorBrush IsOnColor
        {
            get
            {
                return (SolidColorBrush)GetValue(IsOnColorDP);
            }
            set
            {
                SetValue(IsOnColorDP, value);
                NotifyPropertyChanged(nameof(IsOnColor));
            }
        }

        public SolidColorBrush FillColor
        {
            get
            {
                return (SolidColorBrush)GetValue(FillColorDP);
            }
            set
            {
                SetValue(FillColorDP, value);

                normalContentColor.Color = FillColor.Color;

                if (SwitchButton)
                    currentColor.Color = IsOn ? IsOnColor.Color : normalContentColor.Color;
                else
                    currentColor.Color = normalContentColor.Color;

                NotifyPropertyChanged(nameof(FillColor));
            }
        }

        public SolidColorBrush FillHoverColor
        {
            get
            {
                return (SolidColorBrush)GetValue(FillHoverColorDP);
            }
            set
            {
                SetValue(FillHoverColorDP, value);
                NotifyPropertyChanged(nameof(FillHoverColor));
            }
        }

        public SolidColorBrush FillPressedColor
        {
            get
            {
                return (SolidColorBrush)GetValue(FillPressedColorDP);
            }
            set
            {
                SetValue(FillPressedColorDP, value);
                NotifyPropertyChanged(nameof(FillPressedColor));
            }
        }

        public SolidColorBrush ContentColor
        {
            get
            {
                return (SolidColorBrush)GetValue(ContentColorDP);
            }
            set
            {
                SetValue(ContentColorDP, value);
                NotifyPropertyChanged(nameof(ContentColor));
            }
        }

        public SolidColorBrush ContentHoverColor
        {
            get
            {
                return (SolidColorBrush)GetValue(ContentHoverColorDP);
            }
            set
            {
                SetValue(ContentHoverColorDP, value);
                NotifyPropertyChanged(nameof(ContentHoverColor));
            }
        }

        public SolidColorBrush ContentPressedColor
        {
            get
            {
                return (SolidColorBrush)GetValue(ContentPressedColorDP);
            }
            set
            {
                SetValue(ContentPressedColorDP, value);
                NotifyPropertyChanged(nameof(ContentPressedColor));
            }
        }

        private SolidColorBrush normalContentColor { get; set; } = new SolidColorBrush();

        private SolidColorBrush privateCurrentColor = new SolidColorBrush();
        public SolidColorBrush currentColor
        {
            get
            {
                return privateCurrentColor;
            }
            private set
            {
                privateCurrentColor.Color = value.Color;
                NotifyPropertyChanged(nameof(currentColor));
            }
        }

        public CircleButton()
        {
            DefaultStyleKey = typeof(CircleButton);

            normalContentColor.Color = FillColor.Color;

            if (SwitchButton)
                currentColor.Color = IsOn ? IsOnColor.Color : normalContentColor.Color;
            else
                currentColor.Color = normalContentColor.Color;

            NotifyPropertyChanged(nameof(currentColor));

            Click += ChangeColor;
        }

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            if (SwitchButton)
            {
                IsOn = !IsOn;
                currentColor.Color = IsOn ? IsOnColor.Color : normalContentColor.Color;

                NotifyPropertyChanged(nameof(currentColor));
            }
        }
    }
}

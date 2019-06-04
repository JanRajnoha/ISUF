using ISUF.Base.Classes;
using ISUF.Base.Messages;
using System;
using System.Diagnostics;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace ISUF.UI.Controls
{
    /// <summary>
    /// In App Notification defines a control to show local notification in the app.
    /// </summary>
    [TemplateVisualState(Name = StateContentVisible, GroupName = GroupContent)]
    [TemplateVisualState(Name = StateContentCollapsed, GroupName = GroupContent)]
    [TemplatePart(Name = DismissButtonPart, Type = typeof(Button))]
    public class InAppNotifyMVVM : ContentControl
    {
        /// <summary>
        /// Key of the VisualStateGroup that show/dismiss content
        /// </summary>
        private const string GroupContent = "State";

        /// <summary>
        /// Key of the VisualState when content is showed
        /// </summary>
        private const string StateContentVisible = "Visible";

        /// <summary>
        /// Key of the VisualState when content is dismissed
        /// </summary>
        private const string StateContentCollapsed = "Collapsed";

        /// <summary>
        /// Key of the UI Element that dismiss the control
        /// </summary>
        private const string DismissButtonPart = "PART_DismissButton";

        /// <summary>
        /// Identifies the <see cref="ShowDismissButton"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ShowDismissButtonProperty =
            DependencyProperty.Register(nameof(ShowDismissButton), typeof(bool), typeof(InAppNotifyMVVM), new PropertyMetadata(true, OnShowDismissButtonChanged));

        /// <summary>
        /// Trigger dependency property for showing in app notifications
        /// </summary>
        public static readonly DependencyProperty MessengerProperty =
            DependencyProperty.Register(nameof(Mess), typeof(Messenger), typeof(InAppNotifyMVVM), new PropertyMetadata(true, OnMessengerChanged));

        private DispatcherTimer _timer = new DispatcherTimer();
        private Button _dismissButton;

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppNotification"/> class.
        /// </summary>
        public InAppNotifyMVVM()
        {
            DefaultStyleKey = typeof(InAppNotifyMVVM);

            _timer.Tick += (sender, e) =>
            {
                Dismiss();
            };
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show the Dismiss button of the control.
        /// </summary>
        public bool ShowDismissButton
        {
            get { return (bool)GetValue(ShowDismissButtonProperty); }
            set { SetValue(ShowDismissButtonProperty, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show the Dismiss button of the control.
        /// </summary>
        public Messenger Mess
        {
            get { return (Messenger)GetValue(MessengerProperty); }
            set
            {
                SetValue(MessengerProperty, value);
                CreateRegistrations();
            }
        }

        private void CreateRegistrations()
        {
            Mess.Register<ShowNotificationMsg>(ShowNotification);
        }

        private static void OnShowDismissButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var inApNotification = d as InAppNotifyMVVM;

            bool showDismissButton = (bool)e.NewValue;

            if (inApNotification._dismissButton != null)
            {
                inApNotification._dismissButton.Visibility = showDismissButton ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private static void OnMessengerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var inAppNotification = d as InAppNotifyMVVM;

            inAppNotification.Mess = (Messenger)e.NewValue;
        }

        private async void ShowNotification(ShowNotificationMsg obj)
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Dismiss();

                if (/*Name == obj.ModuleName || */true)
                {
                    Show(obj.Text, obj.Duration);
                }
            });
        }

        /// <summary>
        /// Event raised when the notification is dismissed
        /// </summary>
        public event EventHandler Dismissed;

        private void DismissButton_Click(object sender, RoutedEventArgs e)
        {
            Dismiss();
        }

        /// <inheritdoc />
        protected override void OnApplyTemplate()
        {
            if (_dismissButton != null)
            {
                _dismissButton.Click -= DismissButton_Click;
            }

            _dismissButton = (Button)GetTemplateChild(DismissButtonPart);

            if (_dismissButton != null)
            {
                _dismissButton.Visibility = ShowDismissButton ? Visibility.Visible : Visibility.Collapsed;
                _dismissButton.Click += DismissButton_Click;
            }

            if (Visibility == Visibility.Visible)
            {
                VisualStateManager.GoToState(this, StateContentVisible, true);
            }
            else
            {
                VisualStateManager.GoToState(this, StateContentCollapsed, true);
            }

            base.OnApplyTemplate();
        }

        /// <summary>
        /// Show notification using the current template
        /// </summary>
        /// <param name="duration">Displayed duration of the notification in ms (less or equal 0 means infinite duration)</param>
        public void Show(int duration = 0)
        {
            _timer.Stop();

            Visibility = Visibility.Visible;
            VisualStateManager.GoToState(this, StateContentVisible, true);

            if (duration > 0)
            {
                _timer.Interval = TimeSpan.FromMilliseconds(duration);
                _timer.Start();
            }
        }

        /// <summary>
        /// Show notification using text as the content of the notification
        /// </summary>
        /// <param name="text">Text used as the content of the notification</param>
        /// <param name="duration">Displayed duration of the notification in ms (less or equal 0 means infinite duration)</param>
        public void Show(string text, int duration = 0)
        {
            ContentTemplate = null;
            Content = text;
            Show(duration);
        }

        /// <summary>
        /// Show notification using UIElement as the content of the notification
        /// </summary>
        /// <param name="element">UIElement used as the content of the notification</param>
        /// <param name="duration">Displayed duration of the notification in ms (less or equal 0 means infinite duration)</param>
        public void Show(UIElement element, int duration = 0)
        {
            ContentTemplate = null;
            Content = element;
            Show(duration);
        }

        /// <summary>
        /// Show notification using DataTemplate as the content of the notification
        /// </summary>
        /// <param name="dataTemplate">DataTemplate used as the content of the notification</param>
        /// <param name="duration">Displayed duration of the notification in ms (less or equal 0 means infinite duration)</param>
        public void Show(DataTemplate dataTemplate, int duration = 0)
        {
            ContentTemplate = dataTemplate;
            Content = null;
            Show(duration);
        }

        /// <summary>
        /// Dismiss the notification
        /// </summary>
        public void Dismiss()
        {
            try
            {
                if (Visibility == Visibility.Visible)
                {
                    VisualStateManager.GoToState(this, StateContentCollapsed, true);
                    Dismissed?.Invoke(this, System.EventArgs.Empty);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
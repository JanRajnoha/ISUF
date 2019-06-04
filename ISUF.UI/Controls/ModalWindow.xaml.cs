using Microsoft.Toolkit.Uwp.UI.Animations;
using Template10.Common;
using Template10.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ISUF.UI.Controls
{
    public sealed partial class ModalWindow : UserControl
    {
        public static FrameworkElement ModalContent { get; set; }
        public static bool ShowDefaultButton { get; set; }

        public ModalWindow()
        {
            InitializeComponent();
        }

        public ModalWindow(FrameworkElement modalContent) : this()
        {
            if (modalContent != null)
            {
                Content.Content = modalContent;
            }
        }

        public bool IsShowed
        {
            get { return (bool)GetValue(IsShowedProperty); }
            set { SetValue(IsShowedProperty, value); }
        }
        public static readonly DependencyProperty IsShowedProperty =
            DependencyProperty.Register(nameof(IsShowed), typeof(bool), typeof(ModalWindow), new PropertyMetadata(false));

        /// <summary>
        /// Set visibility of Release Notes Screen
        /// </summary>
        /// <param name="showed">Visibility bool</param>
        /// <param name="modalContent">Content of ModalWindow</param>
        /// <param name="showDefaultButton">use default buttons</param>
        /// <param name="useAnimation">Enable or disable animations</param>
        public static void SetVisibility(bool showed, FrameworkElement modalContent = null, bool showDefaultButton = true, bool useAnimation = true)
        {
            {
                ModalContent = modalContent;
                ShowDefaultButton = showDefaultButton;
            }

            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;

                if (!(modal.ModalContent is ModalWindow view))
                    modal.ModalContent = view = new ModalWindow();

                if (showed)
                    if (ModalContent != null)
                        modal.ModalContent = view = new ModalWindow(ModalContent);
                    else
                        modal.ModalContent = view = new ModalWindow();
                //else
                //    if (view.Content.Content == null)
                //    modal.ModalContent = view = new ModalWindow(ModalContent);


                if (!showed)
                {
                    view.Content.Visibility = Visibility.Collapsed;
                    view.GotIt.Visibility = Visibility.Collapsed;

                    var BlurAnim = view.BlurLayer.Blur(0, 500);
                    BlurAnim.Completed += CloseBlurAnim_Completed;
                    BlurAnim.Start();
                }
                else
                {
                    view.Content.Visibility = Visibility.Visible;

                    if (ShowDefaultButton)
                    {
                        view.DefaultButtonRow.Height = GridLength.Auto;
                        view.GotIt.Visibility = Visibility.Visible;
                    }
                    else
                        view.DefaultButtonRow.Height = new GridLength(0);

                    modal.IsModal = view.IsShowed = showed;

                    if (useAnimation)
                    {
                        view.GotIt.IsEnabled = false;

                        var BlurAnim = view.BlurLayer.Blur(5, 500);
                        BlurAnim.Completed += OpenBlurAnim_Completed;
                        BlurAnim.Start();
                    }
                    else
                        view.BlurLayer.Blur(8, 1).Start();
                }

            });
        }

        /// <summary>
        /// Opening completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OpenBlurAnim_Completed(object sender, AnimationSetCompletedEventArgs e)
        {
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;

                if (!(modal.ModalContent is ModalWindow view))
                    modal.ModalContent = view = new ModalWindow(ModalContent);

                view.GotIt.IsEnabled = true;

            });
        }

        /// <summary>
        /// Closing completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CloseBlurAnim_Completed(object sender, AnimationSetCompletedEventArgs e)
        {
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;

                if (!(modal.ModalContent is ModalWindow view))
                    modal.ModalContent = view = new ModalWindow(null);

                modal.IsModal = view.IsShowed = false;

            });
        }

        /// <summary>
        /// Close Release Notes Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetVisibility(false);
        }
    }
}

using ISUF.Base.Enum;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using Template10.Common;
using Template10.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ISUF.UI.Controls
{
    /// <summary>
    /// Modal window
    /// </summary>
    public partial class ModalWindow : UserControl
    {
        private static object modalContent;
        private static bool showButtons;
        private static MessageDialogButtons showedButtons;
        private static Action<MessageDialogResult> modalResult;

        /// <summary>
        /// Init modla window
        /// </summary>
        public ModalWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Init modal window with content
        /// </summary>
        /// <param name="modalContent">Content of modal window</param>
        public ModalWindow(object modalContent) : this()
        {
            if (modalContent != null)
            {
                Content.Content = modalContent;
            }
        }

        /// <summary>
        /// Is showed window
        /// </summary>
        public bool IsShowed
        {
            get { return (bool)GetValue(IsShowedProperty); }
            set { SetValue(IsShowedProperty, value); }
        }

        public static readonly DependencyProperty IsShowedProperty =
            DependencyProperty.Register(nameof(IsShowed), typeof(bool), typeof(ModalWindow), new PropertyMetadata(false));

        /// <summary>
        /// Show modal window
        /// </summary>
        /// <param name="modalResult">Result of showing</param>
        /// <param name="modalContent">Content of window</param>
        /// <param name="showButtons">Show buttons on modal window</param>
        /// <param name="showedButtons">Buttons on modal window</param>
        /// <param name="useDesignAnimation">Use animation</param>
        public static void ShowModal(Action<MessageDialogResult> modalResult, object modalContent = null, bool showButtons = true, MessageDialogButtons showedButtons = MessageDialogButtons.Ok, bool useDesignAnimation = true)
        {
            SetVisibility(true, modalContent, showButtons, showedButtons, useDesignAnimation);
            ModalWindow.modalResult = modalResult;
        }

        protected static void CloseModal(MessageDialogResult result)
        {
            SetVisibility(false);
            modalResult?.Invoke(result);
        }

        protected virtual void Ok_Click(object sender, RoutedEventArgs e)
        {
            switch (showedButtons)
            {
                case MessageDialogButtons.Ok:
                case MessageDialogButtons.OkCancel:
                    CloseModal(MessageDialogResult.Ok);
                    break;

                case MessageDialogButtons.YesNo:
                    CloseModal(MessageDialogResult.Yes);
                    break;

                case MessageDialogButtons.AbortRetryIgnore:
                    CloseModal(MessageDialogResult.Abort);
                    break;

                default:
                    throw new Base.Exceptions.NotImplementedException($"Combination {showedButtons} is not supported yet");
            }
        }

        protected virtual void Cancel_Click(object sender, RoutedEventArgs e)
        {
            switch (showedButtons)
            {
                case MessageDialogButtons.Ok:
                    break;

                case MessageDialogButtons.OkCancel:
                    CloseModal(MessageDialogResult.Cancel);
                    break;

                case MessageDialogButtons.YesNo:
                    CloseModal(MessageDialogResult.Yes);
                    break;

                case MessageDialogButtons.AbortRetryIgnore:
                    CloseModal(MessageDialogResult.Abort);
                    break;

                default:
                    throw new Base.Exceptions.NotImplementedException($"Combination {showedButtons} is not supported yet");
            }
        }

        protected virtual void Ignore_Click(object sender, RoutedEventArgs e)
        {
            switch (showedButtons)
            {
                case MessageDialogButtons.Ok:
                case MessageDialogButtons.OkCancel:
                case MessageDialogButtons.YesNo:
                    break;

                case MessageDialogButtons.AbortRetryIgnore:
                    CloseModal(MessageDialogResult.Abort);
                    break;

                default:
                    throw new Base.Exceptions.NotImplementedException($"Combination {showedButtons} is not supported yet");
            }
        }

        /// <summary>
        /// Set visibility of Modal window
        /// </summary>
        /// <param name="showed">Visibility bool</param>
        /// <param name="modalContent">Content of ModalWindow</param>
        /// <param name="showButtons">use default buttons</param>
        /// <param name="useDesignAnimation">Enable or disable animations</param>
        protected static void SetVisibility(bool showed, object modalContent = null, bool showButtons = true, MessageDialogButtons showedButtons = MessageDialogButtons.Ok, bool useDesignAnimation = true)
        {
            ModalWindow.modalContent = modalContent;
            ModalWindow.showButtons = showButtons;
            ModalWindow.showedButtons = showedButtons;

            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;

                if (!(modal.ModalContent is ModalWindow view))
                    modal.ModalContent = view = new ModalWindow();

                if (showed)
                {
                    if (ModalWindow.modalContent != null)
                        modal.ModalContent = view = new ModalWindow(ModalWindow.modalContent);
                    else
                        modal.ModalContent = view = new ModalWindow();

                    view.Content.Visibility = Visibility.Visible;

                    if (ModalWindow.showButtons)
                    {
                        view.ButtonRow.Height = GridLength.Auto;

                        switch (ModalWindow.showedButtons)
                        {
                            case MessageDialogButtons.Ok:
                                view.Ok.Visibility = Visibility.Visible;
                                view.Cancel.Visibility = Visibility.Collapsed;
                                view.Ignore.Visibility = Visibility.Collapsed;
                                break;

                            case MessageDialogButtons.OkCancel:
                                view.Ok.Visibility = Visibility.Visible;
                                view.Cancel.Visibility = Visibility.Visible;
                                view.Ignore.Visibility = Visibility.Collapsed;
                                break;

                            case MessageDialogButtons.YesNo:
                                view.Ok.Visibility = Visibility.Visible;
                                view.Cancel.Visibility = Visibility.Visible;
                                view.Ignore.Visibility = Visibility.Collapsed;

                                view.Ok.Content = "Yes";
                                view.Ignore.Content = "No";
                                break;

                            case MessageDialogButtons.AbortRetryIgnore:
                                view.Ok.Visibility = Visibility.Visible;
                                view.Cancel.Visibility = Visibility.Visible;
                                view.Ignore.Visibility = Visibility.Visible;

                                view.Ok.Content = "Abort";
                                view.Ignore.Content = "Retry";
                                break;

                            default:
                                throw new Base.Exceptions.NotImplementedException($"Combination {ModalWindow.showedButtons} is not supported yet");
                        }
                    }
                    else
                        view.ButtonRow.Height = new GridLength(0);

                    modal.IsModal = view.IsShowed = showed;

                    if (useDesignAnimation)
                    {
                        view.Ok.IsEnabled = false;
                        view.Cancel.IsEnabled = false;
                        view.Ignore.IsEnabled = false;

                        var BlurAnim = view.BlurLayer.Blur(5, 500);
                        BlurAnim.Completed += OpenBlurAnim_Completed;
                        BlurAnim.Start();
                    }
                    else
                        view.BlurLayer.Blur(8, 1).Start();
                }
                else
                {
                    view.Content.Visibility = Visibility.Collapsed;
                    view.Ok.Visibility = Visibility.Collapsed;
                    view.Cancel.Visibility = Visibility.Collapsed;
                    view.Ignore.Visibility = Visibility.Collapsed;

                    var BlurAnim = view.BlurLayer.Blur(0, 500);
                    BlurAnim.Completed += CloseBlurAnim_Completed;
                    BlurAnim.Start();
                }

            });
        }

        /// <summary>
        /// Opening completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected static void OpenBlurAnim_Completed(object sender, AnimationSetCompletedEventArgs e)
        {
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;

                if (!(modal.ModalContent is ModalWindow view))
                    modal.ModalContent = view = new ModalWindow(modalContent);

                view.Ok.IsEnabled = true;
                view.Cancel.IsEnabled = true;
                view.Ignore.IsEnabled = true;
            });
        }

        /// <summary>
        /// Closing completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected static void CloseBlurAnim_Completed(object sender, AnimationSetCompletedEventArgs e)
        {
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;

                if (!(modal.ModalContent is ModalWindow view))
                    modal.ModalContent = view = new ModalWindow(null);

                modal.IsModal = view.IsShowed = false;

            });
        }
    }
}

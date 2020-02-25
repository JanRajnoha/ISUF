﻿using ISUF.Base.Enum;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using Template10.Common;
using Template10.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ISUF.UI.Controls
{
    public partial class ModalWindow : UserControl
    {
        private static object modalContent;
        private static bool showButtons;
        private static MessageDialogButtons showedButtons;
        private static Action<MessageDialogResult> modalResult;

        public ModalWindow()
        {
            InitializeComponent();
        }

        public ModalWindow(object modalContent) : this()
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

        protected void Ok_Click(object sender, RoutedEventArgs e)
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

        protected void Cancel_Click(object sender, RoutedEventArgs e)
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

        protected void Ignore_Click(object sender, RoutedEventArgs e)
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

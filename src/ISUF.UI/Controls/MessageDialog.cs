﻿using ISUF.Base.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ISUF.UI.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class MessageDialog
    {
        public Windows.UI.Popups.MessageDialog PopupMessageDialog = new Windows.UI.Popups.MessageDialog("");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="header"></param>
        /// <param name="messageDialogButtons"></param>
        public MessageDialog(string description, string header = "", MessageDialogButtons messageDialogButtons = MessageDialogButtons.Ok)
        {
            PopupMessageDialog = new Windows.UI.Popups.MessageDialog(description, header);

            switch (messageDialogButtons)
            {
                case MessageDialogButtons.Ok:
                    PopupMessageDialog.Commands.Add(new UICommand("Ok", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Ok));

                    PopupMessageDialog.DefaultCommandIndex = 1;
                    PopupMessageDialog.CancelCommandIndex = 1;
                    break;

                case MessageDialogButtons.OkCancel:
                    PopupMessageDialog.Commands.Add(new UICommand("Ok", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Ok));
                    PopupMessageDialog.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Cancel));

                    PopupMessageDialog.DefaultCommandIndex = 0;
                    PopupMessageDialog.CancelCommandIndex = 1;
                    break;

                case MessageDialogButtons.YesNo:
                    PopupMessageDialog.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Yes));
                    PopupMessageDialog.Commands.Add(new UICommand("No", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.No));

                    PopupMessageDialog.DefaultCommandIndex = 0;
                    PopupMessageDialog.CancelCommandIndex = 1;
                    break;

                case MessageDialogButtons.AbortRetryIgnore:
                    PopupMessageDialog.Commands.Add(new UICommand("Abort", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Abort));
                    PopupMessageDialog.Commands.Add(new UICommand("Retry", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Retry));
                    PopupMessageDialog.Commands.Add(new UICommand("Ignore", new UICommandInvokedHandler(EscapeFce), MessageDialogResult.Ignore));

                    PopupMessageDialog.DefaultCommandIndex = 0;
                    PopupMessageDialog.CancelCommandIndex = 1;
                    break;

                default:
                    throw new Base.Exceptions.NotImplementedException($"Combination {messageDialogButtons} is not supported yet");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="clearButtons"></param>
        /// <param name="defaultCommand"></param>
        /// <param name="cancelCommand"></param>
        public void SetCustomButtons(List<UICommand> commands, bool clearButtons = true, uint defaultCommand = 0, uint cancelCommand = 1)
        {
            if (clearButtons)
                PopupMessageDialog.Commands.Clear();

            if (commands.Count != 0)
                foreach (var command in commands)
                    PopupMessageDialog.Commands.Add(command);

            PopupMessageDialog.DefaultCommandIndex = defaultCommand;

            PopupMessageDialog.CancelCommandIndex = cancelCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        private void EscapeFce(IUICommand command)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<MessageDialogResult> ShowAsync()
        {
            var res = (await PopupMessageDialog.ShowAsync());

            if (res.Id == null)
                return MessageDialogResult.Ok;
            else
                return (MessageDialogResult)res.Id;
        }
    }
}

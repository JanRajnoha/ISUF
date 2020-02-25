using ISUF.Base.Classes;
using ISUF.Base.Enum;
using ISUF.UI.App;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Controls
{
    public class LinkedTableSelector : ModalWindow
    {
        private object selectorContent;
        private IList<int> slectedIds;
        private MessageDialogResult selectorResult;
        private Messenger messenger;

        public LinkedTableSelector()
        {
            messenger = ApplicationBase.Current.VMLocator.GetMessenger();
        }

        public void ShowSelector(Action<MessageDialogResult, IList<int>> selectorResult, bool useDesignAnimation = true)
        {
            var selectorContent = CreateSelectorContent();

            SetVisibility(true, selectorContent, true, MessageDialogButtons.OkCancel, useDesignAnimation);
        }

        private object CreateSelectorContent()
        {
            return null;
        }
    }
}

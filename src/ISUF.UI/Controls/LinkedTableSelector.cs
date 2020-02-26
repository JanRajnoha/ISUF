using ISUF.Base.Classes;
using ISUF.Base.Enum;
using ISUF.UI.App;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ISUF.UI.Controls
{
    public class LinkedTableSelector : ModalWindow
    {
        private ListView selectorContent;
        private MessageDialogResult selectorResult;
        private Messenger messenger;
        private UIModule uiModule;
        private Action<MessageDialogResult, IList<object>> selectorResultFunction;

        public LinkedTableSelector(UIModule uiModule)
        {
            messenger = ApplicationBase.Current.VMLocator.GetMessenger();
            this.uiModule = uiModule;
        }

        public void ShowSelector(Action<MessageDialogResult, IList<object>> selectorResult, bool useDesignAnimation = true)
        {
            selectorContent = CreateSelectorContent();
            FillContent(selectorContent);

            selectorResultFunction = selectorResult;

            ShowModal(CloseSelector, selectorContent, true, MessageDialogButtons.OkCancel, useDesignAnimation);

            var xx = selectorContent.Focus(FocusState.Programmatic);
        }

        private void CloseSelector(MessageDialogResult obj)
        {
            selectorResultFunction.Invoke(obj, selectorContent.SelectedItems);
        }

        private void FillContent(ListView selectorContent)
        {
            MethodInfo method = uiModule.GetType().GetMethod("GetAllItems");
            MethodInfo genericMethod = method.MakeGenericMethod(uiModule.ModuleItemType);

            selectorContent.ItemsSource = genericMethod.Invoke(uiModule, null);
        }

        private ListView CreateSelectorContent()
        {
            return new ListView()
            {

            };
        }
    }
}

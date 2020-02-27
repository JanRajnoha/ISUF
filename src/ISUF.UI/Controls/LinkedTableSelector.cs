using ISUF.Base.Attributes;
using ISUF.Base.Classes;
using ISUF.Base.Enum;
using ISUF.Base.Modules;
using ISUF.Storage.Modules;
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
        private Messenger messenger;
        private PropertyAnalyze controlData;
        private Action<MessageDialogResult, IList<object>> selectorResultFunction;
        private LinkedTableAttribute linkedTableAttribute;

        public LinkedTableSelector(PropertyAnalyze controlData)
        {
            messenger = ApplicationBase.Current.VMLocator.GetMessenger();
            this.controlData = controlData;

            linkedTableAttribute = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;
        }

        public void ShowSelector(Action<MessageDialogResult, IList<object>> selectorResult, bool useDesignAnimation = true)
        {
            selectorContent = CreateSelectorContent();
            FillContent(selectorContent);

            selectorResultFunction = selectorResult;

            ShowModal(CloseSelector, selectorContent, true, MessageDialogButtons.OkCancel, useDesignAnimation);
        }

        private void CloseSelector(MessageDialogResult obj)
        {
            selectorResultFunction.Invoke(obj, selectorContent.SelectedItems);
        }

        private void FillContent(ListView selectorContent)
        {
            MethodInfo method = typeof(StorageModule).GetMethod("GetAllItems");

            StorageModule linkedModule = GetLinkedUIModule();
            MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

            selectorContent.ItemsSource = genericMethod.Invoke(linkedModule, null);
        }

        private StorageModule GetLinkedUIModule()
        {
            return ApplicationBase.Current.ModuleManager.GetModule(linkedTableAttribute.LinkedTableType) as StorageModule;
        }

        private ListView CreateSelectorContent()
        {
            ListViewSelectionMode selectionMode;

            if (linkedTableAttribute.LinkedTableRelation == LinkedTableRelation.One)
                selectionMode = ListViewSelectionMode.Single;
            else
                selectionMode = ListViewSelectionMode.Multiple;

            return new ListView()
            {
                SelectionMode = selectionMode
            };
        }
    }
}

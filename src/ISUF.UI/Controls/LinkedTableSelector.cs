using ISUF.Base.Attributes;
using ISUF.Base.Classes;
using ISUF.Base.Enum;
using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.Storage.Modules;
using ISUF.UI.App;
using ISUF.UI.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Action<MessageDialogResult, List<object>> selectorResultFunction;
        private LinkedTableAttribute linkedTableAttribute;

        public LinkedTableSelector(PropertyAnalyze controlData)
        {
            messenger = ApplicationBase.Current.VMLocator.GetMessenger();
            this.controlData = controlData;

            linkedTableAttribute = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;
        }

        public void ShowSelector(Action<MessageDialogResult, List<object>> selectorResult, List<int> selectedIds = null, bool useDesignAnimation = true)
        {
            selectorContent = CreateSelectorContent();
            FillContent(selectorContent, selectedIds);

            selectorResultFunction = selectorResult;

            ShowModal(CloseSelector, selectorContent, true, MessageDialogButtons.OkCancel, useDesignAnimation);
        }

        private void CloseSelector(MessageDialogResult obj)
        {
            selectorResultFunction.Invoke(obj, selectorContent.SelectedItems.ToList());
        }

        private void FillContent(ListView selectorContent, List<int> selectedIds)
        {
            MethodInfo method = typeof(StorageModule).GetMethod("GetAllItems");

            StorageModule linkedModule = GetLinkedUIModule();
            MethodInfo genericMethod = method.MakeGenericMethod(linkedModule.ModuleItemType);

            var allItems = Convert.ChangeType(genericMethod.Invoke(linkedModule, null), genericMethod.ReturnType) as IReadOnlyList<AtomicItem>;

            if (selectedIds != null && selectedIds.Count != 0)
                allItems = allItems.Where(x => !selectedIds.Contains(x.Id)).ToList();

            selectorContent.ItemsSource = allItems;
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

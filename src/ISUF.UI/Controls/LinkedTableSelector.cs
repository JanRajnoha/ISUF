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
    /// <summary>
    /// Linked table selector
    /// </summary>
    public class LinkedTableSelector : ModalWindow
    {
        readonly LinkedTableAttribute linkedTableAttribute;

        private ListView selectorContent;
        private Action<MessageDialogResult, List<object>> selectorResultFunction;

        /// <summary>
        /// Init linked table selector
        /// </summary>
        /// <param name="controlData">Control data</param>
        public LinkedTableSelector(PropertyAnalyze controlData)
        {
            linkedTableAttribute = controlData.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;
        }

        /// <summary>
        /// Show selector
        /// </summary>
        /// <param name="selectorResult">Result of selection</param>
        /// <param name="selectedIds">Selected IDs</param>
        /// <param name="useDesignAnimation">Use animation</param>
        public void ShowSelector(Action<MessageDialogResult, List<object>> selectorResult, List<int> selectedIds = null, bool useDesignAnimation = true)
        {
            selectorContent = CreateSelectorContent();
            FillContent(selectorContent, selectedIds);

            selectorResultFunction = selectorResult;

            ShowModal(CloseSelector, selectorContent, true, MessageDialogButtons.OkCancel, useDesignAnimation);
        }

        /// <summary>
        /// Close selector
        /// </summary>
        /// <param name="obj">Message dialog result</param>
        private void CloseSelector(MessageDialogResult obj)
        {
            selectorResultFunction.Invoke(obj, selectorContent.SelectedItems.ToList());
        }

        /// <summary>
        /// Fill selector
        /// </summary>
        /// <param name="selectorContent">Content</param>
        /// <param name="selectedIds">Selected IDs</param>
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

        /// <summary>
        /// Get linked module
        /// </summary>
        /// <returns>Linked module</returns>
        private StorageModule GetLinkedUIModule()
        {
            return ApplicationBase.Current.ModuleManager.GetModule(linkedTableAttribute.LinkedTableType) as StorageModule;
        }

        /// <summary>
        /// Create selector content
        /// </summary>
        /// <returns>List view with content</returns>
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

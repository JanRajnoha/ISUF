using ISUF.Base.Template;
using ISUF.UI.App;
using ISUF.UI.Modules;
using ISUF.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Views
{
    public class ModulePageBase : PageBase
    {
        UIModule uiModule;

        public ModulePageBase(Type viewModelType, params object[] viewModelArgs) : base(viewModelType, viewModelArgs)
        {
            uiModule = (UIModule)ApplicationBase.Current.ModuleManager.GetModules().Where(x => x is UIModule).FirstOrDefault(x => ((UIModule)x).ModulePage == GetType());
            asd();
        }

        protected override void CreateViewModel()
        {
            var vmArgs = viewModelArgs.ToList();
            vmArgs.Insert(0, GetType());
            viewModelArgs = vmArgs.ToArray();

            base.CreateViewModel();
        }

        public override void AddControls()
        {
            var container = AddContainer();
            AddCommandBar(container);
        }

        public virtual Panel AddContainer()
        {
            RelativePanel Container = new RelativePanel
            {
                Name = "Container",
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = ApplicationBase.Current.Resources["PageHeader"] as Brush
            };
            Content = Container;

            return Container;
        }

        public virtual void AddCommandBar(Panel container)
        {
            CommandBar PageHeader = new CommandBar
            {
                Name = "PageHeader",
                Style = ApplicationBase.Current.Resources["PageHeader"] as Style,
                Margin = new Thickness(0, 32, 0, 0)
            };

            AppBarButton AddItem = new AppBarButton()
            {
                Label = "Add " + (DataContext as ViewModelBase).GetPropertyValue("ModuleTitle"),
                Icon = new SymbolIcon(Symbol.Add),
                IsEnabled = true,
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Command = null
            };

            ToolTipService.SetToolTip(AddItem, "Add new item (Ctrl + N)");
            KeyboardAccelerator addItemKeyboardAccelerator = new KeyboardAccelerator()
            {
                Modifiers = VirtualKeyModifiers.Control,
                Key = VirtualKey.N
            };
            AddItem.KeyboardAccelerators.Add(addItemKeyboardAccelerator);

            PageHeader.PrimaryCommands.Add(AddItem);



            //ValueWhenConverter boolToGridLength = new ValueWhenConverter
            //{
            //    When = true,
            //    Value = new GridLength(50),
            //    Otherwise = new GridLength(0)
            //};





            AppBarButton OpenSlavePane = new AppBarButton()
            {
                Label = "Add " + (DataContext as ViewModelBase).GetPropertyValue("ModuleTitle"),
                Icon = new SymbolIcon(Symbol.Add),
                IsEnabled = true,
                Template = ApplicationBase.Current.Resources["ShadowAppBarButton"] as ControlTemplate,
                Style = ApplicationBase.Current.Resources["AppBarButtonRevealLabelsOnRightStyle"] as Style,
                Command = null
            };

            ToolTipService.SetToolTip(OpenSlavePane, "Add new item (Ctrl + N)");
            KeyboardAccelerator openSlavePaneKeyboardAccelerator = new KeyboardAccelerator()
            {
                Modifiers = VirtualKeyModifiers.Control,
                Key = VirtualKey.N
            };
            OpenSlavePane.KeyboardAccelerators.Add(openSlavePaneKeyboardAccelerator);

            PageHeader.PrimaryCommands.Add(OpenSlavePane);

            TextBlock title = new TextBlock
            {
                Text = "Home",
                Style = ApplicationBase.Current.Resources["PageHeaderText"] as Style
            };
            PageHeader.Content = title;

            container.Children.Add(PageHeader);
        }

        public void asd()
        {
            Type pokus = typeof(ModuleVMBase<>);
            var xxx = pokus.MakeGenericType(uiModule.ModuleItemType);
        }
    }
}

using ISUF.Base.Attributes;
using ISUF.Base.Modules;
using ISUF.Base.Template;
using ISUF.UI.App;
using ISUF.UI.Converters;
using ISUF.UI.Design;
using ISUF.UI.Modules;
using ISUF.UI.ViewModel;
using System;
using System.Linq;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ISUF.UI.Views
{
    /// <summary>
    /// Module detail control
    /// </summary>
    public class ModuleDetailControlBase : ControlBase
    {
        Panel mainContent;
        readonly UIModule uiModule;

        /// <summary>
        /// Init module detail control
        /// </summary>
        /// <param name="uiModule">UI Module</param>
        /// <param name="viewModelType">View model type</param>
        /// <param name="viewModelArgs">View module arguments</param>
        public ModuleDetailControlBase(UIModule uiModule, Type viewModelType, params object[] viewModelArgs) : base(viewModelType, viewModelArgs)
        {
            this.uiModule = uiModule;
        }

        /// <inheritdoc/>
        public override void AddControls()
        {
            Grid content = new Grid()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
            };

            RowDefinition mainRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };

            RowDefinition buttonsRow = new RowDefinition()
            {
                Height = new GridLength(59, GridUnitType.Pixel)
            };

            content.RowDefinitions.Add(mainRow);
            content.RowDefinitions.Add(buttonsRow);

            ScrollViewer mainScrollView = new ScrollViewer()
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                VerticalScrollMode = ScrollMode.Enabled
            };
            Grid.SetRow(mainScrollView, 0);

            mainContent = new RelativePanel();
            mainScrollView.Content = mainContent;

            content.Children.Add(mainScrollView);

            Grid buttonsPart = new Grid();
            Grid.SetRow(buttonsPart, 1);
            
            RowDefinition buttonRow = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };

            buttonsPart.RowDefinitions.Add(buttonRow);

            Button Cancel = new Button()
            {
                Name = nameof(Cancel),
                Margin = new Thickness(1, 1, 0, 1),
                FontSize = 15,
                IsEnabled = true,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Command = (DataContext as ViewModelBase).GetPropertyValue("Close") as ICommand
            };

            StackPanel cancelContent = new StackPanel()
            {
                Orientation = Orientation.Horizontal
            };

            SymbolIcon cancelIcon = new SymbolIcon(Symbol.Cancel)
            {
                Margin = new Thickness(0, 0, 10, 0)
            };

            TextBlock cancelText = new TextBlock()
            {
                Text = "Cancel"
            };

            cancelContent.Children.Add(cancelIcon);
            cancelContent.Children.Add(cancelText);
            Cancel.Content = cancelContent;
            ToolTipService.SetToolTip(Cancel, "Cancel (Esc)");

            KeyboardAccelerator cancelKeyboardAccelerator = new KeyboardAccelerator()
            {
                Key = VirtualKey.Escape
            };
            Cancel.KeyboardAccelerators.Add(cancelKeyboardAccelerator);

            buttonsPart.Children.Add(Cancel);
            content.Children.Add(buttonsPart);

            Content = content;
        }

        /// <inheritdoc/>
        public override void CreateControlsForModule()
        {
            var result = ApplicationBase.Current.ModuleAnalyser.SortProperties(uiModule.ModuleItemType);

            UIElement previousControl = null;

            foreach (var item in result)
            {
                if (item.Value.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIIgnoreAttribute)) != null)
                    continue;

                mainContent.Children.Add(ControlCreator.CreateDetailControl(item, ref previousControl));
            }

            FillPredefinedValues();
        }

        /// <summary>
        /// Fill predefined values
        /// </summary>
        private void FillPredefinedValues()
        {
            object item = (DataContext as ViewModelBase).GetPropertyValue("DetailItem");

            try
            {
                item = Convert.ChangeType(item, uiModule.ModuleItemType);
            }
            catch (ArgumentNullException e)
            {
                throw new Base.Exceptions.ArgumentNullException("Argument is null", e);
            }
            catch (FormatException e)
            {
                throw new Base.Exceptions.ArgumentException("Argument format exception", e);
            }
            catch (Exception e)
            {
                throw new Base.Exceptions.Exception("Unhandled exception", e);
            }

            var formControls = FormDataMiner.GetControlsFromForm(this);
            FormDataMiner.FillValuesIntoForm(formControls, item, true);
        }
    }
}

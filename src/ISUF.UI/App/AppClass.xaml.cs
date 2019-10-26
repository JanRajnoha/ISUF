using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System;
using System.IO;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ISUF.UI.App
{
    [Bindable]
    public partial class AppClass : BootStrapper
    {
        public VMLocator VMLocator { get; set; } = new VMLocator();

        public AppClass()
        {
            Uri colorsUri = new Uri("Controls/Colors.xaml", UriKind.Relative);
            Stream colorsResStream = new FileStream(colorsUri.LocalPath, FileMode.Open);
            StreamReader reader = new StreamReader(colorsResStream);
            Resources = (ResourceDictionary)XamlReader.Load(reader.ReadToEnd());
            reader.Close();

            Uri controlsUri = new Uri("Controls/ControlTemplates.xaml", UriKind.Relative);
            Stream controlsResStream = new FileStream(controlsUri.LocalPath, FileMode.Open);
            reader = new StreamReader(controlsResStream);
            ResourceDictionary resDictionary = (ResourceDictionary)XamlReader.Load(reader.ReadToEnd());
            Resources.MergedDictionaries.Add(resDictionary);
            reader.Close();
        }

        public UIModuleManager ModuleManager { get; set; }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            await Task.CompletedTask;
        }
    }
}

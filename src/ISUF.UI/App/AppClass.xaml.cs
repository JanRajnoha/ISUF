using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ISUF.UI.App
{
    [Bindable]
    public partial class AppClass : BootStrapper
    {
        public UIModuleManager ModuleManager { get; set; }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            await Task.CompletedTask;
        }
    }
}

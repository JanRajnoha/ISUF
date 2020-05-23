using ISUF.UI.App;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ISUF.UI.Controls
{
    /// <summary>
    /// Release notes user control
    /// </summary>
    public sealed partial class ReleaseNotes : UserControl
    {
        public string ReleaseNote { get; set; }

        public string AppDisplayName { get; set; }

        public string Version { get; set; }

        /// <summary>
        /// Init release notes
        /// </summary>
        public ReleaseNotes()
        {
            InitializeComponent();

            var v = Windows.ApplicationModel.Package.Current.Id.Version;
            Version = $"{v.Major}.{v.Minor}.{v.Build}";

            ReleaseNote = ApplicationBase.Current.ReleaseNotes;
            AppDisplayName = ApplicationBase.Current.AppDisplayName;
        }
    }
}

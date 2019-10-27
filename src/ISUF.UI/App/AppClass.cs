using ISUF.UI.Classes;
using ISUF.UI.Modules;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ISUF.UI.App
{
    [Bindable]
    public class AppClass : BootStrapper
    {
        public new static AppClass Current { get; set; }

        public VMLocator VMLocator { get; set; } = new VMLocator();

        public UIModuleManager ModuleManager { get; set; }

        public AppClass()
        {
            //ImportResources();

            Suspending += OnSuspending;
        }
        // <ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  xmlns:controls="using:Template10.Controls">  <x:Double x:Key="NarrowMinWidth">0</x:Double>  <x:Double x:Key="NormalMinWidth">710</x:Double> <x:Double x:Key="WideMinWidth">1200</x:Double> <x:Double x:Key="LowMinHeight">0</x:Double>  <x:Double x:Key="HighMinHeight">400</x:Double>  <Color x:Key="CustomColor">SteelBlue</Color> <Color x:Key="ContrastColor">White</Color> <Color x:Key="ContrastColorReverse">Black</Color> <!--<Color x:Key="SystemAccentColor">SteelBlue</Color>-->  <Color x:Key="RedAccentColor">#D91901</Color> <Color x:Key="GreenAccentColor">#7BB900</Color>  <Color x:Key="BlueAccentColor">#FF0F4CA8</Color>  <SolidColorBrush x:Key="RedAccentBrush" Color="{StaticResource RedAccentColor}"/>  <SolidColorBrush x:Key="GreenAccentBrush" Color="{StaticResource GreenAccentColor}"/> <SolidColorBrush x:Key="BlueAccentBrush" Color="{StaticResource BlueAccentColor}"/>  <Color x:Key="DarkNote">#FF8B8500</Color> <Color x:Key="LightNote">#FFD9E400</Color>  <ResourceDictionary.ThemeDictionaries>   <ResourceDictionary x:Key="Light">   <SolidColorBrush x:Key="CustomColorBrush" Color="{StaticResource CustomColor}" /> <SolidColorBrush x:Key="ContrastColorBrush" Color="{StaticResource ContrastColor}" />  <SolidColorBrush x:Key="ContrastColorReverseBrush" Color="{StaticResource ContrastColorReverse}" /> <SolidColorBrush x:Key="ExtendedSplashBackground" Color="{StaticResource CustomColor}" /> <SolidColorBrush x:Key="ExtendedSplashForeground" Color="{StaticResource ContrastColor}" />  <SolidColorBrush x:Key="ButtonFilterGridHover" Color="#00000000"/>  <Style TargetType ="controls:HamburgerMenu">  <Setter Property="AccentColor" Value="{StaticResource CustomColor}" />   <Setter Property ="VisualStateNarrowMinWidth" Value="{StaticResource NarrowMinWidth}" />   <Setter Property ="VisualStateNormalMinWidth" Value="{StaticResource NormalMinWidth}" />   <Setter Property ="VisualStateWideMinWidth" Value="{StaticResource WideMinWidth}" />  <Setter Property ="NavButtonForeground" Value="{StaticResource ContrastColorReverseBrush}" />  </Style>  <Style TargetType ="controls:PageHeader">  <Setter Property="Background" Value="{ThemeResource CustomColorBrush}" />   <Setter Property ="Foreground" Value="{ThemeResource ContrastColorReverseBrush}" />   <Setter Property ="VisualStateNarrowMinWidth" Value="{StaticResource NarrowMinWidth}" />   <Setter Property ="VisualStateNormalMinWidth" Value="{StaticResource NormalMinWidth}" />  </Style>  <Style TargetType ="AppBarButton">  <Setter Property="Foreground" Value="{ThemeResource ContrastColorReverseBrush}"/> </Style>  <Style TargetType ="AppBarSeparator">  <Setter Property="Foreground" Value="{ThemeResource ContrastColorReverseBrush}"/> </Style>  <Style TargetType ="controls:Resizer">   <Setter Property="GrabberBrush" Value="{ThemeResource CustomColorBrush}" />   <Setter Property ="GrabberVisibility" Value="Visible" /> </Style>  <AcrylicBrush x:Key="NavigationViewExpandedPaneBackground"  BackgroundSource="HostBackdrop"   TintColor="#FFFFFFFF"   TintOpacity="0.4"  FallbackColor="#FFCCCCCC"/>  <AcrylicBrush x:Key="AcrylicSoft"  BackgroundSource="HostBackdrop"   TintColor="#FFFFFFFF"   TintOpacity="0.4"  FallbackColor="#FFCCCCCC"/>  <AcrylicBrush x:Key="AcrylicFull"  BackgroundSource="HostBackdrop"   TintColor="#FFFFFFFF"   TintOpacity="1"  FallbackColor="#FFA0A0A0"/>  <AcrylicBrush x:Key="AcrylicInAppSoft"  BackgroundSource="Backdrop"  TintColor="#FFFFFFFF"   TintOpacity="0.4"  FallbackColor="#FFA0A0A0"/>  <AcrylicBrush x:Key="AcrylicInAppMedium"   BackgroundSource="Backdrop"  TintColor="#FFFFFFFF"   TintOpacity="0.6"  FallbackColor="#FFA0A0A0"/>  <AcrylicBrush x:Key="AcrylicInAppHard"  BackgroundSource="Backdrop"  TintColor="#FFFFFFFF"   TintOpacity="0.8"  FallbackColor="#FFA0A0A0"/>  <SolidColorBrush x:Key="TitleBarBackgroundThemeBrush" Color="#FF171717" />   <SolidColorBrush x:Key="TitleBarPressedBackgroundThemeBrush"  Color="DarkGray" />  <SolidColorBrush x:Key="TitleBarHoverBackgroundThemeBrush" Color="Gray" />   <SolidColorBrush x:Key="TitleBarForegroundThemeBrush" Color="Black" />  <SolidColorBrush x:Key="TitleBarButtonHoverThemeBrush" Color="#FF343434" />   <SolidColorBrush x:Key="TitleBarButtonPressedThemeBrush" Color="#FF4C4C4C" />   <SolidColorBrush x:Key="DarkNoteBrush" Color="{StaticResource DarkNote}" />  <SolidColorBrush x:Key="LightNoteBrush" Color="{StaticResource LightNote}" />  <SolidColorBrush x:Key="DetailPartHeader" Color="#FF686868" />    </ResourceDictionary>    <ResourceDictionary x:Key="Default">   <SolidColorBrush x:Key="CustomColorBrush" Color="{StaticResource CustomColor}" /> <SolidColorBrush x:Key="ContrastColorBrush" Color="{StaticResource ContrastColorReverse}" /> <SolidColorBrush x:Key="ContrastColorReverseBrush" Color="{StaticResource ContrastColor}" /> <SolidColorBrush x:Key="ExtendedSplashBackground" Color="{StaticResource CustomColor}" /> <SolidColorBrush x:Key="ExtendedSplashForeground" Color="{StaticResource ContrastColor}" />  <SolidColorBrush x:Key="ButtonFilterGridHover" Color="#66000000"/>  <Style TargetType ="controls:HamburgerMenu">   <!--    Windows 10 2015 (1511) Hamburger Menu Style   Simply replace AccentColor with the follow setters.   <Setter Property="HamburgerBackground" Value="{StaticResource CustomColorBrush}" />  <Setter Property="HamburgerForeground" Value="White" />  <Setter Property="NavAreaBackground" Value="#FF2C2C2C" />  <Setter Property="NavButtonForeground" Value="White" />  <Setter Property="NavButtonBackground" Value="Transparent" />   <Setter Property="NavButtonHoverForeground" Value="White" />  <Setter Property="NavButtonHoverBackground" Value="#FF585858" />  <Setter Property="NavButtonPressedForeground" Value="White" />  <Setter Property="NavButtonPressedBackground" Value="#FF848484" />   <Setter Property="NavButtonCheckedForeground" Value="White" />  <Setter Property="NavButtonCheckedBackground" Value="#FF2A4E6C" />   <Setter Property="NavButtonCheckedIndicatorBrush" Value="Transparent" />   -->    <Setter Property="AccentColor" Value="{StaticResource CustomColor}" />  <Setter Property="VisualStateNarrowMinWidth" Value="{StaticResource NarrowMinWidth}" />  <Setter Property="VisualStateNormalMinWidth" Value="{StaticResource NormalMinWidth}" />  <Setter Property="VisualStateWideMinWidth" Value="{StaticResource WideMinWidth}" />   <Setter Property="NavButtonForeground" Value="{StaticResource ContrastColorReverseBrush}" /> </Style>  <Style TargetType="controls:PageHeader">  <Setter Property="Background" Value="{ThemeResource CustomColorBrush}" />   <Setter Property="Foreground" Value="{ThemeResource ContrastColorReverseBrush}" />  <Setter Property="VisualStateNarrowMinWidth" Value="{StaticResource NarrowMinWidth}" />  <Setter Property="VisualStateNormalMinWidth" Value="{StaticResource NormalMinWidth}" /> </Style>  <Style TargetType="AppBarButton">  <Setter Property="Foreground" Value="{ThemeResource ContrastColorReverseBrush}" /> </Style>  <Style TargetType="AppBarSeparator">  <Setter Property="Foreground" Value="{ThemeResource ContrastColorReverseBrush}" /> </Style>  <Style TargetType="controls:Resizer">   <Setter Property="GrabberBrush" Value="{ThemeResource CustomColorBrush}" />  <Setter Property="GrabberVisibility" Value="Visible" /> </Style>  <AcrylicBrush x:Key="AcrylicSoft"   BackgroundSource="HostBackdrop"  TintColor="#FF000000"  TintOpacity="0.4"   FallbackColor="#FFCCCCCC" />  <AcrylicBrush x:Key="AcrylicInAppSoft"   BackgroundSource="Backdrop"   TintColor="#FF000000"  TintOpacity="0.4"   FallbackColor="#FF202020" />  <AcrylicBrush x:Key="AcrylicInAppMedium"   BackgroundSource="Backdrop"   TintColor="#FF000000"  TintOpacity="0.6"   FallbackColor="#FF202020" />  <AcrylicBrush x:Key="AcrylicInAppHard"   BackgroundSource="Backdrop"   TintColor="#FF000000"  TintOpacity="0.8"   FallbackColor="#FF202020" />  <SolidColorBrush x:Key="TitleBarBackgroundThemeBrush"  Color="#FF171717" />  <SolidColorBrush x:Key="TitleBarForegroundThemeBrush"  Color="White" />  <SolidColorBrush x:Key="TitleBarButtonHoverThemeBrush" Color="#FF343434" />  <SolidColorBrush x:Key="TitleBarButtonPressedThemeBrush" Color="#FF4C4C4C" />  <SolidColorBrush x:Key="TitleBarPressedBackgroundThemeBrush"  Color="Gray" />  <SolidColorBrush x:Key="TitleBarHoverBackgroundThemeBrush"  Color="DarkGray" />   <SolidColorBrush x:Key="DarkNoteBrush"  Color="{StaticResource LightNote}" />   <SolidColorBrush x:Key="LightNoteBrush" Color="{StaticResource DarkNote}" />  <SolidColorBrush x:Key="DetailPartHeader" Color="#FFA8A8A8" />   </ResourceDictionary>    <ResourceDictionary x:Key="HighContrast">   <SolidColorBrush x:Key="ExtendedSplashBackground" Color="Black" /> <SolidColorBrush x:Key="ExtendedSplashForeground" Color="White" />  <SolidColorBrush x:Key="ButtonFilterGridHover" Color="#66000000" />   <SolidColorBrush x:Key="AcrylicSoft" Color="{ThemeResource SystemColorWindowColor}" />   <SolidColorBrush x:Key="AcrylicInAppSoft" Color="{ThemeResource SystemColorWindowColor}" />   <SolidColorBrush x:Key="AcrylicInAppMedium"  Color="{ThemeResource SystemColorWindowColor}" />   <SolidColorBrush x:Key="AcrylicInAppHard" Color="{ThemeResource SystemColorWindowColor}" />   <Style TargetType="controls:HamburgerMenu">  <Setter Property="PaneBorderThickness" Value="0" />   <Setter Property="SecondarySeparator" Value="{ThemeResource SystemColorWindowTextColor}" />   <Setter Property="NavButtonBackground" Value="{ThemeResource SystemColorWindowColor}" />   <Setter Property="NavButtonForeground" Value="{ThemeResource SystemColorWindowTextColor}" />  <Setter Property="NavAreaBackground" Value="{ThemeResource SystemColorWindowColor}" />   <Setter Property="HamburgerForeground" Value="{ThemeResource SystemColorWindowColor}" />   <Setter Property="HamburgerBackground" Value="{ThemeResource SystemColorWindowTextColor}" />  <Setter Property="VisualStateNarrowMinWidth" Value="{ThemeResource NarrowMinWidth}" />   <Setter Property="VisualStateNormalMinWidth" Value="{ThemeResource NormalMinWidth}" />   <Setter Property="VisualStateWideMinWidth" Value="{ThemeResource WideMinWidth}" /> </Style>  <Style TargetType="controls:PageHeader">  <Setter Property="Background" Value="{ThemeResource SystemColorWindowColor}" />  <Setter Property="Foreground" Value="{ThemeResource SystemColorWindowTextColor}" />   <Setter Property="VisualStateNarrowMinWidth" Value="{ThemeResource NarrowMinWidth}" />   <Setter Property="VisualStateNormalMinWidth" Value="{ThemeResource NormalMinWidth}" />  </Style>  <Style TargetType="AppBarButton">  <Setter Property="Background" Value="{ThemeResource ContrastColorBrush}" />  <Setter Property="Foreground" Value="{ThemeResource ContrastColorBrush}" /> </Style>  <Style TargetType="AppBarSeparator">  <Setter Property="Foreground" Value="{ThemeResource ContrastColorBrush}" /> </Style>  <SolidColorBrush x:Key="TitleBarBackgroundThemeBrush"  Color="Black" />  <SolidColorBrush x:Key="TitleBarButtonHoverThemeBrush" Color="#FF343434" />  <SolidColorBrush x:Key="TitleBarButtonPressedThemeBrush" Color="#FF4C4C4C" />  <SolidColorBrush x:Key="TitleBarPressedBackgroundThemeBrush"  Color="LightGray" />  <SolidColorBrush x:Key="TitleBarHoverBackgroundThemeBrush"  Color="Gray" />  <SolidColorBrush x:Key="DarkNoteBrush"  Color="{StaticResource LightNote}" />   <SolidColorBrush x:Key="LightNoteBrush" Color="{StaticResource DarkNote}" />  </ResourceDictionary>  </ResourceDictionary.ThemeDictionaries>   </ResourceDictionary>
        public object ImportResources()
        {

            //string pathcombined = Path.Combine(Assembly.GetExecutingAssembly().Location, @"Controls\Colors.xaml");

            //Uri colorsUri = new Uri(@"Controls\Colors.xaml", UriKind.RelativeOrAbsolute);
            //Stream colorsResStream = new FileStream(Path.Combine(Assembly.GetExecutingAssembly().Location, @"Controls\Colors.xaml"), FileMode.Open);
            //StreamReader reader = new StreamReader(colorsResStream);
            return XamlReader.Load(sss.aaaaa);


            Resources = (ResourceDictionary)XamlReader.Load(sss.aaaaa);
            //reader.Close();

            Uri controlsUri = new Uri(@"Controls\ControlTemplates.xaml", UriKind.RelativeOrAbsolute);
            Stream controlsResStream = new FileStream(controlsUri.AbsoluteUri, FileMode.Open);
            StreamReader reader = new StreamReader(controlsResStream);
            ResourceDictionary resDictionary = (ResourceDictionary)XamlReader.Load(reader.ReadToEnd());
            Resources.MergedDictionaries.Add(resDictionary);
            reader.Close();
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        protected virtual void OnSuspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
        {
            var deferral = e?.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        protected virtual void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e?.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected virtual void OnLaunched(LaunchActivatedEventArgs e)
        { }
    }
}

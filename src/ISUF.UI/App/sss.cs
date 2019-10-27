using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.App
{
    public class sss
    {
        public static string aaaaa { get; set; } =
        " <ResourceDictionary xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" " +
        " xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" " +
        " xmlns:controls=\"using:Template10.Controls\">" +
        " " +
        " <x:Double x:Key=\"NarrowMinWidth\">0</x:Double> " +
        " <x:Double x:Key=\"NormalMinWidth\">710</x:Double>" +
        " <x:Double x:Key=\"WideMinWidth\">1200</x:Double>" +
        " <x:Double x:Key=\"LowMinHeight\">0</x:Double> " +
        " <x:Double x:Key=\"HighMinHeight\">400</x:Double>" +
        " " +
        " <Color x:Key=\"CustomColor\">SteelBlue</Color>" +
        " <Color x:Key=\"ContrastColor\">White</Color>" +
        " <Color x:Key=\"ContrastColorReverse\">Black</Color>" +
        " <!--<Color x:Key=\"SystemAccentColor\">SteelBlue</Color>-->" +
        " " +
        " <Color x:Key=\"RedAccentColor\">#D91901</Color>" +
        " <Color x:Key=\"GreenAccentColor\">#7BB900</Color> " +
        " <Color x:Key=\"BlueAccentColor\">#FF0F4CA8</Color>" +
        " " +
        " <SolidColorBrush x:Key=\"RedAccentBrush\" Color=\"{StaticResource RedAccentColor}\"/> " +
        " <SolidColorBrush x:Key=\"GreenAccentBrush\" Color=\"{StaticResource GreenAccentColor}\"/>" +
        " <SolidColorBrush x:Key=\"BlueAccentBrush\" Color=\"{StaticResource BlueAccentColor}\"/> " +
        " <Color x:Key=\"DarkNote\">#FF8B8500</Color>" +
        " <Color x:Key=\"LightNote\">#FFD9E400</Color>" +
        " " +
        " <ResourceDictionary.ThemeDictionaries>" +
        " " +
        "  <ResourceDictionary x:Key=\"Light\"> " +
        " " +
        " <SolidColorBrush x:Key=\"CustomColorBrush\" Color=\"{StaticResource CustomColor}\" />" +
        " <SolidColorBrush x:Key=\"ContrastColorBrush\" Color=\"{StaticResource ContrastColor}\" /> " +
        " <SolidColorBrush x:Key=\"ContrastColorReverseBrush\" Color=\"{StaticResource ContrastColorReverse}\" />" +
        " <SolidColorBrush x:Key=\"ExtendedSplashBackground\" Color=\"{StaticResource CustomColor}\" />" +
        " <SolidColorBrush x:Key=\"ExtendedSplashForeground\" Color=\"{StaticResource ContrastColor}\" />" +
        " " +
        " <SolidColorBrush x:Key=\"ButtonFilterGridHover\" Color=\"#00000000\"/>" +
        " " +
        " <Style TargetType =\"controls:HamburgerMenu\">" +
        "  <Setter Property=\"AccentColor\" Value=\"{StaticResource CustomColor}\" /> " +
        "  <Setter Property =\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" /> " +
        "  <Setter Property =\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" /> " +
        "  <Setter Property =\"VisualStateWideMinWidth\" Value=\"{StaticResource WideMinWidth}\" />" +
        "  <Setter Property =\"NavButtonForeground\" Value=\"{StaticResource ContrastColorReverseBrush}\" /> " +
        " </Style>" +
        " " +
        " <Style TargetType =\"controls:PageHeader\">" +
        "  <Setter Property=\"Background\" Value=\"{ThemeResource CustomColorBrush}\" /> " +
        "  <Setter Property =\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
        "  <Setter Property =\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" /> " +
        "  <Setter Property =\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" /> " +
        " </Style>" +
        " " +
        " <Style TargetType =\"AppBarButton\">" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\"/>" +
        " </Style>" +
        " " +
        " <Style TargetType =\"AppBarSeparator\">" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\"/>" +
        " </Style>" +
        " " +
        " <Style TargetType =\"controls:Resizer\"> " +
        "  <Setter Property=\"GrabberBrush\" Value=\"{ThemeResource CustomColorBrush}\" /> " +
        "  <Setter Property =\"GrabberVisibility\" Value=\"Visible\" />" +
        " </Style>" +
        " " +
        " <AcrylicBrush x:Key=\"NavigationViewExpandedPaneBackground\"" +
        "  BackgroundSource=\"HostBackdrop\" " +
        "  TintColor=\"#FFFFFFFF\" " +
        "  TintOpacity=\"0.4\"" +
        "  FallbackColor=\"#FFCCCCCC\"/>" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicSoft\"" +
        "  BackgroundSource=\"HostBackdrop\" " +
        "  TintColor=\"#FFFFFFFF\" " +
        "  TintOpacity=\"0.4\"" +
        "  FallbackColor=\"#FFCCCCCC\"/>" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicFull\"" +
        "  BackgroundSource=\"HostBackdrop\" " +
        "  TintColor=\"#FFFFFFFF\" " +
        "  TintOpacity=\"1\"" +
        "  FallbackColor=\"#FFA0A0A0\"/>" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicInAppSoft\"" +
        "  BackgroundSource=\"Backdrop\"" +
        "  TintColor=\"#FFFFFFFF\" " +
        "  TintOpacity=\"0.4\"" +
        "  FallbackColor=\"#FFA0A0A0\"/>" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicInAppMedium\" " +
        "  BackgroundSource=\"Backdrop\"" +
        "  TintColor=\"#FFFFFFFF\" " +
        "  TintOpacity=\"0.6\"" +
        "  FallbackColor=\"#FFA0A0A0\"/>" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicInAppHard\"" +
        "  BackgroundSource=\"Backdrop\"" +
        "  TintColor=\"#FFFFFFFF\" " +
        "  TintOpacity=\"0.8\"" +
        "  FallbackColor=\"#FFA0A0A0\"/>" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarBackgroundThemeBrush\"" +
        " Color=\"#FF171717\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarPressedBackgroundThemeBrush\" " +
        " Color=\"DarkGray\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarHoverBackgroundThemeBrush\"" +
        " Color=\"Gray\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarForegroundThemeBrush\"" +
        " Color=\"Black\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarButtonHoverThemeBrush\"" +
        " Color=\"#FF343434\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarButtonPressedThemeBrush\"" +
        " Color=\"#FF4C4C4C\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"DarkNoteBrush\"" +
        " Color=\"{StaticResource DarkNote}\" />" +
        " " +
        " <SolidColorBrush x:Key=\"LightNoteBrush\"" +
        " Color=\"{StaticResource LightNote}\" />" +
        " " +
        " <SolidColorBrush x:Key=\"DetailPartHeader\"" +
        " Color=\"#FF686868\" /> " +
        " " +
        "  </ResourceDictionary> " +
        " " +
        "  <ResourceDictionary x:Key=\"Default\"> " +
        " " +
        " <SolidColorBrush x:Key=\"CustomColorBrush\" Color=\"{StaticResource CustomColor}\" />" +
        " <SolidColorBrush x:Key=\"ContrastColorBrush\" Color=\"{StaticResource ContrastColorReverse}\" />" +
        " <SolidColorBrush x:Key=\"ContrastColorReverseBrush\" Color=\"{StaticResource ContrastColor}\" />" +
        " <SolidColorBrush x:Key=\"ExtendedSplashBackground\" Color=\"{StaticResource CustomColor}\" />" +
        " <SolidColorBrush x:Key=\"ExtendedSplashForeground\" Color=\"{StaticResource ContrastColor}\" />" +
        " " +
        " <SolidColorBrush x:Key=\"ButtonFilterGridHover\" Color=\"#66000000\"/>" +
        " " +
        " <Style TargetType =\"controls:HamburgerMenu\">" +
        " " +
        "  <Setter Property=\"AccentColor\" Value=\"{StaticResource CustomColor}\" />" +
        "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" />" +
        "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" />" +
        "  <Setter Property=\"VisualStateWideMinWidth\" Value=\"{StaticResource WideMinWidth}\" /> " +
        "  <Setter Property=\"NavButtonForeground\" Value=\"{StaticResource ContrastColorReverseBrush}\" />" +
        " </Style>" +
        " " +
        " <Style TargetType=\"controls:PageHeader\">" +
        "  <Setter Property=\"Background\" Value=\"{ThemeResource CustomColorBrush}\" /> " +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" />" +
        "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" />" +
        "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" />" +
        " </Style>" +
        " " +
        " <Style TargetType=\"AppBarButton\">" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" />" +
        " </Style>" +
        " " +
        " <Style TargetType=\"AppBarSeparator\">" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" />" +
        " </Style>" +
        " " +
        " <Style TargetType=\"controls:Resizer\"> " +
        "  <Setter Property=\"GrabberBrush\" Value=\"{ThemeResource CustomColorBrush}\" />" +
        "  <Setter Property=\"GrabberVisibility\" Value=\"Visible\" />" +
        " </Style>" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicSoft\" " +
        "  BackgroundSource=\"HostBackdrop\"" +
        "  TintColor=\"#FF000000\"" +
        "  TintOpacity=\"0.4\" " +
        "  FallbackColor=\"#FFCCCCCC\" />" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicInAppSoft\" " +
        "  BackgroundSource=\"Backdrop\" " +
        "  TintColor=\"#FF000000\"" +
        "  TintOpacity=\"0.4\" " +
        "  FallbackColor=\"#FF202020\" />" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicInAppMedium\" " +
        "  BackgroundSource=\"Backdrop\" " +
        "  TintColor=\"#FF000000\"" +
        "  TintOpacity=\"0.6\" " +
        "  FallbackColor=\"#FF202020\" />" +
        " " +
        " <AcrylicBrush x:Key=\"AcrylicInAppHard\" " +
        "  BackgroundSource=\"Backdrop\" " +
        "  TintColor=\"#FF000000\"" +
        "  TintOpacity=\"0.8\" " +
        "  FallbackColor=\"#FF202020\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarBackgroundThemeBrush\" " +
        " Color=\"#FF171717\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarForegroundThemeBrush\" " +
        " Color=\"White\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarButtonHoverThemeBrush\"" +
        " Color=\"#FF343434\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarButtonPressedThemeBrush\"" +
        " Color=\"#FF4C4C4C\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarPressedBackgroundThemeBrush\" " +
        " Color=\"Gray\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarHoverBackgroundThemeBrush\" " +
        " Color=\"DarkGray\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"DarkNoteBrush\" " +
        " Color=\"{StaticResource LightNote}\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"LightNoteBrush\"" +
        " Color=\"{StaticResource DarkNote}\" />" +
        " " +
        " <SolidColorBrush x:Key=\"DetailPartHeader\"" +
        " Color=\"#FFA8A8A8\" />" +
        " " +
        "  </ResourceDictionary> " +
        " " +
        "  <ResourceDictionary x:Key=\"HighContrast\"> " +
        " " +
        " <SolidColorBrush x:Key=\"ExtendedSplashBackground\" Color=\"Black\" />" +
        " <SolidColorBrush x:Key=\"ExtendedSplashForeground\" Color=\"White\" />" +
        " " +
        " <SolidColorBrush x:Key=\"ButtonFilterGridHover\" Color=\"#66000000\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"AcrylicSoft\"" +
        " Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"AcrylicInAppSoft\"" +
        " Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"AcrylicInAppMedium\" " +
        " Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"AcrylicInAppHard\"" +
        " Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
        " " +
        " <Style TargetType=\"controls:HamburgerMenu\">" +
        "  <Setter Property=\"PaneBorderThickness\" Value=\"0\" /> " +
        "  <Setter Property=\"SecondarySeparator\" Value=\"{ThemeResource SystemColorWindowTextColor}\" /> " +
        "  <Setter Property=\"NavButtonBackground\" Value=\"{ThemeResource SystemColorWindowColor}\" /> " +
        "  <Setter Property=\"NavButtonForeground\" Value=\"{ThemeResource SystemColorWindowTextColor}\" />" +
        "  <Setter Property=\"NavAreaBackground\" Value=\"{ThemeResource SystemColorWindowColor}\" /> " +
        "  <Setter Property=\"HamburgerForeground\" Value=\"{ThemeResource SystemColorWindowColor}\" /> " +
        "  <Setter Property=\"HamburgerBackground\" Value=\"{ThemeResource SystemColorWindowTextColor}\" />" +
        "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{ThemeResource NarrowMinWidth}\" /> " +
        "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{ThemeResource NormalMinWidth}\" /> " +
        "  <Setter Property=\"VisualStateWideMinWidth\" Value=\"{ThemeResource WideMinWidth}\" />" +
        " </Style>" +
        " " +
        " <Style TargetType=\"controls:PageHeader\">" +
        "  <Setter Property=\"Background\" Value=\"{ThemeResource SystemColorWindowColor}\" />" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource SystemColorWindowTextColor}\" /> " +
        "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{ThemeResource NarrowMinWidth}\" /> " +
        "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{ThemeResource NormalMinWidth}\" /> " +
        " </Style>" +
        " " +
        " <Style TargetType=\"AppBarButton\">" +
        "  <Setter Property=\"Background\" Value=\"{ThemeResource ContrastColorBrush}\" />" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorBrush}\" />" +
        " </Style>" +
        " " +
        " <Style TargetType=\"AppBarSeparator\">" +
        "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorBrush}\" />" +
        " </Style>" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarBackgroundThemeBrush\" " +
        " Color=\"Black\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarButtonHoverThemeBrush\"" +
        " Color=\"#FF343434\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarButtonPressedThemeBrush\"" +
        " Color=\"#FF4C4C4C\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarPressedBackgroundThemeBrush\" " +
        " Color=\"LightGray\" />" +
        " " +
        " <SolidColorBrush x:Key=\"TitleBarHoverBackgroundThemeBrush\" " +
        " Color=\"Gray\" />" +
        " " +
        " <SolidColorBrush x:Key=\"DarkNoteBrush\" " +
        " Color=\"{StaticResource LightNote}\" /> " +
        " " +
        " <SolidColorBrush x:Key=\"LightNoteBrush\"" +
        " Color=\"{StaticResource DarkNote}\" />" +
        "  </ResourceDictionary> " +
        " </ResourceDictionary.ThemeDictionaries>" +
         "  " +
        " </ResourceDictionary>";
    }
}
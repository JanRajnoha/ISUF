using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.XamlStyles
{
 public class XamlDictionaries
 {
  public static string Colors { get; private set; }=
            "  <ResourceDictionary xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" " +
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

        public static string Controls { get; private set; } =
      " <ResourceDictionary  " +
     "  xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"  " +
     "  xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" " +
     "  xmlns:Tools=\"using:Microsoft.Toolkit.Uwp.UI.Controls\"  " +
     "  xmlns:interactivity=\"using:Microsoft.Xaml.Interactivity\"  " +
     "  xmlns:UI=\"using:Microsoft.Advertising.WinRT.UI\"  " +
     "  xmlns:T10Controls=\"using:Template10.Controls\" " +
     "  xmlns:Conv=\"using:Template10.Converters\"" +
     "  xmlns:behaviors=\"using:Template10.Behaviors\"  " +
     "  xmlns:Control=\"using:ISUF.UI.Controls\"> " +
     "  " +
     "  <x:Double x:Key=\"NarrowMinWidth\">0</x:Double> " +
     "  <x:Double x:Key=\"NormalMinWidth\">710</x:Double>  " +
     "  <x:Double x:Key=\"WideMinWidth\">1200</x:Double>" +
     "  <x:Double x:Key=\"LowMinHeight\">0</x:Double>" +
     "  <x:Double x:Key=\"HighMinHeight\">400</x:Double>" +
     "  " +
     "  <Color x:Key=\"CustomColor\">SteelBlue</Color>  " +
     "  <Color x:Key=\"ContrastColor\">White</Color> " +
     "  <Color x:Key=\"ContrastColorReverse\">Black</Color>" +
     "  <!--<Color x:Key=\"SystemAccentColor\">SteelBlue</Color>--> " +
     "  " +
     "  <Color x:Key=\"RedAccentColor\">#D91901</Color>" +
     "  <Color x:Key=\"GreenAccentColor\">#7BB900</Color> " +
     "  <Color x:Key=\"BlueAccentColor\">#FF0F4CA8</Color>" +
     "  " +
     "  <SolidColorBrush x:Key=\"RedAccentBrush\" Color=\"{StaticResource RedAccentColor}\"/>  " +
     "  <SolidColorBrush x:Key=\"GreenAccentBrush\" Color=\"{StaticResource GreenAccentColor}\"/> " +
     "  <SolidColorBrush x:Key=\"BlueAccentBrush\" Color=\"{StaticResource BlueAccentColor}\"/>" +
     "  <Color x:Key=\"DarkNote\">#FF8B8500</Color>  " +
     "  <Color x:Key=\"LightNote\">#FFD9E400</Color> " +
     "  " +
     "  <Style TargetType=\"Control:CircleButton\">  " +
     "   <Setter Property=\"Background\" Value=\"#00000000\"/>  " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource ButtonForeground}\"/>  " +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource ButtonBorderBrush}\"/>" +
     "   <Setter Property=\"BorderThickness\" Value=\"2\"/> " +
     "   <Setter Property=\"Padding\" Value=\"-10\"/> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Left\"/>" +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Center\"/>" +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\"/> " +
     "   <Setter Property=\"FontWeight\" Value=\"Normal\"/> " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\"/>  " +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\"/> " +
     "   <Setter Property=\"FocusVisualMargin\" Value=\"-3\"/> " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Control:CircleButton\">" +
     "   <Grid x:Name=\"Container\" Background=\"Transparent\">  " +
     " <VisualStateManager.VisualStateGroups>  " +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\"> " +
     " <Storyboard> " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"RootGrid\"/>  " +
     "  <DoubleAnimation Duration=\"0:0:0.25\" EnableDependentAnimation=\"True\" From=\"15\" Storyboard.TargetName=\"Shadow\" Storyboard.TargetProperty=\"BlurRadius\" To=\"0\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Circle.Fill\" Value=\"{Binding currentColor, RelativeSource={RelativeSource TemplatedParent}}\" />  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{Binding ContentColor, RelativeSource={RelativeSource TemplatedParent}}\" /> " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Circle.Fill\" Value=\"{Binding FillHoverColor, RelativeSource={RelativeSource TemplatedParent}}\" />" +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{Binding ContentHoverColor, RelativeSource={RelativeSource TemplatedParent}}\" />  " +
     "  <Setter Target=\"Circle.StrokeThickness\" Value=\"0\" /> " +
     "  <!--<Setter Target=\"Circle.(RevealBrush.State)\" Value=\"PointerOver\" /> -->  " +
     "  <!--<Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrush}\" /> -->  " +
     " </VisualState.Setters> " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"RootGrid\" />  " +
     "  <DoubleAnimation Duration=\"0:0:0.25\" EnableDependentAnimation=\"True\" From=\"0\" Storyboard.TargetName=\"Shadow\" Storyboard.TargetProperty=\"BlurRadius\" To=\"15\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{Binding ContentPressedColor, RelativeSource={RelativeSource TemplatedParent}}\" />" +
     "  <Setter Target=\"Circle.Fill\" Value=\"{Binding FillPressedColor, RelativeSource={RelativeSource TemplatedParent}}\" /> " +
     "  <Setter Target=\"Circle.StrokeThickness\" Value=\"0\" /> " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"15\" />  " +
     "  <!--<Setter Target=\"Circle.(RevealBrush.State)\" Value=\"Pressed\" /> -->" +
     "  <!--<Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBackgroundPressed}\" /> -->  " +
     " </VisualState.Setters> " +
     " <Storyboard>  " +
     "  <PointerDownThemeAnimation Storyboard.TargetName=\"Container\" />  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundDisabled}\" />  " +
     "  <Setter Target=\"Circle.Fill\" Value=\"{Binding currentColor, RelativeSource={RelativeSource TemplatedParent}}\" />  " +
     "  <Setter Target=\"Circle.StrokeThickness\" Value=\"0\" /> " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     "  <!--<Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrushDisabled}\" /> -->" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <Tools:DropShadowPanel x:Name=\"Shadow\" " +
     "   BlurRadius=\"15\"  " +
     "   Color=\"Transparent\" " +
     "   HorizontalContentAlignment=\"Stretch\"  " +
     "   OffsetY=\".0\"  " +
     "   OffsetX=\"0\"" +
     "   Style=\"{StaticResource ShadowMenu}\"" +
     "   ShadowOpacity=\".5\"  " +
     "   VerticalContentAlignment=\"Stretch\">  " +
     "  " +
     "  <Grid x:Name=\"BackgroundLayer\"  " +
     "  Background=\"Transparent\"> " +
     "  " +
     "   <Grid x:Name=\"RootGrid\"  " +
     "   Background=\"{TemplateBinding Background}\"> " +
     "  " +
     " <Ellipse x:Name=\"Circle\"" +
     " StrokeThickness=\"0\"" +
     " Stroke=\"{TemplateBinding Foreground}\"" +
     " Height=\"{TemplateBinding Height}\" " +
     " Width=\"{TemplateBinding Width}\" />" +
     " <!--Fill=\"{ThemeResource ButtonRevealBackground}\"-->" +
     "  " +
     " <ContentPresenter x:Name=\"ContentPresenter\"  " +
     " AutomationProperties.AccessibilityView=\"Raw\"  " +
     " BorderThickness=\"{TemplateBinding BorderThickness}\" " +
     " BorderBrush=\"{TemplateBinding BorderBrush}\"" +
     " ContentTemplate=\"{TemplateBinding ContentTemplate}\" " +
     " Content=\"{TemplateBinding Content}\"  " +
     " ContentTransitions=\"{TemplateBinding ContentTransitions}\" " +
     " HorizontalContentAlignment=\"{TemplateBinding HorizontalContentAlignment}\"" +
     " Padding=\"{TemplateBinding Padding}\"  " +
     " VerticalContentAlignment=\"{TemplateBinding VerticalContentAlignment}\" /> " +
     "   </Grid>  " +
     "  </Grid>" +
     " </Tools:DropShadowPanel>" +
     "   </Grid> " +
     "  </ControlTemplate>" +
     " </Setter.Value> " +
     "   </Setter>  " +
     "  </Style> " +
     "  " +
     "  <Style TargetType=\"Button\"> " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource ButtonRevealBackground}\" />" +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource ButtonForeground}\" />" +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrush}\" /> " +
     "   <Setter Property=\"BorderThickness\" Value=\"2\" />  " +
     "   <Setter Property=\"Padding\" Value=\"8,4,8,4\" /> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Left\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Center\" /> " +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\" />  " +
     "   <Setter Property=\"FontWeight\" Value=\"Normal\" />  " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\" />" +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"FocusVisualMargin\" Value=\"-3\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Button\">" +
     "   <Grid x:Name=\"Container\" Background=\"Transparent\"> " +
     "  " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\"> " +
     "  " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"RootGrid\" />  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"15\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"RootGrid.(RevealBrush.State)\" Value=\"PointerOver\" />" +
     "  <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource ButtonRevealBackgroundPointerOver}\" /> " +
     "  <Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrush}\" />  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundPointerOver}\" />  " +
     " </VisualState.Setters> " +
     "  " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"RootGrid\" />  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"15\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"RootGrid.(RevealBrush.State)\" Value=\"Pressed\" /> " +
     "  <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource ButtonRevealBackgroundPressed}\" />  " +
     "  <Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBackgroundPressed}\" />  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundPressed}\" />" +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"15\" />  " +
     " </VisualState.Setters> " +
     "  " +
     " <Storyboard>  " +
     "  <PointerDownThemeAnimation Storyboard.TargetName=\"Container\" />  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     "  <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource ButtonRevealBackgroundDisabled}\" /> " +
     "  <Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrushDisabled}\" />" +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundDisabled}\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  " +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <Tools:DropShadowPanel x:Name=\"Shadow\" " +
     "   BlurRadius=\"15\"  " +
     "   Color=\"Black\" " +
     "   ShadowOpacity=\".5\"  " +
     "   OffsetX=\"0\"" +
     "   OffsetY=\".0\"  " +
     "   HorizontalContentAlignment=\"Stretch\"  " +
     "   VerticalContentAlignment=\"Stretch\" " +
     "   Style=\"{StaticResource ShadowMenu}\"> " +
     "  " +
     "  <Grid x:Name=\"BackgroundLayer\" Background=\"{ThemeResource SystemControlAcrylicWindowBrush}\">  " +
     "   <!--SystemControlAcrylicWindowBrush--> " +
     "   <Grid x:Name=\"RootGrid\" Background=\"{TemplateBinding Background}\">" +
     " <ContentPresenter x:Name=\"ContentPresenter\"  " +
     " BorderBrush=\"{TemplateBinding BorderBrush}\"" +
     " BorderThickness=\"{TemplateBinding BorderThickness}\" " +
     " Content=\"{TemplateBinding Content}\"  " +
     " ContentTransitions=\"{TemplateBinding ContentTransitions}\" " +
     " ContentTemplate=\"{TemplateBinding ContentTemplate}\" " +
     " Padding=\"{TemplateBinding Padding}\"  " +
     " HorizontalContentAlignment=\"{TemplateBinding HorizontalContentAlignment}\"" +
     " VerticalContentAlignment=\"{TemplateBinding VerticalContentAlignment}\" " +
     " AutomationProperties.AccessibilityView=\"Raw\" />  " +
     "   </Grid>  " +
     "  </Grid>" +
     " </Tools:DropShadowPanel>" +
     "   </Grid> " +
     "  </ControlTemplate>" +
     " </Setter.Value> " +
     "   </Setter>  " +
     "  </Style> " +
     "  " +
     "  <Style TargetType=\"Control:NavigationView\">" +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Control:NavigationView\">  " +
     "   <Grid x:Name=\"RootGrid\">" +
     " <Grid.Resources> " +
     "  <Conv:ValueWhenConverter x:Key=\"ShadowOffsetConvertor\">" +
     "   <Conv:ValueWhenConverter.When> " +
     " <x:Boolean>True</x:Boolean> " +
     "   </Conv:ValueWhenConverter.When> " +
     "   <Conv:ValueWhenConverter.Value> " +
     " <x:Double>318.0</x:Double>  " +
     "   </Conv:ValueWhenConverter.Value>" +
     "   <Conv:ValueWhenConverter.Otherwise>" +
     " <x:Double>46.0</x:Double>" +
     "   </Conv:ValueWhenConverter.Otherwise>  " +
     "  </Conv:ValueWhenConverter> " +
     "  " +
     "  <Conv:ValueWhenConverter x:Key=\"ShowAdConvertor\"> " +
     "   <Conv:ValueWhenConverter.When> " +
     " <x:Boolean>True</x:Boolean> " +
     "   </Conv:ValueWhenConverter.When> " +
     "   <Conv:ValueWhenConverter.Value> " +
     " <Visibility>Visible</Visibility>  " +
     "   </Conv:ValueWhenConverter.Value>" +
     "   <Conv:ValueWhenConverter.Otherwise>" +
     " <Visibility>Collapsed</Visibility>" +
     "   </Conv:ValueWhenConverter.Otherwise>  " +
     "  </Conv:ValueWhenConverter> " +
     " </Grid.Resources>  " +
     "  " +
     " <VisualStateManager.VisualStateGroups>  " +
     "  <VisualStateGroup x:Name=\"DisplayModeGroup\">" +
     "   <VisualState x:Name=\"Compact\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.ShadowOpacity\" Value=\".5\" />  " +
     "  <Setter Target=\"MenuAdWrapper.Visibility\" Value=\"Collapsed\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Expanded\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"RootSplitView.PaneBackground\" Value=\"{ThemeResource NavigationViewExpandedPaneBackground}\" /> " +
     "  <Setter Target=\"MenuAdWrapper.Visibility\" Value=\"Visible\" />  " +
     "  <Setter Target=\"Shadow.ShadowOpacity\" Value=\".5\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Minimal\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"HeaderContent.Margin\" Value=\"48 0 0 0\" />  " +
     "  <Setter Target=\"MenuAdWrapper.Visibility\" Value=\"Visible\" />  " +
     "  <Setter Target=\"Shadow.ShadowOpacity\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"TogglePaneGroup\">" +
     "   <VisualState x:Name=\"TogglePaneButtonVisible\" /> " +
     "   <VisualState x:Name=\"TogglePaneButtonCollapsed\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"TogglePaneButton.Visibility\" Value=\"Collapsed\" />" +
     "  <Setter Target=\"PaneContentGridToggleButtonRow.Height\" Value=\"4\" /> " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"HeaderGroup\"> " +
     "   <VisualState x:Name=\"HeaderVisible\" />  " +
     "   <VisualState x:Name=\"HeaderCollapsed\"> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"HeaderContent.Visibility\" Value=\"Collapsed\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"SettingsGroup\">  " +
     "   <VisualState x:Name=\"SettingsVisible\" />" +
     "   <VisualState x:Name=\"SettingsCollapsed\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"SettingsNavPaneItem.Visibility\" Value=\"Collapsed\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"AutoSuggestGroup\">  " +
     "   <VisualState x:Name=\"AutoSuggestBoxVisible\" />" +
     "   <VisualState x:Name=\"AutoSuggestBoxCollapsed\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"AutoSuggestArea.Visibility\" Value=\"Collapsed\" /> " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"PaneStateGroup\"> " +
     "   <VisualState x:Name=\"NotClosedCompact\" />  " +
     "   <VisualState x:Name=\"ClosedCompact\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"PaneAutoSuggestBoxPresenter.Visibility\" Value=\"Collapsed\" /> " +
     "  <Setter Target=\"PaneAutoSuggestButton.Visibility\" Value=\"Visible\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"TitleBarVisibilityGroup\"> " +
     "   <VisualState x:Name=\"TitleBarVisible\" />" +
     "   <VisualState x:Name=\"TitleBarCollapsed\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"PaneButtonGrid.Margin\" Value=\"0,32,0,0\" /> " +
     "  <Setter Target=\"PaneContentGrid.Margin\" Value=\"0,32,0,0\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <Grid HorizontalAlignment=\"Left\" Margin=\"0,0,0,8\" VerticalAlignment=\"Top\" Width=\"{StaticResource PaneToggleButtonSize}\" Canvas.ZIndex=\"100\">" +
     "  <Grid.RowDefinitions> " +
     "   <RowDefinition Height=\"Auto\" />" +
     "   <RowDefinition Height=\"Auto\" />" +
     "  </Grid.RowDefinitions>" +
     "  <Grid x:Name=\"TogglePaneTopPadding\" />" +
     "  <Button x:Name=\"TogglePaneButton\" Background=\"{TemplateBinding Background}\" AutomationProperties.LandmarkType=\"Navigation\" Grid.Row=\"1\" Style=\"{StaticResource PaneToggleButtonStyle}\"> " +
     "   <SymbolIcon Symbol=\"GlobalNavigationButton\" />" +
     "  </Button> " +
     " </Grid> " +
     " <SplitView x:Name=\"RootSplitView\" Background=\"{TemplateBinding Background}\" CompactPaneLength=\"{TemplateBinding CompactPaneLength}\" DisplayMode=\"Inline\" IsTabStop=\"False\" IsPaneOpen=\"{Binding IsPaneOpen, Mode=TwoWay, RelativeSource={RelativeSource Mode=TemplatedParent}}\" OpenPaneLength=\"{TemplateBinding OpenPaneLength}\" PaneBackground=\"{ThemeResource NavigationViewDefaultPaneBackground}\" Style=\"{StaticResource DefaultSplitView}\"> " +
     "  <SplitView.Template>  " +
     "   <ControlTemplate TargetType=\"SplitView\">  " +
     " <Grid Background=\"{TemplateBinding Background}\">  " +
     "  <Grid.ColumnDefinitions> " +
     "   <ColumnDefinition x:Name=\"ColumnDefinition1\" Width=\"{Binding TemplateSettings.OpenPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   <ColumnDefinition x:Name=\"ColumnDefinition2\" Width=\"*\" /> " +
     "  </Grid.ColumnDefinitions>" +
     "  <VisualStateManager.VisualStateGroups>  " +
     "   <VisualStateGroup x:Name=\"DisplayModeStates\">" +
     " <VisualStateGroup.Transitions>  " +
     "  <VisualTransition From=\"Closed\" To=\"OpenOverlayLeft\">  " +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"1.0\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"Closed\" To=\"OpenOverlayRight\"> " +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"1.0\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"ClosedCompactLeft\" To=\"OpenCompactOverlayLeft\">  " +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"0\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"1.0\" /> " +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"ClosedCompactRight\" To=\"OpenCompactOverlayRight\">" +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"0\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"1.0\" /> " +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"OpenOverlayLeft\" To=\"Closed\">  " +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"0.0\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"OpenOverlayRight\" To=\"Closed\"> " +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"0.0\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"OpenCompactOverlayLeft\" To=\"ClosedCompactLeft\">  " +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" /> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"0.0\" /> " +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     "  <VisualTransition From=\"OpenCompactOverlayRight\" To=\"ClosedCompactRight\">" +
     "   <Storyboard>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />" +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">" +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" /> " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"{Binding TemplateSettings.OpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " </DoubleAnimationUsingKeyFrames>" +
     " <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\"> " +
     "  <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" /> " +
     " </ObjectAnimationUsingKeyFrames>" +
     " <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\"> " +
     "  <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />  " +
     "  <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.0\" Value=\"0.0\" /> " +
     " </DoubleAnimationUsingKeyFrames>" +
     "   </Storyboard>  " +
     "  </VisualTransition>" +
     " </VisualStateGroup.Transitions> " +
     " <VisualState x:Name=\"Closed\" />  " +
     " <VisualState x:Name=\"ClosedCompactLeft\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimation Duration=\"0:0:0\" Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\" To=\"{Binding TemplateSettings.NegativeOpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"ClosedCompactRight\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"2\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimation Duration=\"0:0:0\" Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\" To=\"{Binding TemplateSettings.OpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"OpenOverlayLeft\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"OpenOverlayRight\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"OpenInlineLeft\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"OpenInlineRight\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"OpenCompactOverlayLeft\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     " <VisualState x:Name=\"OpenCompactOverlayRight\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     "   </VisualStateGroup>  " +
     "   <VisualStateGroup x:Name=\"OverlayVisibilityStates\">" +
     " <VisualState x:Name=\"OverlayNotVisible\" />" +
     " <VisualState x:Name=\"OverlayVisible\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Fill\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource SplitViewLightDismissOverlayBackground}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualState>" +
     "   </VisualStateGroup>  " +
     "  </VisualStateManager.VisualStateGroups> " +
     "  <Grid x:Name=\"PaneRoot\" Background=\"{TemplateBinding PaneBackground}\" Grid.ColumnSpan=\"2\" HorizontalAlignment=\"Left\" Visibility=\"Collapsed\" Width=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" Canvas.ZIndex=\"1\">" +
     "   <Grid.Clip> " +
     " <RectangleGeometry x:Name=\"PaneClipRectangle\"> " +
     "  <RectangleGeometry.Transform>  " +
     "   <CompositeTransform x:Name=\"PaneClipRectangleTransform\" />" +
     "  </RectangleGeometry.Transform> " +
     " </RectangleGeometry>" +
     "   </Grid.Clip>" +
     "   <Grid.RenderTransform>  " +
     " <CompositeTransform x:Name=\"PaneTransform\" />" +
     "   </Grid.RenderTransform> " +
     "  " +
     "   <Border Child=\"{TemplateBinding Pane}\" />  " +
     "  " +
     "   <Rectangle x:Name=\"HCPaneBorder\" Fill=\"{ThemeResource SystemControlForegroundTransparentBrush}\" HorizontalAlignment=\"Right\" Visibility=\"Collapsed\" Width=\"1\" x:DeferLoadStrategy=\"Lazy\" /> " +
     "  </Grid>" +
     "  <Grid x:Name=\"ContentRoot\" Grid.ColumnSpan=\"2\">  " +
     "   <Border Child=\"{TemplateBinding Content}\" />  " +
     "   <Rectangle x:Name=\"LightDismissLayer\" Fill=\"Transparent\" Visibility=\"Collapsed\" Height=\"0\" Width=\"0\" />" +
     "  </Grid>" +
     " </Grid> " +
     "   </ControlTemplate>" +
     "  </SplitView.Template> " +
     "  <SplitView.Pane>" +
     "   <Grid>" +
     " <Tools:DropShadowPanel x:Name=\"Shadow\" " +
     "   Grid.Column=\"1\"  " +
     "   BlurRadius=\"15\"  " +
     "   ShadowOpacity=\".5\"  " +
     "   OffsetX=\"{Binding ElementName=RootSplitView, Path=IsPaneOpen, Converter={StaticResource ShadowOffsetConvertor}}\" " +
     "   OffsetY=\".0\"  " +
     "   Margin=\"0 -10 0 -10\"" +
     "   HorizontalContentAlignment=\"Stretch\"  " +
     "   VerticalContentAlignment=\"Stretch\" " +
     "   Style=\"{StaticResource ShadowMenu}\"> " +
     "  " +
     "  <Grid x:Name=\"PaneContentGrid\"  " +
     " Padding=\"0 10 0 10\"> " +
     "   <Grid.RowDefinitions>" +
     " <RowDefinition Height=\"Auto\" />  " +
     " <RowDefinition x:Name=\"PaneContentGridToggleButtonRow\" Height=\"56\" />" +
     " <RowDefinition Height=\"Auto\" />  " +
     " <RowDefinition Height=\"*\" />  " +
     " <RowDefinition Height=\"Auto\" />  " +
     " <RowDefinition Height=\"Auto\" />  " +
     " <RowDefinition Height=\"Auto\" />  " +
     " <RowDefinition Height=\"8\" />  " +
     "   </Grid.RowDefinitions>  " +
     "   <Grid x:Name=\"ContentPaneTopPadding\" /> " +
     "   <Grid x:Name=\"AutoSuggestArea\" Height=\"40\" Grid.Row=\"2\" VerticalAlignment=\"Center\"> " +
     " <ContentControl x:Name=\"PaneAutoSuggestBoxPresenter\" Content=\"{TemplateBinding AutoSuggestBox}\" HorizontalContentAlignment=\"Stretch\" IsTabStop=\"False\" Margin=\"12,0,12,0\" VerticalContentAlignment=\"Center\" /> " +
     " <Button x:Name=\"PaneAutoSuggestButton\" Content=\"&#xE11A;\" MinHeight=\"40\" Style=\"{TemplateBinding PaneToggleButtonStyle}\" Visibility=\"Collapsed\" Width=\"{TemplateBinding CompactPaneLength}\" />  " +
     "   </Grid>  " +
     "   <NavigationViewList x:Name=\"MenuItemsHost\"  Visibility=\"Visible\" ItemContainerStyleSelector=\"{TemplateBinding MenuItemContainerStyleSelector}\" ItemContainerStyle=\"{TemplateBinding MenuItemContainerStyle}\" ItemTemplate=\"{TemplateBinding MenuItemTemplate}\" IsItemClickEnabled=\"True\" ItemsSource=\"{TemplateBinding MenuItemsSource}\" ItemTemplateSelector=\"{TemplateBinding MenuItemTemplateSelector}\" Margin=\"0,0,0,20\" Grid.Row=\"3\" SelectionMode=\"Single\" SelectedItem=\"{TemplateBinding SelectedItem}\" />  " +
     "  " +
     "   <Grid x:Name=\"MenuAdWrapper\"" +
     "   HorizontalAlignment=\"Left\"" +
     "   VerticalAlignment=\"Top\"" +
     "   Height=\"50\"" +
     "   Width=\"300\"" +
     "   Grid.Row=\"4\"  " +
     "   Margin=\"10 -10 0 5\">  " +
     "  " +
     " <!--<UI:AdControl x:Name=\"MenuAd\"  " +
     "   ApplicationId=\"9nblggh69j83\" " +
     "   AdUnitId=\"11701985\" " +
     "   Visibility=\"{TemplateBinding ShowAd}\" /> -->" +
     "  " +
     "   </Grid>  " +
     "   <!--{ Binding ElementName=RootSplitView, Path=IsPaneOpen, Converter={ StaticResource ShowAdConvertor }}-->" +
     "   <!--<Button IsEnabled=\"{TemplateBinding AlwaysShowHeader}\"" +
     "  x:Name=\"MenuAd\" " +
     "  " +
     "  Height=\"50\"  " +
     "  Width=\"300\"  " +
     "  Grid.Row=\"4\" " +
     "  Margin=\"10 -10 0 5\"/>--> " +
     "   <Border x:Name=\"FooterContentBorder\" Child=\"{TemplateBinding PaneFooter}\" Grid.Row=\"5\"/> " +
     "   <NavigationViewItem x:Name=\"SettingsNavPaneItem\" Grid.Row=\"6\">  " +
     "  " +
     " <NavigationViewItem.Icon>" +
     "  <SymbolIcon Symbol=\"Setting\" /> " +
     " </NavigationViewItem.Icon>" +
     "   </NavigationViewItem>" +
     "  </Grid>" +
     " </Tools:DropShadowPanel>" +
     "   </Grid> " +
     "  </SplitView.Pane> " +
     "  " +
     "  <Grid x:Name=\"ContentGrid\"> " +
     "   <Grid.RowDefinitions>  " +
     " <RowDefinition Height=\"Auto\" />  " +
     " <RowDefinition Height=\"*\"/> " +
     "   </Grid.RowDefinitions> " +
     "   <ContentControl x:Name=\"HeaderContent\" Height=\"32\" ContentTemplate=\"{TemplateBinding HeaderTemplate}\" Content=\"{TemplateBinding Header}\" HorizontalContentAlignment=\"Stretch\" IsTabStop=\"False\" MinHeight=\"32\" MaxHeight=\"32\" VerticalContentAlignment=\"Stretch\"  Background=\"{ThemeResource SystemControlAcrylicWindowMediumHighBrush}\"/>" +
     "   <ContentPresenter Content=\"{TemplateBinding Content}\" Grid.Row=\"1\"/>" +
     "  </Grid>  " +
     " </SplitView> " +
     "   </Grid> " +
     "  </ControlTemplate>" +
     " </Setter.Value> " +
     "   </Setter>  " +
     "  </Style> " +
     "  " +
     "  <StaticResource x:Key=\"NavigationViewExpandedPaneBackground\" ResourceKey=\"SystemControlChromeMediumLowAcrylicWindowMediumBrush\"/>  " +
     "  " +
     "  <Style x:Key=\"BaseTextBlockStyle\" TargetType=\"TextBlock\">  " +
     "   <Setter Property=\"FontFamily\" Value=\"XamlAutoFontFamily\"/> " +
     "   <Setter Property=\"FontWeight\" Value=\"SemiBold\"/>  " +
     "   <Setter Property=\"FontSize\" Value=\"15\"/> " +
     "   <Setter Property=\"TextTrimming\" Value=\"None\"/> " +
     "   <Setter Property=\"TextWrapping\" Value=\"Wrap\"/> " +
     "   <Setter Property=\"LineStackingStrategy\" Value=\"MaxHeight\"/>" +
     "   <Setter Property=\"TextLineBounds\" Value=\"Full\"/>  " +
     "  </Style> " +
     "  " +
     "  <Style x:Key=\"TitleTextBlockStyle\" BasedOn=\"{StaticResource BaseTextBlockStyle}\" TargetType=\"TextBlock\"> " +
     "   <Setter Property=\"FontWeight\" Value=\"SemiLight\"/> " +
     "   <Setter Property=\"FontSize\" Value=\"24\"/> " +
     "   <Setter Property=\"OpticalMarginAlignment\" Value=\"TrimSideBearings\"/>" +
     "  </Style> " +
     "  " +
     "  <Style x:Key=\"PaneToggleButtonStyle\" TargetType=\"Button\">  " +
     "   <Setter Property=\"FontSize\" Value=\"16\"/> " +
     "   <Setter Property=\"FontFamily\" Value=\"{StaticResource SymbolThemeFontFamily}\"/>  " +
     "   <Setter Property=\"MinHeight\" Value=\"{StaticResource PaneToggleButtonSize}\"/> " +
     "   <Setter Property=\"MinWidth\" Value=\"{StaticResource PaneToggleButtonSize}\"/>  " +
     "   <Setter Property=\"Padding\" Value=\"0\"/>" +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Left\"/>" +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Top\"/>" +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Center\"/>" +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Center\"/>  " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource NavigationViewItemBackground}\"/>  " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource NavigationViewItemForeground}\"/>  " +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrush}\"/>" +
     "   <Setter Property=\"BorderThickness\" Value=\"{ThemeResource NavigationViewToggleBorderThickness}\"/>  " +
     "   <Setter Property=\"Content\" Value=\"&#xE700;\"/>  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Button\">  " +
     "   <Grid x:Name=\"LayoutRoot\" Background=\"{TemplateBinding Background}\" Height=\"{TemplateBinding MinHeight}\" Margin=\"{TemplateBinding Padding}\" Width=\"{TemplateBinding MinWidth}\">" +
     " <VisualStateManager.VisualStateGroups>  " +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\"/>" +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.(RevealBrush.State)\" Value=\"PointerOver\"/>" +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundPointerOver}\"/> " +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushPointerOver}\"/>" +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundPointerOver}\"/> " +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "   <VisualState x:Name=\"Pressed\">" +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.(RevealBrush.State)\" Value=\"Pressed\"/> " +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundPressed}\"/>  " +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushPressed}\"/> " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundPressed}\"/>  " +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundDisabled}\"/> " +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushDisabled}\"/>" +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundDisabled}\"/> " +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "   <VisualState x:Name=\"Checked\">" +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundChecked}\"/>  " +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushChecked}\"/> " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundChecked}\"/>  " +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "   <VisualState x:Name=\"CheckedPointerOver\"> " +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.(RevealBrush.State)\" Value=\"PointerOver\"/>" +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundCheckedPointerOver}\"/>" +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushCheckedPointerOver}\"/>  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundCheckedPointerOver}\"/>" +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "   <VisualState x:Name=\"CheckedPressed\">  " +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.(RevealBrush.State)\" Value=\"Pressed\"/> " +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundCheckedPressed}\"/> " +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushCheckedPressed}\"/>" +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundCheckedPressed}\"/> " +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "   <VisualState x:Name=\"CheckedDisabled\"> " +
     " <VisualState.Setters> " +
     "  <Setter Target=\"LayoutRoot.Background\" Value=\"{ThemeResource NavigationViewItemBackgroundCheckedDisabled}\"/>" +
     "  <Setter Target=\"RevealBorder.BorderBrush\" Value=\"{ThemeResource NavigationViewItemBorderBrushCheckedDisabled}\"/>  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource NavigationViewItemForegroundCheckedDisabled}\"/>" +
     " </VisualState.Setters>" +
     "   </VisualState>" +
     "  </VisualStateGroup>  " +
     " </VisualStateManager.VisualStateGroups> " +
     " <Viewbox x:Name=\"IconHost\" AutomationProperties.AccessibilityView=\"Raw\" HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\" Height=\"16\" VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" Width=\"16\"> " +
     "  <ContentPresenter x:Name=\"ContentPresenter\" AutomationProperties.AccessibilityView=\"Raw\" Content=\"{TemplateBinding Content}\" FontSize=\"{TemplateBinding FontSize}\"/>  " +
     " </Viewbox>" +
     " <Border x:Name=\"RevealBorder\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\"/>" +
     "   </Grid> " +
     "  </ControlTemplate>" +
     " </Setter.Value> " +
     "   </Setter>  " +
     "  </Style> " +
     "  " +
     "  <Style x:Key=\"DefaultSplitView\" TargetType=\"SplitView\"> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Stretch\"/>  " +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Stretch\"/> " +
     "   <Setter Property=\"OpenPaneLength\" Value=\"{ThemeResource SplitViewOpenPaneThemeLength}\"/> " +
     "   <Setter Property=\"CompactPaneLength\" Value=\"{ThemeResource SplitViewCompactPaneThemeLength}\"/> " +
     "   <Setter Property=\"PaneBackground\" Value=\"{ThemeResource SystemControlPageBackgroundChromeLowBrush}\"/>" +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"SplitView\">  " +
     "   <Grid Background=\"{TemplateBinding Background}\">" +
     " <Grid.ColumnDefinitions>  " +
     "  <ColumnDefinition x:Name=\"ColumnDefinition1\" Width=\"{Binding TemplateSettings.OpenPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\"/> " +
     "  <ColumnDefinition x:Name=\"ColumnDefinition2\" Width=\"*\"/>" +
     " </Grid.ColumnDefinitions>" +
     " <VisualStateManager.VisualStateGroups>  " +
     "  <VisualStateGroup x:Name=\"DisplayModeStates\"> " +
     "   <VisualStateGroup.Transitions>  " +
     " <VisualTransition From=\"Closed\" To=\"OpenOverlayLeft\">  " +
     "  <Storyboard>" +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"1.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"Closed\" To=\"OpenOverlayRight\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"1.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"ClosedCompactLeft\" To=\"OpenCompactOverlayLeft\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"1.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"ClosedCompactRight\" To=\"OpenCompactOverlayRight\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.35\" Value=\"1.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"OpenOverlayLeft\" To=\"Closed\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"0.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"OpenOverlayRight\" To=\"Closed\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneTransform\" Storyboard.TargetProperty=\"TranslateX\">" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"0.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"OpenCompactOverlayLeft\" To=\"ClosedCompactLeft\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.NegativeOpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"0.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"OpenCompactOverlayRight\" To=\"ClosedCompactRight\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"{Binding TemplateSettings.OpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1.0\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.12\" Value=\"0.0\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     "   </VisualStateGroup.Transitions>  " +
     "   <VisualState x:Name=\"Closed\" />" +
     "   <VisualState x:Name=\"ClosedCompactLeft\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0:0:0\" Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\" To=\"{Binding TemplateSettings.NegativeOpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"ClosedCompactRight\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"2\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0:0:0\" Storyboard.TargetName=\"PaneClipRectangleTransform\" Storyboard.TargetProperty=\"TranslateX\" To=\"{Binding TemplateSettings.OpenPaneLengthMinusCompactLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OpenOverlayLeft\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OpenOverlayRight\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OpenInlineLeft\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OpenInlineRight\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.OpenPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OpenCompactOverlayLeft\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.Column)\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OpenCompactOverlayRight\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition1\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"*\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ColumnDefinition2\" Storyboard.TargetProperty=\"Width\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactPaneGridLength, FallbackValue=0, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"(Grid.ColumnSpan)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PaneRoot\" Storyboard.TargetProperty=\"HorizontalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Right\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"HorizontalAlignment\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Left\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HCPaneBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Visibility\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"OverlayVisibilityStates\"> " +
     "   <VisualState x:Name=\"OverlayNotVisible\" /> " +
     "   <VisualState x:Name=\"OverlayVisible\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"LightDismissLayer\" Storyboard.TargetProperty=\"Fill\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource SplitViewLightDismissOverlayBackground}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <Grid x:Name=\"PaneRoot\" Background=\"{TemplateBinding PaneBackground}\" Grid.ColumnSpan=\"2\" HorizontalAlignment=\"Left\" Visibility=\"Collapsed\" Width=\"{Binding TemplateSettings.OpenPaneLength, RelativeSource={RelativeSource Mode=TemplatedParent}}\" Canvas.ZIndex=\"1\"> " +
     "  <Grid.Clip>  " +
     "   <RectangleGeometry x:Name=\"PaneClipRectangle\">  " +
     " <RectangleGeometry.Transform>" +
     "  <CompositeTransform x:Name=\"PaneClipRectangleTransform\" /> " +
     " </RectangleGeometry.Transform>  " +
     "   </RectangleGeometry> " +
     "  </Grid.Clip> " +
     "  <Grid.RenderTransform>" +
     "   <CompositeTransform x:Name=\"PaneTransform\" /> " +
     "  </Grid.RenderTransform>  " +
     "  " +
     "  <Border Child=\"{TemplateBinding Pane}\" />" +
     "  " +
     "  <Rectangle x:Name=\"HCPaneBorder\" Fill=\"{ThemeResource SystemControlForegroundTransparentBrush}\" HorizontalAlignment=\"Right\" Visibility=\"Collapsed\" Width=\"1\" x:DeferLoadStrategy=\"Lazy\" />  " +
     " </Grid> " +
     " <Grid x:Name=\"ContentRoot\" Grid.ColumnSpan=\"2\">" +
     "  <Border Child=\"{TemplateBinding Content}\" />" +
     "  <Rectangle x:Name=\"LightDismissLayer\" Fill=\"Transparent\" Visibility=\"Collapsed\" /> " +
     " </Grid> " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style x:Name=\"ShadowMenu\" TargetType=\"Tools:DropShadowPanel\">  " +
     "   <Setter Property=\"IsTabStop\"" +
     "  Value=\"False\" />  " +
     "  " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" /> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Left\" />" +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Stretch\" />" +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Stretch\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Tools:DropShadowPanel\">" +
     "   <Grid Background=\"{TemplateBinding Background}\"  " +
     "   BorderBrush=\"{TemplateBinding BorderBrush}\" " +
     "   BorderThickness=\"{TemplateBinding BorderThickness}\"  " +
     "   HorizontalAlignment=\"{TemplateBinding HorizontalAlignment}\"" +
     "   VerticalAlignment=\"{TemplateBinding VerticalAlignment}\">  " +
     "  " +
     " <Border x:Name=\"ShadowElement\"" +
     "   HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\"  " +
     "   VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" />" +
     " <ContentPresenter HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\"" +
     " VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" />  " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"Control:InAppNotifyMVVM\">  " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource SystemControlBackgroundChromeMediumBrush}\" />" +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource ApplicationForegroundThemeBrush}\" />" +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource SystemControlBackgroundAccentBrush}\" />  " +
     "   <Setter Property=\"BorderThickness\" Value=\"2\" />  " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Bottom\" /> " +
     "   <Setter Property=\"MinHeight\" Value=\"55\" /> " +
     "   <Setter Property=\"FontSize\" Value=\"15\" />  " +
     "   <Setter Property=\"Visibility\" Value=\"Collapsed\" />  " +
     "   <Setter Property=\"RenderTransformOrigin\" Value=\"0.5,1\" /> " +
     "   <Setter Property=\"Margin\" Value=\"20 0\" />  " +
     "   <Setter Property=\"Padding\" Value=\"25 10\" />" +
     "   <Setter Property=\"MaxWidth\" Value=\"1200\" />" +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Control:InAppNotifyMVVM\"> " +
     "   <Grid>" +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"State\"> " +
     "   <VisualState x:Name=\"Collapsed\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=\"(UIElement.RenderTransform).(CompositeTransform.ScaleY)\"  " +
     "   Storyboard.TargetName=\"RootGrid\"> " +
     "  " +
     "   <EasingDoubleKeyFrame KeyTime=\"0\" " +
     " Value=\"1\" /> " +
     "  " +
     "   <EasingDoubleKeyFrame KeyTime=\"0:0:0.1\" " +
     " Value=\"0\" /> " +
     "  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"(UIElement.Visibility)\"  " +
     "   Storyboard.TargetName=\"RootGrid\"> " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\">" +
     "  " +
     " <DiscreteObjectKeyFrame.Value>  " +
     "  <Visibility> Visible </Visibility> " +
     " </DiscreteObjectKeyFrame.Value> " +
     "  " +
     "   </DiscreteObjectKeyFrame>  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0.1\">" +
     "  " +
     " <DiscreteObjectKeyFrame.Value>  " +
     "  <Visibility> Collapsed </Visibility>  " +
     " </DiscreteObjectKeyFrame.Value> " +
     "  " +
     "   </DiscreteObjectKeyFrame>  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Visible\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=\"(UIElement.RenderTransform).(CompositeTransform.ScaleY)\"  " +
     "   Storyboard.TargetName=\"RootGrid\"> " +
     "  " +
     "   <EasingDoubleKeyFrame KeyTime=\"0\" " +
     " Value=\"0\" /> " +
     "  " +
     "   <EasingDoubleKeyFrame KeyTime=\"0:0:0.1\" " +
     " Value=\"1\" /> " +
     "  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <Grid x:Name=\"RootGrid\" " +
     " RenderTransformOrigin=\"{TemplateBinding RenderTransformOrigin}\" " +
     " Margin=\"{TemplateBinding Margin}\" " +
     " MaxWidth=\"{TemplateBinding MaxWidth}\"" +
     " Visibility=\"{TemplateBinding Visibility}\">" +
     "  " +
     "  <Grid.RenderTransform>" +
     "   <CompositeTransform />" +
     "  </Grid.RenderTransform>  " +
     "  " +
     "  <Tools:DropShadowPanel BlurRadius=\"15\"  " +
     " ShadowOpacity=\"0.95\"  " +
     " OffsetX=\"0.0\"" +
     " OffsetY=\"0.0\"" +
     " HorizontalContentAlignment=\"Stretch\" " +
     " VerticalContentAlignment=\"Stretch\"> " +
     "  " +
     "   <Grid Background=\"{TemplateBinding Background}\"  " +
     "   Padding=\"{TemplateBinding Padding}\"> " +
     "  " +
     " <Grid.ColumnDefinitions>  " +
     "  <ColumnDefinition Width=\"*\" />  " +
     "  <ColumnDefinition Width=\"Auto\" />  " +
     " </Grid.ColumnDefinitions> " +
     "  " +
     " <ContentPresenter HorizontalAlignment=\"{TemplateBinding HorizontalAlignment}\" " +
     " HorizontalContentAlignment=\"Stretch\" " +
     " VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\"  " +
     " VerticalContentAlignment=\"Center\" " +
     " TextWrapping=\"WrapWholeWords\" />  " +
     "  " +
     " <Button x:Name=\"PART_DismissButton\" " +
     "   Grid.Column=\"1\"  " +
     "   Visibility=\"Visible\"" +
     "   Margin=\"10 0 -10 0\" " +
     "   FontSize=\"12\" " +
     "   Style=\"{StaticResource DismissTextBlockButtonStyle}\" " +
     "   Content=\"&#xE894;\"  " +
     "   FontFamily=\"Segoe MDL2 Assets\"  " +
     "   AutomationProperties.Name=\"Dismiss\" />" +
     "   </Grid>  " +
     "  </Tools:DropShadowPanel>  " +
     " </Grid>" +
     "   </Grid> " +
     "  </ControlTemplate>" +
     " </Setter.Value> " +
     "   </Setter>  " +
     "  </Style> " +
     "  " +
     "  <Style x:Key=\"DismissTextBlockButtonStyle\" TargetType=\"ButtonBase\"> " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource HyperlinkButtonBackground}\" />" +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource ApplicationForegroundThemeBrush}\" />" +
     "   <Setter Property=\"MinWidth\" Value=\"0\" />" +
     "   <Setter Property=\"MinHeight\" Value=\"0\" />  " +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"ButtonBase\">  " +
     "   <Grid Margin=\"{TemplateBinding Padding}\" Background=\"{TemplateBinding Background}\"> " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <Storyboard>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"Foreground\"  " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"Red\" />" +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"Background\"  " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonBackgroundPointerOver}\" />  " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"BorderBrush\" " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonBorderBrushPointerOver}\" /> " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <Storyboard>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"Foreground\"  " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"DarkRed\" />  " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"Background\"  " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonBackgroundPressed}\" />" +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"BorderBrush\" " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonBorderBrushPressed}\" />  " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <Storyboard>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"Foreground\"  " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonForegroundDisabled}\" />  " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"Background\"  " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonBackgroundDisabled}\" />  " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty=\"BorderBrush\" " +
     "   Storyboard.TargetName=\"Text\">  " +
     "  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\"  " +
     "   Value=\"{ThemeResource HyperlinkButtonBorderBrushDisabled}\" /> " +
     "  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <ContentPresenter x:Name=\"Text\"  " +
     " VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\"  " +
     " HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\" " +
     " Content=\"{TemplateBinding Content}\" />  " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style x:Name=\"Shadow\" TargetType=\"Tools:DropShadowPanel\">" +
     "   <Setter Property=\"BlurRadius\" Value=\"15\" />" +
     "   <Setter Property=\"ShadowOpacity\" Value=\"0.5\" />  " +
     "   <Setter Property=\"OffsetX\" Value=\".0\" />" +
     "   <Setter Property=\"OffsetY\" Value=\"-3.0\" /> " +
     "   <Setter Property=\"Margin\" Value=\"-20 0 -20 0\" /> " +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"Control:ShadowCheckBox\">" +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource CheckBoxBackgroundUnchecked}\" /> " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource CheckBoxForegroundUnchecked}\" /> " +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource SystemControlBackgroundListMediumRevealBorderBrush}\" /> " +
     "   <Setter Property=\"Padding\" Value=\"8,5,0,0\" /> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Left\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Center\" /> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Left\" />" +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Top\" />" +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\" />  " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\" />" +
     "   <Setter Property=\"MinWidth\" Value=\"120\" /> " +
     "   <Setter Property=\"MinHeight\" Value=\"32\" /> " +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"FocusVisualMargin\" Value=\"-7,-3,-7,-3\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Control:ShadowCheckBox\">  " +
     "   <Grid x:Name=\"RootGrid\" Background=\"{TemplateBinding Background}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\">" +
     " <Grid.ColumnDefinitions>  " +
     "  <ColumnDefinition Width=\"20\" /> " +
     "  <ColumnDefinition Width=\"*\" />  " +
     " </Grid.ColumnDefinitions> " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CombinedStates\"> " +
     "   <VisualState x:Name=\"UncheckedNormal\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUnchecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUnchecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUnchecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUnchecked}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUnchecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUnchecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"10\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"UncheckedPointerOver\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUncheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUncheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUncheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUncheckedPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUncheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUncheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"10\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"UncheckedPressed\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUncheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUncheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUncheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUncheckedPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUncheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUncheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"StrokeThickness\" To=\"{ThemeResource CheckBoxCheckedStrokeThickness}\" />  " +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"10\" />  " +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"UncheckedDisabled\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUncheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUncheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUncheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUncheckedDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUncheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUncheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedNormal\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundChecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundChecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushChecked}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeChecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillChecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundChecked}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"StrokeThickness\" To=\"{ThemeResource CheckBoxCheckedStrokeThickness}\" />  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"10\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedPointerOver\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundCheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundCheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushCheckedPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeCheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillCheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundCheckedPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"10\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedPressed\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundCheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundCheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushCheckedPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeCheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillCheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundCheckedPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"StrokeThickness\" To=\"{ThemeResource CheckBoxCheckedStrokeThickness}\" />  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"10\" />  " +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedDisabled\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundCheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundCheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushCheckedDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeCheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillCheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundCheckedDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminateNormal\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminate}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminate}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminate}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminate}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminate}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminate}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"10\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminatePointerOver\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminatePointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminatePointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminatePointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminatePointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminatePointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminatePointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"10\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminatePressed\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminatePressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminatePressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminatePressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminatePressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminatePressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminatePressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"10\" />  " +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminateDisabled\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminateDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminateDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminateDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminateDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminateDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminateDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <Grid Height=\"32\" VerticalAlignment=\"Top\">  " +
     "  " +
     "  <Tools:DropShadowPanel x:Name=\"Shadow\"" +
     " BlurRadius=\"15\" " +
     " Color=\"Black\"" +
     " Height=\"20\"  " +
     " Width=\"20\"" +
     " ShadowOpacity=\".5\" " +
     " OffsetX=\"0\"  " +
     " OffsetY=\".0\" " +
     " HorizontalContentAlignment=\"Stretch\" " +
     " VerticalContentAlignment=\"Stretch\"" +
     " Style=\"{StaticResource ShadowMenu}\">" +
     "  " +
     "   <Grid x:Name=\"BackgroundLayer\" Height=\"20\" Width=\"20\" Background=\"{ThemeResource SystemControlAcrylicWindowBrush}\">  " +
     " <Rectangle x:Name=\"NormalRectangle\" Fill=\"{ThemeResource CheckBoxCheckBackgroundFillUnchecked}\" Height=\"20\" StrokeThickness=\"{ThemeResource CheckBoxBorderThemeThickness}\" Stroke=\"{ThemeResource CheckBoxCheckBackgroundStrokeUnchecked}\" UseLayoutRounding=\"False\" Width=\"20\" />  " +
     "   </Grid>  " +
     "  </Tools:DropShadowPanel>  " +
     "  " +
     "  <FontIcon x:Name=\"CheckGlyph\" FontFamily=\"{ThemeResource SymbolThemeFontFamily}\" Foreground=\"{ThemeResource CheckBoxCheckGlyphForegroundUnchecked}\" FontSize=\"20\" Glyph=\"&#xE001;\" Opacity=\"0\" />  " +
     " </Grid> " +
     " <ContentPresenter x:Name=\"ContentPresenter\" AutomationProperties.AccessibilityView=\"Raw\" ContentTemplate=\"{TemplateBinding ContentTemplate}\" Content=\"{TemplateBinding Content}\" ContentTransitions=\"{TemplateBinding ContentTransitions}\" Grid.Column=\"1\" HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\" Margin=\"{TemplateBinding Padding}\" TextWrapping=\"Wrap\" VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" />" +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"Control:MainPageButton\">" +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource ButtonRevealBackground}\" />" +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource ButtonForeground}\" />" +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrush}\" /> " +
     "   <Setter Property=\"BorderThickness\" Value=\"2\" />  " +
     "   <Setter Property=\"Padding\" Value=\"8,4,8,4\" /> " +
     "   <Setter Property=\"Margin\" Value=\"3\" />  " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Stretch\" />" +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\" />  " +
     "   <Setter Property=\"FontWeight\" Value=\"Normal\" />  " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\" />" +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"FocusVisualMargin\" Value=\"-3\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Control:MainPageButton\">  " +
     "   <Grid x:Name=\"Container\" Background=\"Transparent\"> " +
     "  " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\"> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"FilterGrid.Background\" Value=\"#00000000\" />" +
     " </VisualState.Setters> " +
     "  " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"RootGrid\" />  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"15\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     "  <!--<ColorAnimation Storyboard.TargetProperty=\"(Button.Background).(SolidColorBrush.Color)\" Storyboard.TargetName=\"FilterGrid\" Duration=\"0:0:0.25\" From=\"{ThemeResource ButtonFilterGridHover}\" To=\"#00000000\" EnableDependentAnimation=\"True\" /> -->  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"RootGrid.(RevealBrush.State)\" Value=\"PointerOver\" />" +
     "  <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource ButtonRevealBackgroundPointerOver}\" /> " +
     "  <Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrush}\" />  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundPointerOver}\" />  " +
     "  <Setter Target=\"FilterGrid.Background\" Value=\"{ThemeResource ButtonFilterGridHover}\" />  " +
     " </VisualState.Setters> " +
     "  " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"RootGrid\" />  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"15\" EnableDependentAnimation=\"True\" />" +
     "  <!--<ColorAnimation Storyboard.TargetProperty=\"(Button.Background).(SolidColorBrush.Color)\" Storyboard.TargetName=\"FilterGrid\" Duration=\"0:0:0.25\" From=\"#00000000\" To=\"{ThemeResource ButtonFilterGridHover}\" EnableDependentAnimation=\"True\" /> -->  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"RootGrid.(RevealBrush.State)\" Value=\"Pressed\" /> " +
     "  <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource ButtonRevealBackgroundPressed}\" />  " +
     "  <Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBackgroundPressed}\" />  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundPressed}\" />" +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"15\" />  " +
     "  <Setter Target=\"FilterGrid.Background\" Value=\"{ThemeResource ButtonFilterGridHover}\" />  " +
     " </VisualState.Setters> " +
     "  " +
     " <Storyboard>  " +
     "  <PointerDownThemeAnimation Storyboard.TargetName=\"Container\" />  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     "  <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource ButtonRevealBackgroundDisabled}\" /> " +
     "  <Setter Target=\"ContentPresenter.BorderBrush\" Value=\"{ThemeResource ButtonRevealBorderBrushDisabled}\" />" +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource ButtonForegroundDisabled}\" />  " +
     "  <Setter Target=\"FilterGrid.Background\" Value=\"#00000000\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  " +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <Tools:DropShadowPanel x:Name=\"Shadow\" " +
     "   BlurRadius=\"15\"  " +
     "   Color=\"Black\" " +
     "   ShadowOpacity=\".5\"  " +
     "   OffsetX=\"0\"" +
     "   OffsetY=\".0\"  " +
     "   HorizontalContentAlignment=\"Stretch\"  " +
     "   VerticalContentAlignment=\"Stretch\" " +
     "   Style=\"{StaticResource ShadowMenu}\"> " +
     "  " +
     "  <Grid x:Name=\"BackgroundLayer\" Background=\"{ThemeResource SystemControlAcrylicElementBrush}\"> " +
     "   <!--SystemControlAcrylicWindowBrush--> " +
     "   <Grid x:Name=\"RootGrid\" Background=\"{TemplateBinding Background}\">" +
     " <Grid x:Name=\"FilterGrid\" Background=\"#00000000\"> " +
     "  <ContentPresenter x:Name=\"ContentPresenter\" " +
     "  BorderBrush=\"{TemplateBinding BorderBrush}\"  " +
     "  BorderThickness=\"{TemplateBinding BorderThickness}\"" +
     "  Content=\"{TemplateBinding Content}\" " +
     "  ContentTransitions=\"{TemplateBinding ContentTransitions}\"" +
     "  ContentTemplate=\"{TemplateBinding ContentTemplate}\"" +
     "  Padding=\"{TemplateBinding Padding}\" " +
     "  HorizontalContentAlignment=\"{TemplateBinding HorizontalContentAlignment}\"  " +
     "  VerticalContentAlignment=\"{TemplateBinding VerticalContentAlignment}\"" +
     "  AutomationProperties.AccessibilityView=\"Raw\" /> " +
     " </Grid> " +
     "   </Grid>  " +
     "  </Grid>" +
     " </Tools:DropShadowPanel>" +
     "   </Grid> " +
     "  </ControlTemplate>" +
     " </Setter.Value> " +
     "   </Setter>  " +
     "  </Style> " +
     "  " +
     "  <Style x:Key=\"PageHeaderButton\" TargetType=\"Button\"> " +
     "   <Setter Property=\"IsTabStop\" Value=\"False\" /> " +
     "   <Setter Property=\"Background\" Value=\"Transparent\" />" +
     "   <Setter Property=\"BorderThickness\" Value=\"0\" />  " +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\" />  " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\" />" +
     "   <Setter Property=\"FontWeight\" Value=\"SemiBold\" />" +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource SystemControlForegroundBaseHighBrush}\" /> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" /> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Right\" />  " +
     "   <Setter Property=\"Padding\" Value=\"0,0,9,0\" /> " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Button\">" +
     "   <Grid>" +
     " <ContentPresenter " +
     "  x:Name=\"ContentPresenter\"  " +
     "  Padding=\"{TemplateBinding Padding}\" " +
     "  HorizontalContentAlignment=\"{TemplateBinding HorizontalContentAlignment}\"  " +
     "  VerticalContentAlignment=\"{TemplateBinding VerticalContentAlignment}\"" +
     "  AutomationProperties.AccessibilityView=\"Raw\" " +
     "  Background=\"{TemplateBinding Background}\" " +
     "  BorderBrush=\"{TemplateBinding BorderBrush}\"  " +
     "  BorderThickness=\"{TemplateBinding BorderThickness}\"" +
     "  ContentTemplate=\"{TemplateBinding ContentTemplate}\"" +
     "  ContentTransitions=\"{TemplateBinding ContentTransitions}\" />" +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentPresenter.Background\" Value=\"{ThemeResource SystemControlHighlightListLowBrush}\" /> " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource SystemControlHighlightAltBaseHighBrush}\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentPresenter.Background\" Value=\"{ThemeResource SystemControlHighlightListMediumBrush}\" /> " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentPresenter.Foreground\" Value=\"{ThemeResource SystemControlDisabledBaseLowBrush}\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Stretch\" />" +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Top\" />" +
     "   <Setter Property=\"Width\" Value=\"{ThemeResource AppBarExpandButtonThemeWidth}\" />  " +
     "  </Style>  " +
     "  " +
     "  <Style x:Key=\"ShadowPageHeader\" TargetType=\"T10Controls:PageHeader\">  " +
     "   <Setter Property=\"BackButtonVisibility\" Value=\"Collapsed\" /> " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource SystemControlBackgroundChromeMediumBrush}\" />" +
     "   <Setter Property=\"ClosedDisplayMode\" Value=\"Compact\" />" +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource TextStyleLargeFontSize}\" />  " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource SystemControlForegroundBaseHighBrush}\" /> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" /> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Left\" />" +
     "   <Setter Property=\"IsTabStop\" Value=\"False\" /> " +
     "  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"T10Controls:PageHeader\">  " +
     "   <Grid x:Name=\"LayoutRoot\" Background=\"{TemplateBinding Background}\"> " +
     " <Grid.Clip>" +
     "  <RectangleGeometry Rect=\"{Binding TemplateSettings.ClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\">  " +
     "   <RectangleGeometry.Transform> " +
     " <TranslateTransform x:Name=\"ClipGeometryTransform\" Y=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </RectangleGeometry.Transform>" +
     "  </RectangleGeometry>  " +
     " </Grid.Clip>  " +
     " <Grid " +
     "  x:Name=\"ContentRoot\" " +
     "  Height=\"{TemplateBinding Height}\"" +
     "  Margin=\"{TemplateBinding Padding}\"  " +
     "  VerticalAlignment=\"Top\" " +
     "  Background=\"{TemplateBinding Background}\" " +
     "  Opacity=\"{TemplateBinding Opacity}\">  " +
     "  <Grid.ColumnDefinitions> " +
     "   <ColumnDefinition Width=\"Auto\" /> " +
     "   <ColumnDefinition Width=\"Auto\" /> " +
     "   <ColumnDefinition Width=\"*\" /> " +
     "   <ColumnDefinition Width=\"Auto\" /> " +
     "  </Grid.ColumnDefinitions>" +
     "  <Grid.RenderTransform>" +
     "   <TranslateTransform x:Name=\"ContentTransform\" /> " +
     "  </Grid.RenderTransform>  " +
     "  <Grid Grid.Column=\"2\">" +
     "   <Grid.ColumnDefinitions>" +
     " <ColumnDefinition Width=\"*\" />" +
     " <ColumnDefinition Width=\"Auto\" />" +
     "   </Grid.ColumnDefinitions>  " +
     "   <ContentControl " +
     " x:Name=\"ContentControl\"  " +
     " Grid.Column=\"0\" " +
     " Height=\"{ThemeResource AppBarThemeCompactHeight}\"" +
     " Margin=\"16,0,0,0\"  " +
     " VerticalAlignment=\"Top\"  " +
     " HorizontalContentAlignment=\"{TemplateBinding HorizontalContentAlignment}\"" +
     " VerticalContentAlignment=\"{TemplateBinding VerticalContentAlignment}\" " +
     " Content=\"{TemplateBinding Content}\"  " +
     " ContentTemplate=\"{TemplateBinding ContentTemplate}\" " +
     " ContentTransitions=\"{TemplateBinding ContentTransitions}\" " +
     " FontFamily=\"{TemplateBinding FontFamily}\"  " +
     " FontSize=\"{TemplateBinding FontSize}\"" +
     " FontStretch=\"{TemplateBinding FontStretch}\"" +
     " FontStyle=\"{TemplateBinding FontStyle}\" " +
     " FontWeight=\"{TemplateBinding FontWeight}\"  " +
     " Foreground=\"{TemplateBinding Foreground}\"  " +
     " IsTabStop=\"False\" />  " +
     "   <ItemsControl" +
     " x:Name=\"PrimaryItemsControl\"" +
     " Grid.Column=\"1\" " +
     " MinHeight=\"{ThemeResource AppBarThemeMinHeight}\" " +
     " HorizontalAlignment=\"Right\" " +
     " IsTabStop=\"False\"  " +
     " Visibility=\"{TemplateBinding PrimaryCommandsVisibility}\">" +
     " <!--Width=\"{TemplateBinding ContentWidth}\"--> " +
     " <ItemsControl.ItemsPanel> " +
     "  <ItemsPanelTemplate>  " +
     "   <StackPanel Orientation=\"Horizontal\" /> " +
     "  </ItemsPanelTemplate> " +
     " </ItemsControl.ItemsPanel>" +
     "   </ItemsControl>" +
     "  </Grid>" +
     "  " +
     "  <Button " +
     "   x:Name=\"MoreButton\" " +
     "   Grid.Column=\"3\"  " +
     "   MinHeight=\"{ThemeResource AppBarThemeCompactHeight}\" " +
     "   Padding=\"16,23,16,0\"" +
     "   VerticalAlignment=\"Top\"" +
     "   Foreground=\"{TemplateBinding Foreground}\"" +
     "   IsTabStop=\"True\" " +
     "   Style=\"{StaticResource PageHeaderButton}\"> " +
     "   <FontIcon " +
     " x:Name=\"EllipsisIcon\" " +
     " Height=\"{ThemeResource AppBarExpandButtonCircleDiameter}\" " +
     " VerticalAlignment=\"Center\"  " +
     " FontFamily=\"{ThemeResource SymbolThemeFontFamily}\"  " +
     " FontSize=\"16\"" +
     " Foreground=\"{TemplateBinding Foreground}\"  " +
     " Glyph=\"&#xE10C;\" />" +
     "  </Button> " +
     "  <Popup x:Name=\"OverflowPopup\"> " +
     "   <Popup.RenderTransform> " +
     " <TranslateTransform x:Name=\"OverflowPopupOffsetTransform\" />" +
     "   </Popup.RenderTransform>" +
     "   <Grid  " +
     " x:Name=\"OverflowContentRoot\"" +
     " MinWidth=\"{Binding CommandBarTemplateSettings.OverflowContentMinWidth, RelativeSource={RelativeSource Mode=TemplatedParent}}\"  " +
     " MaxHeight=\"{Binding CommandBarTemplateSettings.OverflowContentMaxHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\"> " +
     " <Grid.Clip>" +
     "  <RectangleGeometry x:Name=\"OverflowContentRootClip\" />  " +
     " </Grid.Clip>  " +
     " <Grid.RenderTransform> " +
     "  <TranslateTransform x:Name=\"OverflowContentRootTransform\" X=\"{Binding CommandBarTemplateSettings.OverflowContentHorizontalOffset, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " </Grid.RenderTransform>" +
     " <CommandBarOverflowPresenter  " +
     "  x:Name=\"SecondaryItemsControl\"" +
     "  IsEnabled=\"False\" " +
     "  IsTabStop=\"False\" " +
     "  Style=\"{TemplateBinding CommandBarOverflowPresenterStyle}\">" +
     "  <CommandBarOverflowPresenter.ItemContainerStyle> " +
     "   <Style TargetType=\"FrameworkElement\">  " +
     " <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" />" +
     " <Setter Property=\"Width\" Value=\"NaN\" />" +
     "   </Style> " +
     "  </CommandBarOverflowPresenter.ItemContainerStyle>" +
     "  <CommandBarOverflowPresenter.RenderTransform> " +
     "   <TranslateTransform x:Name=\"OverflowContentTransform\" />  " +
     "  </CommandBarOverflowPresenter.RenderTransform>" +
     " </CommandBarOverflowPresenter>  " +
     "   </Grid>  " +
     "  </Popup>  " +
     "  <Rectangle " +
     "   x:Name=\"HighContrastBorder\"  " +
     "   Grid.ColumnSpan=\"2\" " +
     "   VerticalAlignment=\"Stretch\"  " +
     "   x:DeferLoadStrategy=\"Lazy\"" +
     "   Stroke=\"{ThemeResource SystemControlForegroundTransparentBrush}\" " +
     "   StrokeThickness=\"1\" " +
     "   Visibility=\"Collapsed\" /> " +
     "  <Rectangle " +
     "   x:Name=\"Spacer\"  " +
     "   Width=\"48\" " +
     "   Visibility=\"Collapsed\" /> " +
     "  <AppBarButton " +
     "   x:Name=\"BackButton\" " +
     "   Grid.Column=\"1\"  " +
     "   Width=\"{ThemeResource AppBarExpandButtonThemeWidth}\" " +
     "   MinHeight=\"{ThemeResource AppBarThemeMinHeight}\"  " +
     "   Foreground=\"{TemplateBinding Foreground}\"" +
     "   Tag=\"{TemplateBinding BackButtonContent}\"" +
     "   Visibility=\"{TemplateBinding BackButtonVisibility}\">" +
     "   <interactivity:Interaction.Behaviors>" +
     " <behaviors:NavButtonBehavior Direction=\"Back\" Frame=\"{Binding Frame, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </interactivity:Interaction.Behaviors>  " +
     "   <AppBarButton.Template>" +
     " <ControlTemplate TargetType=\"AppBarButton\"> " +
     "  <Grid" +
     "   x:Name=\"RootGrid\"" +
     "   Width=\"{TemplateBinding Width}\" " +
     "   Height=\"{TemplateBinding Height}\">" +
     "   <SymbolIcon  " +
     " x:Name=\"BackIcon\"  " +
     " Margin=\"0,-10,0,0\" " +
     " IsHitTestVisible=\"True\"  " +
     " Symbol=\"{TemplateBinding Tag}\" /> " +
     "   <VisualStateManager.VisualStateGroups> " +
     " <VisualStateGroup x:Name=\"CommonStates\"> " +
     "  <VisualState x:Name=\"Normal\" /> " +
     "  <VisualState x:Name=\"PointerOver\">" +
     "   <VisualState.Setters>" +
     " <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource SystemControlHighlightListLowBrush}\" /> " +
     "   </VisualState.Setters>  " +
     "  </VisualState>  " +
     "  <VisualState x:Name=\"Pressed\"> " +
     "   <VisualState.Setters>" +
     " <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource SystemControlHighlightListMediumBrush}\" /> " +
     "   </VisualState.Setters>  " +
     "  </VisualState>  " +
     "  <VisualState x:Name=\"Disabled\">" +
     "   <VisualState.Setters>" +
     " <Setter Target=\"RootGrid.Background\" Value=\"{ThemeResource SystemControlDisabledBaseLowBrush}\" />  " +
     "   </VisualState.Setters>  " +
     "  </VisualState>  " +
     " </VisualStateGroup> " +
     "   </VisualStateManager.VisualStateGroups>" +
     "  </Grid>" +
     " </ControlTemplate>  " +
     "   </AppBarButton.Template>" +
     "  </AppBarButton> " +
     "  " +
     " </Grid> " +
     "  " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"EllipsisIcon.Foreground\" Value=\"{ThemeResource SystemControlDisabledBaseLowBrush}\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"DisplayModeStates\"> " +
     "   <VisualStateGroup.Transitions>" +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.667\" " +
     "  From=\"CompactClosed\" " +
     "  To=\"CompactOpenUp\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.167\" " +
     "  From=\"CompactOpenUp\" " +
     "  To=\"CompactClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.667\" " +
     "  From=\"CompactClosed\" " +
     "  To=\"CompactOpenDown\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeCompactHeight}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.167\" " +
     "  From=\"CompactOpenDown\"  " +
     "  To=\"CompactClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{ThemeResource AppBarThemeCompactHeight}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.667\" " +
     "  From=\"MinimalClosed\" " +
     "  To=\"MinimalOpenUp\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"1\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"1\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.167\" " +
     "  From=\"MinimalOpenUp\" " +
     "  To=\"MinimalClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.667\" " +
     "  From=\"MinimalClosed\" " +
     "  To=\"MinimalOpenDown\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"1\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"1\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.167\" " +
     "  From=\"MinimalOpenDown\"  " +
     "  To=\"MinimalClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.667\" " +
     "  From=\"HiddenClosed\"  " +
     "  To=\"HiddenOpenUp\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.167\" " +
     "  From=\"HiddenOpenUp\"  " +
     "  To=\"HiddenClosed\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.667\" " +
     "  From=\"HiddenClosed\"  " +
     "  To=\"HiddenOpenDown\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.1,0.9 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.667\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition " +
     "  GeneratedDuration=\"0:0:0.167\" " +
     "  From=\"HiddenOpenDown\"" +
     "  To=\"HiddenClosed\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"0\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame" +
     "  KeySpline=\"0.9,0.1 0.2,1.0\"" +
     "  KeyTime=\"0:0:0.167\"  " +
     "  Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     "   </VisualStateGroup.Transitions>  " +
     "   <VisualState x:Name=\"CompactClosed\" />  " +
     "   <VisualState x:Name=\"CompactOpenUp\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CompactOpenDown\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"MinimalClosed\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <!--<ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"IsHitTestVisible\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames> --> " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"IsEnabled\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">" +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <!--<ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"IsHitTestVisible\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames> --> " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"MinimalOpenUp\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"MinimalOpenDown\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"16,11,16,0\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"HiddenClosed\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"IsTabStop\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"IsEnabled\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"HiddenOpenUp\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"HiddenOpenDown\">  " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"AvailableCommandsStates\"> " +
     "   <VisualState x:Name=\"BothCommands\" />" +
     "   <VisualState x:Name=\"PrimaryCommandsOnly\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"OverflowContentRoot.Visibility\" Value=\"Collapsed\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"SecondaryCommandsOnly\"> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"PrimaryItemsControl.Visibility\" Value=\"Collapsed\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"AdaptiveStates\"> " +
     "   <VisualState x:Name=\"VisualStateNarrow\">  " +
     " <VisualState.StateTriggers>  " +
     "  <AdaptiveTrigger x:Name=\"VisualStateNarrowTrigger\" MinWindowWidth=\"{Binding VisualStateNarrowMinWidth, RelativeSource={RelativeSource TemplatedParent}}\" />" +
     " </VisualState.StateTriggers> " +
     " <!--<VisualState.Setters>" +
     "  <Setter Target=\"Spacer.(UIElement.Visibility)\" Value=\"Visible\" />" +
     "  <Setter Target=\"ClipGeometryTransform.X\" Value=\"{ThemeResource AppBarExpandButtonThemeWidth}\" />  " +
     " </VisualState.Setters> -->" +
     "   </VisualState> " +
     "   <VisualState x:Name=\"VisualStateNormal\">  " +
     " <VisualState.StateTriggers>  " +
     "  <AdaptiveTrigger x:Name=\"VisualStateNormalTrigger\" MinWindowWidth=\"{Binding VisualStateNormalMinWidth, RelativeSource={RelativeSource TemplatedParent}}\" />" +
     " </VisualState.StateTriggers> " +
     " <!--<VisualState.Setters>" +
     "  <Setter Target=\"Spacer.(UIElement.Visibility)\" Value=\"Collapsed\" /> " +
     " </VisualState.Setters> -->" +
     "   </VisualState> " +
     "   <VisualState x:Name=\"VisualStateWide\" />" +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Top\" /> " +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Center\" />" +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"T10Controls:ModalDialog\">  " +
     "   <Setter Property=\"IsTabStop\" Value=\"False\" /> " +
     "   <Setter Property=\"ModalBackground\" Value=\"Transparent\" /> " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"T10Controls:ModalDialog\"> " +
     "   <Grid>" +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"Modal\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Part_Modal.Visibility\" Value=\"Visible\" />  " +
     "  <Setter Target=\"Part_Content.IsHitTestVisible\" Value=\"False\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <ContentPresenter x:Name=\"Part_Content\" Content=\"{TemplateBinding Content}\" />" +
     "  " +
     " <Grid x:Name=\"Part_Modal\" Visibility=\"Collapsed\"> " +
     "  <Grid.Background>  " +
     "   <Binding Path=\"ModalBackground\" RelativeSource=\"{RelativeSource Mode=TemplatedParent}\" />  " +
     "  </Grid.Background> " +
     "  <ContentPresenter Content=\"{TemplateBinding ModalContent}\" ContentTransitions=\"{TemplateBinding ModalTransitions}\" HorizontalAlignment=\"Stretch\" VerticalAlignment=\"Stretch\" /> " +
     " </Grid> " +
     "  " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style x:Key=\"PageHeaderText\" TargetType=\"TextBlock\">  " +
     "   <Setter Property=\"Margin\" Value=\"16 6 0 0\" /> " +
     "   <Setter Property=\"FontSize\" Value=\"24\" />  " +
     "   <Setter Property=\"FontWeight\" Value=\"Bold\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Center\" /> " +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"CalendarDatePicker\"> " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource CalendarDatePickerForeground}\" />" +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource CalendarDatePickerBackground}\" />" +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource SystemControlBackgroundListMediumRevealBorderBrush}\" /> " +
     "   <Setter Property=\"BorderThickness\" Value=\"{ThemeResource CalendarDatePickerBorderThemeThickness}\" />" +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Left\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Center\" /> " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"CalendarDatePicker\">" +
     "   <Grid x:Name=\"Root\"> " +
     " <FlyoutBase.AttachedFlyout>  " +
     "  <Flyout Placement=\"Bottom\"> " +
     "   <Flyout.FlyoutPresenterStyle> " +
     " <Style TargetType=\"FlyoutPresenter\">  " +
     "  <Setter Property=\"Padding\" Value=\"0\" />  " +
     "  <Setter Property=\"BorderThickness\" Value=\"0\" />" +
     "  <Setter Property=\"Template\">" +
     "   <Setter.Value> " +
     " <ControlTemplate TargetType=\"FlyoutPresenter\"> " +
     "  <ContentPresenter Background=\"{TemplateBinding Background}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\" ContentTemplate=\"{TemplateBinding ContentTemplate}\" Content=\"{TemplateBinding Content}\" ContentTransitions=\"{TemplateBinding ContentTransitions}\" HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\" Margin=\"{TemplateBinding Padding}\" VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" /> " +
     " </ControlTemplate>  " +
     "   </Setter.Value>" +
     "  </Setter> " +
     " </Style>" +
     "   </Flyout.FlyoutPresenterStyle>" +
     "   <CalendarView x:Name=\"CalendarView\" CalendarIdentifier=\"{TemplateBinding CalendarIdentifier}\" DisplayMode=\"{TemplateBinding DisplayMode}\" DayOfWeekFormat=\"{TemplateBinding DayOfWeekFormat}\" FirstDayOfWeek=\"{TemplateBinding FirstDayOfWeek}\" IsTodayHighlighted=\"{TemplateBinding IsTodayHighlighted}\" IsOutOfScopeEnabled=\"{TemplateBinding IsOutOfScopeEnabled}\" IsGroupLabelVisible=\"{TemplateBinding IsGroupLabelVisible}\" MinDate=\"{TemplateBinding MinDate}\" MaxDate=\"{TemplateBinding MaxDate}\" Style=\"{TemplateBinding CalendarViewStyle}\" />  " +
     "  </Flyout> " +
     " </FlyoutBase.AttachedFlyout> " +
     " <Grid.ColumnDefinitions>  " +
     "  <ColumnDefinition Width=\"*\" />  " +
     "  <ColumnDefinition Width=\"32\" /> " +
     " </Grid.ColumnDefinitions> " +
     " <Grid.RowDefinitions>  " +
     "  <RowDefinition Height=\"Auto\" /> " +
     "  <RowDefinition Height=\"32\" />" +
     " </Grid.RowDefinitions> " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBorderBrushPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBackgroundPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBackgroundPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBorderBrushPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBackgroundDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBorderBrushDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HeaderContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerHeaderForegroundDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"DateText\" Storyboard.TargetProperty=\"Foreground\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerTextForegroundDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CalendarGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerCalendarGlyphForegroundDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"FocusStates\"> " +
     "   <VisualState x:Name=\"Unfocused\" />" +
     "   <VisualState x:Name=\"PointerFocused\" /> " +
     "   <VisualState x:Name=\"Focused\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"Background\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerBackgroundFocused}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"SelectionStates\">" +
     "   <VisualState x:Name=\"Unselected\" />  " +
     "   <VisualState x:Name=\"Selected\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"DateText\" Storyboard.TargetProperty=\"Foreground\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CalendarDatePickerTextForegroundSelected}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <ContentPresenter x:Name=\"HeaderContentPresenter\" ContentTemplate=\"{TemplateBinding HeaderTemplate}\" Content=\"{TemplateBinding Header}\" Margin=\"{ThemeResource ComboBoxHeaderThemeMargin}\" TextWrapping=\"Wrap\" Visibility=\"Collapsed\" x:DeferLoadStrategy=\"Lazy\" />  " +
     " <Border x:Name=\"Background\" Background=\"{TemplateBinding Background}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\" Grid.ColumnSpan=\"2\" Grid.Row=\"1\" />" +
     " <TextBlock x:Name=\"DateText\" Foreground=\"{ThemeResource CalendarDatePickerTextForeground}\" FontSize=\"15\" HorizontalAlignment=\"Left\" Padding=\"12, 0, 0, 2\" Grid.Row=\"1\" Text=\"{TemplateBinding PlaceholderText}\" VerticalAlignment=\"Center\" />" +
     " <FontIcon x:Name=\"CalendarGlyph\" Grid.Column=\"1\" FontFamily=\"{ThemeResource SymbolThemeFontFamily}\" Foreground=\"{ThemeResource CalendarDatePickerCalendarGlyphForeground}\" FontSize=\"16\" Glyph=\"&#xE787;\" HorizontalAlignment=\"Center\" Grid.Row=\"1\" VerticalAlignment=\"Center\" />" +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"TextBox\">" +
     "   <Setter Property=\"MinWidth\" Value=\"{ThemeResource TextControlThemeMinWidth}\" />" +
     "   <Setter Property=\"MinHeight\" Value=\"{ThemeResource TextControlThemeMinHeight}\" /> " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource TextControlForeground}\" /> " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource TextControlBackground}\" /> " +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource SystemControlBackgroundListMediumRevealBorderBrush}\" /> " +
     "   <Setter Property=\"SelectionHighlightColor\" Value=\"{ThemeResource TextControlSelectionHighlightColor}\" />  " +
     "   <Setter Property=\"BorderThickness\" Value=\"{ThemeResource TextControlBorderThemeThickness}\" /> " +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\" />  " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\" />" +
     "   <Setter Property=\"ScrollViewer.HorizontalScrollMode\" Value=\"Auto\" />  " +
     "   <Setter Property=\"ScrollViewer.VerticalScrollMode\" Value=\"Auto\" /> " +
     "   <Setter Property=\"ScrollViewer.HorizontalScrollBarVisibility\" Value=\"Hidden\" />" +
     "   <Setter Property=\"ScrollViewer.VerticalScrollBarVisibility\" Value=\"Hidden\" />  " +
     "   <Setter Property=\"ScrollViewer.IsDeferredScrollingEnabled\" Value=\"False\" /> " +
     "   <Setter Property=\"Padding\" Value=\"{ThemeResource TextControlThemePadding}\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"TextBox\">  " +
     "   <Grid>" +
     " <Grid.Resources> " +
     "  <Style x:Name=\"DeleteButtonStyle\" TargetType=\"Button\"> " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"Button\">" +
     "   <Grid x:Name=\"ButtonLayoutGrid\" Background=\"{ThemeResource TextControlButtonBackground}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{ThemeResource TextControlButtonBorderBrush}\"> " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ButtonLayoutGrid\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlButtonBackgroundPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ButtonLayoutGrid\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlButtonBorderBrushPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"GlyphElement\" Storyboard.TargetProperty=\"Foreground\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlButtonForegroundPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ButtonLayoutGrid\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlButtonBackgroundPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ButtonLayoutGrid\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlButtonBorderBrushPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"GlyphElement\" Storyboard.TargetProperty=\"Foreground\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlButtonForegroundPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <Storyboard>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"ButtonLayoutGrid\" Storyboard.TargetProperty=\"Opacity\" To=\"0\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <TextBlock x:Name=\"GlyphElement\" AutomationProperties.AccessibilityView=\"Raw\" FontStyle=\"Normal\" FontFamily=\"{ThemeResource SymbolThemeFontFamily}\" Foreground=\"{ThemeResource TextControlButtonForeground}\" FontSize=\"12\" HorizontalAlignment=\"Center\" Text=\"&#xE10A;\" VerticalAlignment=\"Center\" /> " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     " </Grid.Resources>" +
     " <Grid.ColumnDefinitions>  " +
     "  <ColumnDefinition Width=\"*\" />  " +
     "  <ColumnDefinition Width=\"Auto\" />  " +
     " </Grid.ColumnDefinitions> " +
     " <Grid.RowDefinitions>  " +
     "  <RowDefinition Height=\"Auto\" /> " +
     "  <RowDefinition Height=\"*\" /> " +
     " </Grid.RowDefinitions> " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HeaderContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlHeaderForegroundDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"BorderElement\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlBackgroundDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"BorderElement\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlBorderBrushDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentElement\" Storyboard.TargetProperty=\"Foreground\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlForegroundDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PlaceholderTextContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{Binding PlaceholderForeground, RelativeSource={RelativeSource Mode=TemplatedParent}, TargetNullValue={ThemeResource TextControlPlaceholderForegroundDisabled}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"BorderElement\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlBorderBrushPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"BorderElement\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlBackgroundPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PlaceholderTextContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{Binding PlaceholderForeground, RelativeSource={RelativeSource Mode=TemplatedParent}, TargetNullValue={ThemeResource TextControlPlaceholderForegroundPointerOver}}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentElement\" Storyboard.TargetProperty=\"Foreground\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlForegroundPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Focused\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PlaceholderTextContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{Binding PlaceholderForeground, RelativeSource={RelativeSource Mode=TemplatedParent}, TargetNullValue={ThemeResource TextControlPlaceholderForegroundFocused}}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"BorderElement\" Storyboard.TargetProperty=\"Background\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlBackgroundFocused}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"BorderElement\" Storyboard.TargetProperty=\"BorderBrush\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlBorderBrushFocused}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentElement\" Storyboard.TargetProperty=\"Foreground\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource TextControlForegroundFocused}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentElement\" Storyboard.TargetProperty=\"RequestedTheme\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"Light\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"ButtonStates\">" +
     "   <VisualState x:Name=\"ButtonVisible\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"DeleteButton\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\">" +
     " <DiscreteObjectKeyFrame.Value>  " +
     "  <Visibility> Visible </Visibility> " +
     " </DiscreteObjectKeyFrame.Value> " +
     "   </DiscreteObjectKeyFrame>  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"ButtonCollapsed\" />" +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <Border x:Name=\"BorderElement\" Background=\"{TemplateBinding Background}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\" Grid.ColumnSpan=\"2\" Grid.RowSpan=\"1\" Grid.Row=\"1\" /> " +
     " <ContentPresenter x:Name=\"HeaderContentPresenter\" ContentTemplate=\"{TemplateBinding HeaderTemplate}\" Content=\"{TemplateBinding Header}\" Grid.ColumnSpan=\"2\" FontWeight=\"Normal\" Foreground=\"{ThemeResource TextControlHeaderForeground}\" Margin=\"0,0,0,8\" Grid.Row=\"0\" TextWrapping=\"{TemplateBinding TextWrapping}\" Visibility=\"Collapsed\" x:DeferLoadStrategy=\"Lazy\" />  " +
     " <ScrollViewer x:Name=\"ContentElement\" AutomationProperties.AccessibilityView=\"Raw\" HorizontalScrollBarVisibility=\"{TemplateBinding ScrollViewer.HorizontalScrollBarVisibility}\" HorizontalScrollMode=\"{TemplateBinding ScrollViewer.HorizontalScrollMode}\" IsDeferredScrollingEnabled=\"{TemplateBinding ScrollViewer.IsDeferredScrollingEnabled}\" IsHorizontalRailEnabled=\"{TemplateBinding ScrollViewer.IsHorizontalRailEnabled}\" IsTabStop=\"False\" IsVerticalRailEnabled=\"{TemplateBinding ScrollViewer.IsVerticalRailEnabled}\" Margin=\"{TemplateBinding BorderThickness}\" Padding=\"{TemplateBinding Padding}\" Grid.Row=\"1\" VerticalScrollMode=\"{TemplateBinding ScrollViewer.VerticalScrollMode}\" VerticalScrollBarVisibility=\"{TemplateBinding ScrollViewer.VerticalScrollBarVisibility}\" ZoomMode=\"Disabled\" /> " +
     " <TextBlock x:Name=\"PlaceholderTextContentPresenter\" Grid.ColumnSpan=\"2\" Foreground=\"{Binding PlaceholderForeground, RelativeSource={RelativeSource Mode=TemplatedParent}, TargetNullValue={ThemeResource TextControlPlaceholderForeground}}\" IsHitTestVisible=\"False\" Margin=\"{TemplateBinding BorderThickness}\" Padding=\"{TemplateBinding Padding}\" Grid.Row=\"1\" Text=\"{TemplateBinding PlaceholderText}\" TextWrapping=\"{TemplateBinding TextWrapping}\" TextAlignment=\"{TemplateBinding TextAlignment}\" /> " +
     " <Button x:Name=\"DeleteButton\" AutomationProperties.AccessibilityView=\"Raw\" BorderThickness=\"{TemplateBinding BorderThickness}\" Grid.Column=\"1\" FontSize=\"{TemplateBinding FontSize}\" IsTabStop=\"False\" MinWidth=\"34\" Margin=\"{ThemeResource HelperButtonThemePadding}\" Grid.Row=\"1\" Style=\"{StaticResource DeleteButtonStyle}\" VerticalAlignment=\"Stretch\" Visibility=\"Collapsed\" />" +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style x:Name=\"ShadowContent\" TargetType=\"Tools:DropShadowPanel\">  " +
     "   <Setter Property=\"BlurRadius\" Value=\"15\" />" +
     "   <Setter Property=\"ShadowOpacity\" Value=\"0.5\" />  " +
     "   <Setter Property=\"OffsetX\" Value=\".0\" />" +
     "   <Setter Property=\"OffsetY\" Value=\"-0.0\" /> " +
     "   <Setter Property=\"Margin\" Value=\"-20 0 -20 0\" /> " +
     "  </Style>  " +
     "  " +
     "  <Style x:Name=\"ShadowSlave\" TargetType=\"Tools:DropShadowPanel\"> " +
     "   <Setter Property=\"BlurRadius\" Value=\"15\" />" +
     "   <Setter Property=\"ShadowOpacity\" Value=\"0.95\" /> " +
     "   <Setter Property=\"OffsetX\" Value=\"1.0\" />  " +
     "   <Setter Property=\"OffsetY\" Value=\"9.0\" />  " +
     "   <Setter Property=\"Margin\" Value=\"-20 0 -20 0\" /> " +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Stretch\" />  " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Stretch\" />" +
     "  </Style>  " +
     "  " +
     "  <Style x:Name=\"ContentGrid\" TargetType=\"Grid\">" +
     "   <Setter Property=\"Padding\" Value=\"20 0 20 0\" />  " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource SystemControlAcrylicElementBrush}\" />  " +
     "   <!--SystemControlAcrylicElementBrush-->" +
     "  </Style>  " +
     "  " +
     "  <Style x:Name=\"PageHeader\" TargetType=\"CommandBar\"> " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource SystemControlAcrylicWindowMediumHighBrush}\" />  " +
     "   <Setter Property=\"Margin\" Value=\"48 0 0 0\" /> " +
     "   <!--<Setter Property=\"Padding\" Value=\"0 0 0 0\" /> --> " +
     "   <!--<Setter Property=\"Height\" Value=\"48\" /> --> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Bottom\" /> " +
     "   <Setter Property=\"DefaultLabelPosition\" Value=\"Right\" />  " +
     "   <Setter Property=\"RelativePanel.AlignLeftWithPanel\" Value=\"True\" />" +
     "   <Setter Property=\"RelativePanel.AlignRightWithPanel\" Value=\"True\" />  " +
     "   <Setter Property=\"RelativePanel.AlignTopWithPanel\" Value=\"True\" /> " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource CommandBarForeground}\" />  " +
     "   <Setter Property=\"IsTabStop\" Value=\"False\" /> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" /> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Left\" />" +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Top\" />" +
     "   <Setter Property=\"ClosedDisplayMode\" Value=\"Compact\" />" +
     "   <Setter Property=\"ExitDisplayModeOnAccessKeyInvoked\" Value=\"False\" /> " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"CommandBar\">  " +
     "   <Grid x:Name=\"LayoutRoot\"> " +
     " <Grid.Resources> " +
     "  <Storyboard x:Key=\"OverlayOpeningAnimation\">  " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"1\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     "  <Storyboard x:Key=\"OverlayClosingAnimation\">  " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </Grid.Resources>" +
     " <Grid.Clip>" +
     "  <RectangleGeometry Rect=\"{Binding TemplateSettings.ClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\">  " +
     "   <RectangleGeometry.Transform> " +
     " <TranslateTransform x:Name=\"ClipGeometryTransform\" Y=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </RectangleGeometry.Transform>" +
     "  </RectangleGeometry>  " +
     " </Grid.Clip>  " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\" />" +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"EllipsisIcon\" Storyboard.TargetProperty=\"Foreground\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CommandBarEllipsisIconForegroundDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"DisplayModeStates\"> " +
     "   <VisualStateGroup.Transitions>" +
     " <VisualTransition From=\"CompactClosed\" GeneratedDuration=\"0:0:0.467\" To=\"CompactOpenUp\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"CompactOpenUp\" GeneratedDuration=\"0:0:0.167\" To=\"CompactClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"CompactClosed\" GeneratedDuration=\"0:0:0.467\" To=\"CompactOpenDown\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeCompactHeight}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"CompactOpenDown\" GeneratedDuration=\"0:0:0.167\" To=\"CompactClosed\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{ThemeResource AppBarThemeCompactHeight}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"MinimalClosed\" GeneratedDuration=\"0:0:0.467\" To=\"MinimalOpenUp\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"1\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"1\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"MinimalOpenUp\" GeneratedDuration=\"0:0:0.167\" To=\"MinimalClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"MinimalClosed\" GeneratedDuration=\"0:0:0.467\" To=\"MinimalOpenDown\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"1\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"1\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"MinimalOpenDown\" GeneratedDuration=\"0:0:0.167\" To=\"MinimalClosed\">  " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">  " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"HiddenClosed\" GeneratedDuration=\"0:0:0.467\" To=\"HiddenOpenUp\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"HiddenOpenUp\" GeneratedDuration=\"0:0:0.167\" To=\"HiddenClosed\">" +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"1\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"HiddenClosed\" GeneratedDuration=\"0:0:0.467\" To=\"HiddenOpenDown\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     " <SplineDoubleKeyFrame KeySpline=\"0.1,0.9 0.2,1.0\" KeyTime=\"0:0:0.467\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     " <VisualTransition From=\"HiddenOpenDown\" GeneratedDuration=\"0:0:0.167\" To=\"HiddenClosed\"> " +
     "  <Storyboard> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\"> " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />  " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowPopupOffsetTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"-1\" /> " +
     "   </ObjectAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\">" +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"0\" />  " +
     "   </DoubleAnimationUsingKeyFrames> " +
     "   <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     " <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />  " +
     " <SplineDoubleKeyFrame KeySpline=\"0.2,0 0,1\" KeyTime=\"0:0:0.167\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "   </DoubleAnimationUsingKeyFrames> " +
     "  </Storyboard>" +
     " </VisualTransition> " +
     "   </VisualStateGroup.Transitions>  " +
     "   <VisualState x:Name=\"CompactClosed\" />  " +
     "   <VisualState x:Name=\"CompactOpenUp\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.CompactVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CompactOpenDown\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"MinimalClosed\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"IsHitTestVisible\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"IsEnabled\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"Opacity\">" +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"IsHitTestVisible\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Opacity\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"MinimalOpenUp\">" +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.MinimalVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"MinimalOpenDown\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"Padding\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"14,11,14,0\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"MinHeight\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{ThemeResource AppBarThemeMinimalHeight}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"HiddenClosed\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"IsTabStop\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentControl\" Storyboard.TargetProperty=\"IsEnabled\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"False\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"HiddenOpenUp\"> " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ContentTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding TemplateSettings.HiddenVerticalDelta, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.NegativeOverflowContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"HiddenOpenDown\">  " +
     " <Storyboard>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"ClipGeometryTransform\" Storyboard.TargetProperty=\"Y\">  " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"0\" />" +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"MoreButton\" Storyboard.TargetProperty=\"VerticalAlignment\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Stretch\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"HighContrastBorder\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Visible\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootClip\" Storyboard.TargetProperty=\"Rect\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.OverflowContentClipRect, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRootTransform\" Storyboard.TargetProperty=\"Y\"> " +
     "   <DiscreteDoubleKeyFrame KeyTime=\"0:0:0\" Value=\"{Binding CommandBarTemplateSettings.ContentHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" />  " +
     "  </DoubleAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"SecondaryItemsControl\" Storyboard.TargetProperty=\"IsEnabled\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"True\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"AvailableCommandsStates\"> " +
     "   <VisualState x:Name=\"BothCommands\" />" +
     "   <VisualState x:Name=\"PrimaryCommandsOnly\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"OverflowContentRoot\" Storyboard.TargetProperty=\"Visibility\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Collapsed\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"SecondaryCommandsOnly\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"PrimaryItemsControl\" Storyboard.TargetProperty=\"Visibility\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0:0:0\" Value=\"Collapsed\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"DynamicOverflowStates\">" +
     "   <VisualState x:Name=\"DynamicOverflowDisabled\" /> " +
     "   <VisualState x:Name=\"DynamicOverflowEnabled\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentControlColumnDefinition.Width\" Value=\"Auto\" />  " +
     "  <Setter Target=\"PrimaryItemsControlColumnDefinition.Width\" Value=\"*\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <Grid x:Name=\"ContentRoot\" Background=\"{TemplateBinding Background}\" Height=\"{TemplateBinding Height}\" MinHeight=\"{ThemeResource AppBarThemeCompactHeight}\" Margin=\"{TemplateBinding Padding}\" VerticalAlignment=\"Top\" XYFocusKeyboardNavigation=\"Enabled\">" +
     "  <Grid.ColumnDefinitions> " +
     "   <ColumnDefinition Width=\"*\" /> " +
     "   <ColumnDefinition Width=\"Auto\" /> " +
     "  </Grid.ColumnDefinitions>" +
     "  <Grid.RenderTransform>" +
     "   <TranslateTransform x:Name=\"ContentTransform\" /> " +
     "  </Grid.RenderTransform>  " +
     "  <Grid> " +
     "   <Grid.ColumnDefinitions>" +
     " <ColumnDefinition x:Name=\"ContentControlColumnDefinition\" Width=\"*\" />  " +
     " <ColumnDefinition x:Name=\"PrimaryItemsControlColumnDefinition\" Width=\"Auto\" />" +
     "   </Grid.ColumnDefinitions>  " +
     "   <ContentControl x:Name=\"ContentControl\" ContentTemplate=\"{TemplateBinding ContentTemplate}\" Content=\"{TemplateBinding Content}\" ContentTransitions=\"{TemplateBinding ContentTransitions}\" Foreground=\"{TemplateBinding Foreground}\" HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\" HorizontalContentAlignment=\"{TemplateBinding HorizontalContentAlignment}\" IsTabStop=\"False\" VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" VerticalContentAlignment=\"{TemplateBinding VerticalContentAlignment}\" Margin=\"0 3 0 0\" />  " +
     "   <ItemsControl x:Name=\"PrimaryItemsControl\" Grid.Column=\"1\" HorizontalAlignment=\"Right\" IsTabStop=\"False\" MinHeight=\"{ThemeResource AppBarThemeCompactHeight}\" Margin=\"0 0 0 0\">  " +
     " <ItemsControl.ItemsPanel> " +
     "  <ItemsPanelTemplate>  " +
     "   <StackPanel Orientation=\"Horizontal\" /> " +
     "  </ItemsPanelTemplate> " +
     " </ItemsControl.ItemsPanel>" +
     "   </ItemsControl>" +
     "  </Grid>" +
     "  <Button x:Name=\"MoreButton\" Grid.Column=\"1\" Foreground=\"{TemplateBinding Foreground}\" IsAccessKeyScope=\"True\" Control.IsTemplateKeyTipTarget=\"True\" MinHeight=\"{ThemeResource AppBarThemeCompactHeight}\" Padding=\"14,23,14,0\" Style=\"{StaticResource EllipsisButton}\" VerticalAlignment=\"Top\" Visibility=\"{Binding CommandBarTemplateSettings.EffectiveOverflowButtonVisibility, RelativeSource={RelativeSource Mode=TemplatedParent}}\">" +
     "   <FontIcon x:Name=\"EllipsisIcon\" FontFamily=\"{ThemeResource SymbolThemeFontFamily}\" FontSize=\"20\" Glyph=\"&#xE10C;\" Height=\"{ThemeResource AppBarExpandButtonCircleDiameter}\" VerticalAlignment=\"Center\" /> " +
     "  </Button> " +
     "  <Popup x:Name=\"OverflowPopup\"> " +
     "   <Popup.RenderTransform> " +
     " <TranslateTransform x:Name=\"OverflowPopupOffsetTransform\" />" +
     "   </Popup.RenderTransform>" +
     "   <Grid x:Name=\"OverflowContentRoot\" MinWidth=\"{Binding CommandBarTemplateSettings.OverflowContentMinWidth, RelativeSource={RelativeSource Mode=TemplatedParent}}\" MaxHeight=\"{Binding CommandBarTemplateSettings.OverflowContentMaxHeight, RelativeSource={RelativeSource Mode=TemplatedParent}}\" MaxWidth=\"{Binding CommandBarTemplateSettings.OverflowContentMaxWidth, RelativeSource={RelativeSource Mode=TemplatedParent}}\">  " +
     " <Grid.Clip>" +
     "  <RectangleGeometry x:Name=\"OverflowContentRootClip\" />  " +
     " </Grid.Clip>  " +
     " <Grid.RenderTransform> " +
     "  <TranslateTransform x:Name=\"OverflowContentRootTransform\" X=\"{Binding CommandBarTemplateSettings.OverflowContentHorizontalOffset, RelativeSource={RelativeSource Mode=TemplatedParent}}\" /> " +
     " </Grid.RenderTransform>" +
     " <CommandBarOverflowPresenter x:Name=\"SecondaryItemsControl\" IsEnabled=\"False\" IsTabStop=\"False\" Style=\"{TemplateBinding CommandBarOverflowPresenterStyle}\" Background=\"{ThemeResource AcrylicInAppSoft}\">  " +
     "  <CommandBarOverflowPresenter.ItemContainerStyle> " +
     "   <Style TargetType=\"FrameworkElement\">  " +
     " <Setter Property=\"HorizontalAlignment\" Value=\"Stretch\" />" +
     " <Setter Property=\"Width\" Value=\"150\" />" +
     "   </Style> " +
     "  </CommandBarOverflowPresenter.ItemContainerStyle>" +
     "  <CommandBarOverflowPresenter.RenderTransform> " +
     "   <TranslateTransform x:Name=\"OverflowContentTransform\" />  " +
     "  </CommandBarOverflowPresenter.RenderTransform>" +
     " </CommandBarOverflowPresenter>  " +
     "   </Grid>  " +
     "  </Popup>  " +
     "  <Rectangle x:Name=\"HighContrastBorder\" Grid.ColumnSpan=\"2\" StrokeThickness=\"1\" Stroke=\"{ThemeResource CommandBarHighContrastBorder}\" VerticalAlignment=\"Stretch\" Visibility=\"Collapsed\" x:DeferLoadStrategy=\"Lazy\" />  " +
     " </Grid> " +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <ControlTemplate x:Name=\"ShadowAppBarButton\" TargetType=\"AppBarButton\">  " +
     "   <Grid x:Name=\"Container\" Background=\"Transparent\" Height=\"45\" Margin=\"0 3 3 0\" MinWidth=\"{TemplateBinding MinWidth}\" MaxWidth=\"{TemplateBinding MaxWidth}\"> " +
     " <Grid.Resources> " +
     "  <Style x:Name=\"LabelOnRightStyle\" TargetType=\"AppBarButton\"> " +
     "   <Setter Property=\"Width\" Value=\"NaN\" /> " +
     "  </Style>  " +
     " </Grid.Resources>" +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"ApplicationViewStates\">" +
     "   <VisualState x:Name=\"FullSize\" /> " +
     "   <VisualState x:Name=\"Compact\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"TextLabel\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"Collapsed\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentViewbox\" Storyboard.TargetProperty=\"Margin\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"0,14,0,14\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"LabelOnRight\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentViewbox\" Storyboard.TargetProperty=\"Margin\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"12,14,0,14\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"MinHeight\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource AppBarThemeCompactHeight}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"TextLabel\" Storyboard.TargetProperty=\"(Grid.Row)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"0\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"TextLabel\" Storyboard.TargetProperty=\"(Grid.Column)\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"1\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"TextLabel\" Storyboard.TargetProperty=\"TextAlignment\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"Left\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"TextLabel\" Storyboard.TargetProperty=\"Margin\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"8,15,12,17\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"LabelCollapsed\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentRoot\" Storyboard.TargetProperty=\"MinHeight\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource AppBarThemeCompactHeight}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"TextLabel\" Storyboard.TargetProperty=\"Visibility\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"Collapsed\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Overflow\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentRoot.MinHeight\" Value=\"0\" />  " +
     "  <Setter Target=\"ContentViewbox.Visibility\" Value=\"Collapsed\" />  " +
     "  <Setter Target=\"TextLabel.Visibility\" Value=\"Collapsed\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Visibility\" Value=\"Visible\" /> " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OverflowWithToggleButtons\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentRoot.MinHeight\" Value=\"0\" />  " +
     "  <Setter Target=\"ContentViewbox.Visibility\" Value=\"Collapsed\" />  " +
     "  <Setter Target=\"TextLabel.Visibility\" Value=\"Collapsed\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Visibility\" Value=\"Visible\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Margin\" Value=\"38,0,12,0\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OverflowWithMenuIcons\"> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentRoot.MinHeight\" Value=\"0\" />  " +
     "  <Setter Target=\"ContentViewbox.HorizontalAlignment\" Value=\"Left\" /> " +
     "  <Setter Target=\"ContentViewbox.VerticalAlignment\" Value=\"Center\" /> " +
     "  <Setter Target=\"ContentViewbox.Width\" Value=\"16\" />  " +
     "  <Setter Target=\"ContentViewbox.Height\" Value=\"16\" /> " +
     "  <Setter Target=\"ContentViewbox.Margin\" Value=\"12,0,12,0\" />" +
     "  <Setter Target=\"TextLabel.Visibility\" Value=\"Collapsed\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Visibility\" Value=\"Visible\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Margin\" Value=\"38,0,12,0\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OverflowWithToggleButtonsAndMenuIcons\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"ContentRoot.MinHeight\" Value=\"0\" />  " +
     "  <Setter Target=\"ContentViewbox.HorizontalAlignment\" Value=\"Left\" /> " +
     "  <Setter Target=\"ContentViewbox.VerticalAlignment\" Value=\"Center\" /> " +
     "  <Setter Target=\"ContentViewbox.Width\" Value=\"16\" />  " +
     "  <Setter Target=\"ContentViewbox.Height\" Value=\"16\" /> " +
     "  <Setter Target=\"ContentViewbox.Margin\" Value=\"38,0,12,0\" />" +
     "  <Setter Target=\"TextLabel.Visibility\" Value=\"Collapsed\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Visibility\" Value=\"Visible\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Margin\" Value=\"76,0,12,0\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"CommonStates\">" +
     "   <VisualState x:Name=\"Normal\"> " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"OverflowTextLabel\" />  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"15\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.Color\" Value=\"Black\" /> " +
     "  <Setter Target=\"Container.Height\" Value=\"45\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"PointerOver\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Root.(RevealBrush.State)\" Value=\"PointerOver\" /> " +
     "  <Setter Target=\"Root.Background\" Value=\"{ThemeResource AppBarButtonRevealBackgroundPointerOver}\" />  " +
     "  <Setter Target=\"Border.BorderBrush\" Value=\"{ThemeResource AppBarButtonRevealBorderBrushPointerOver}\" /> " +
     "  <Setter Target=\"Content.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPointerOver}\" />  " +
     "  <Setter Target=\"TextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPointerOver}\" />" +
     "  <Setter Target=\"OverflowTextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPointerOver}\" /> " +
     "  <Setter Target=\"BackgroundLayer.Background\" Value=\"{ThemeResource SystemControlAcrylicWindowMediumHighBrush}\" /> " +
     "  <Setter Target=\"Shadow.Color\" Value=\"Black\" /> " +
     " </VisualState.Setters> " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"OverflowTextLabel\" />  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"15\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Pressed\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Root.(RevealBrush.State)\" Value=\"Pressed\" />  " +
     "  <Setter Target=\"Root.Background\" Value=\"{ThemeResource AppBarButtonRevealBackgroundPressed}\" />" +
     "  <Setter Target=\"Border.BorderBrush\" Value=\"{ThemeResource AppBarButtonRevealBorderBrushPressed}\" />  " +
     "  <Setter Target=\"Content.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPressed}\" />" +
     "  <Setter Target=\"TextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPressed}\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPressed}\" />  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"15\" />  " +
     " </VisualState.Setters> " +
     " <Storyboard>  " +
     "  <PointerDownThemeAnimation Storyboard.TargetName=\"OverflowTextLabel\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"Disabled\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Root.Background\" Value=\"{ThemeResource AppBarButtonRevealBackgroundDisabled}\" />  " +
     "  <Setter Target=\"Border.BorderBrush\" Value=\"{ThemeResource AppBarButtonRevealBorderBrushDisabled}\" /> " +
     "  <Setter Target=\"Content.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundDisabled}\" />  " +
     "  <Setter Target=\"TextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundDisabled}\" />" +
     "  <Setter Target=\"OverflowTextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundDisabled}\" /> " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OverflowNormal\">  " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"ContentRoot\" />  " +
     " </Storyboard> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"BackgroundLayer.Background\" Value=\"Transparent\" />  " +
     "  <Setter Target=\"Shadow.Color\" Value=\"Transparent\" /> " +
     "  <Setter Target=\"Container.Height\" Value=\"32\" />" +
     "  <Setter Target=\"Shadow.VerticalContentAlignment\" Value=\"Center\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OverflowPointerOver\">" +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Root.Background\" Value=\"{ThemeResource AppBarButtonRevealBackgroundPointerOver}\" />  " +
     "  <Setter Target=\"Border.BorderBrush\" Value=\"{ThemeResource AppBarButtonRevealBorderBrushPointerOver}\" /> " +
     "  <Setter Target=\"Content.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPointerOver}\" />  " +
     "  <Setter Target=\"TextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPointerOver}\" />" +
     "  <Setter Target=\"OverflowTextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPointerOver}\" /> " +
     "  <Setter Target=\"Container.Height\" Value=\"32\" />" +
     "  <Setter Target=\"Shadow.VerticalContentAlignment\" Value=\"Center\" />  " +
     " </VisualState.Setters> " +
     " <Storyboard>  " +
     "  <PointerUpThemeAnimation Storyboard.TargetName=\"ContentRoot\" />  " +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"OverflowPressed\"> " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Root.Background\" Value=\"{ThemeResource AppBarButtonRevealBackgroundPressed}\" />" +
     "  <Setter Target=\"Border.BorderBrush\" Value=\"{ThemeResource AppBarButtonRevealBorderBrushPressed}\" />  " +
     "  <Setter Target=\"Content.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPressed}\" />" +
     "  <Setter Target=\"TextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPressed}\" /> " +
     "  <Setter Target=\"OverflowTextLabel.Foreground\" Value=\"{ThemeResource AppBarButtonForegroundPressed}\" />  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"15\" />  " +
     " </VisualState.Setters> " +
     " <Storyboard>  " +
     "  <PointerDownThemeAnimation Storyboard.TargetName=\"ContentRoot\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     "  <VisualStateGroup x:Name=\"InputModeStates\">" +
     "   <VisualState x:Name=\"InputModeDefault\" />  " +
     "   <VisualState x:Name=\"TouchInputMode\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"OverflowTextLabel.Padding\" Value=\"0,11,0,13\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"GameControllerInputMode\">  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"OverflowTextLabel.Padding\" Value=\"0,11,0,13\" />  " +
     " </VisualState.Setters> " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     "  " +
     " <Tools:DropShadowPanel x:Name=\"Shadow\" " +
     "   BlurRadius=\"0\"" +
     "   Color=\"Transparent\" " +
     "   ShadowOpacity=\".5\"  " +
     "   OffsetX=\"0\"" +
     "   OffsetY=\".0\"  " +
     "   HorizontalContentAlignment=\"Stretch\"  " +
     "   VerticalContentAlignment=\"Stretch\" " +
     "   Style=\"{StaticResource ShadowMenu}\"> " +
     "  " +
     "  <Grid x:Name=\"BackgroundLayer\" Background=\"{ThemeResource SystemControlAcrylicWindowMediumHighBrush}\" MinWidth=\"{TemplateBinding MinWidth}\" MaxWidth=\"{TemplateBinding MaxWidth}\">" +
     "   <Grid x:Name=\"Root\"> " +
     " <Grid x:Name=\"ContentRoot\" MinHeight=\"{ThemeResource AppBarThemeMinHeight}\"> " +
     "  <Grid.ColumnDefinitions> " +
     "   <ColumnDefinition Width=\"*\" /> " +
     "   <ColumnDefinition Width=\"Auto\" /> " +
     "  </Grid.ColumnDefinitions>" +
     "  <Grid.RowDefinitions> " +
     "   <RowDefinition Height=\"Auto\" />" +
     "   <RowDefinition Height=\"Auto\" />" +
     "  </Grid.RowDefinitions>" +
     "  <Viewbox x:Name=\"ContentViewbox\" AutomationProperties.AccessibilityView=\"Raw\" HorizontalAlignment=\"Stretch\" Height=\"20\" Margin=\"0,14,0,4\"> " +
     "   <ContentPresenter x:Name=\"Content\" Content=\"{TemplateBinding Icon}\" Foreground=\"{TemplateBinding Foreground}\" Height=\"20\" />" +
     "  </Viewbox>" +
     "  <TextBlock x:Name=\"TextLabel\" AutomationProperties.AccessibilityView=\"Raw\" FontFamily=\"{TemplateBinding FontFamily}\" Foreground=\"{TemplateBinding Foreground}\" FontSize=\"12\" Margin=\"2,0,2,6\" Grid.Row=\"1\" Text=\"{TemplateBinding Label}\" TextWrapping=\"Wrap\" TextAlignment=\"Center\" />  " +
     "  <TextBlock x:Name=\"OverflowTextLabel\" AutomationProperties.AccessibilityView=\"Raw\" FontFamily=\"{TemplateBinding FontFamily}\" Foreground=\"{TemplateBinding Foreground}\" FontSize=\"15\" HorizontalAlignment=\"Stretch\" Margin=\"12,0,12,0\" Padding=\"0,5,0,7\" Text=\"{TemplateBinding Label}\" TextTrimming=\"Clip\" TextWrapping=\"NoWrap\" TextAlignment=\"Left\" VerticalAlignment=\"Center\" Visibility=\"Collapsed\" /> " +
     "  <Border x:Name=\"Border\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\" Grid.ColumnSpan=\"2\" Grid.RowSpan=\"2\" />  " +
     " </Grid> " +
     "   </Grid>  " +
     "  </Grid>" +
     " </Tools:DropShadowPanel>" +
     "   </Grid> " +
     "  </ControlTemplate>" +
     "  " +
     "  <Style TargetType=\"AppBarSeparator\"> " +
     "   <Setter Property=\"Height\" Value=\"45\" /> " +
     "   <Setter Property=\"Margin\" Value=\"0 3 0 0\" />  " +
     "  </Style>  " +
     "  " +
     "  <Style x:Key=\"ShadowListView\" TargetType=\"ListView\">" +
     "   <Setter Property=\"IsTabStop\" Value=\"False\" /> " +
     "   <Setter Property=\"TabNavigation\" Value=\"Once\" /> " +
     "   <Setter Property=\"IsSwipeEnabled\" Value=\"True\" />" +
     "   <Setter Property=\"ScrollViewer.HorizontalScrollBarVisibility\" Value=\"Disabled\" /> " +
     "   <Setter Property=\"ScrollViewer.VerticalScrollBarVisibility\" Value=\"Auto\" /> " +
     "   <Setter Property=\"ScrollViewer.HorizontalScrollMode\" Value=\"Disabled\" /> " +
     "   <Setter Property=\"ScrollViewer.IsHorizontalRailEnabled\" Value=\"False\" /> " +
     "   <Setter Property=\"ScrollViewer.VerticalScrollMode\" Value=\"Enabled\" /> " +
     "   <Setter Property=\"ScrollViewer.IsVerticalRailEnabled\" Value=\"True\" /> " +
     "   <Setter Property=\"ScrollViewer.ZoomMode\" Value=\"Disabled\" /> " +
     "   <Setter Property=\"ScrollViewer.IsDeferredScrollingEnabled\" Value=\"False\" /> " +
     "   <Setter Property=\"ScrollViewer.BringIntoViewOnFocusChange\" Value=\"True\" />  " +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"ItemContainerTransitions\"> " +
     " <Setter.Value>" +
     "  <TransitionCollection>" +
     "   <AddDeleteThemeTransition />" +
     "   <ContentThemeTransition />  " +
     "   <ReorderThemeTransition />  " +
     "   <EntranceThemeTransition IsStaggeringEnabled=\"False\" />" +
     "  </TransitionCollection>  " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "   <Setter Property=\"ItemsPanel\">" +
     " <Setter.Value>" +
     "  <ItemsPanelTemplate>  " +
     "   <ItemsStackPanel Orientation=\"Vertical\" /> " +
     "  </ItemsPanelTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"ListView\"> " +
     "   <Border Background=\"{TemplateBinding Background}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\"> " +
     " <ScrollViewer x:Name=\"ScrollViewer\" AutomationProperties.AccessibilityView=\"Raw\" BringIntoViewOnFocusChange=\"{TemplateBinding ScrollViewer.BringIntoViewOnFocusChange}\" HorizontalScrollBarVisibility=\"{TemplateBinding ScrollViewer.HorizontalScrollBarVisibility}\" HorizontalScrollMode=\"{TemplateBinding ScrollViewer.HorizontalScrollMode}\" IsDeferredScrollingEnabled=\"{TemplateBinding ScrollViewer.IsDeferredScrollingEnabled}\" IsVerticalScrollChainingEnabled=\"{TemplateBinding ScrollViewer.IsVerticalScrollChainingEnabled}\" IsHorizontalRailEnabled=\"{TemplateBinding ScrollViewer.IsHorizontalRailEnabled}\" IsVerticalRailEnabled=\"{TemplateBinding ScrollViewer.IsVerticalRailEnabled}\" IsHorizontalScrollChainingEnabled=\"{TemplateBinding ScrollViewer.IsHorizontalScrollChainingEnabled}\" TabNavigation=\"{TemplateBinding TabNavigation}\" VerticalScrollMode=\"{TemplateBinding ScrollViewer.VerticalScrollMode}\" VerticalScrollBarVisibility=\"{TemplateBinding ScrollViewer.VerticalScrollBarVisibility}\" ZoomMode=\"{TemplateBinding ScrollViewer.ZoomMode}\">  " +
     "  <ItemsPresenter Footer=\"{TemplateBinding Footer}\" FooterTransitions=\"{TemplateBinding FooterTransitions}\" FooterTemplate=\"{TemplateBinding FooterTemplate}\" Header=\"{TemplateBinding Header}\" HeaderTransitions=\"{TemplateBinding HeaderTransitions}\" HeaderTemplate=\"{TemplateBinding HeaderTemplate}\" Padding=\"{TemplateBinding Padding}\" /> " +
     " </ScrollViewer>  " +
     "   </Border>" +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <Style TargetType=\"CheckBox\">  " +
     "   <Setter Property=\"Background\" Value=\"{ThemeResource CheckBoxBackgroundUnchecked}\" /> " +
     "   <Setter Property=\"Foreground\" Value=\"{ThemeResource CheckBoxForegroundUnchecked}\" /> " +
     "   <Setter Property=\"BorderBrush\" Value=\"{ThemeResource SystemControlBackgroundListMediumRevealBorderBrush}\" /> " +
     "   <Setter Property=\"Padding\" Value=\"8,5,0,0\" /> " +
     "   <Setter Property=\"HorizontalAlignment\" Value=\"Left\" /> " +
     "   <Setter Property=\"VerticalAlignment\" Value=\"Center\" /> " +
     "   <Setter Property=\"HorizontalContentAlignment\" Value=\"Left\" />" +
     "   <Setter Property=\"VerticalContentAlignment\" Value=\"Top\" />" +
     "   <Setter Property=\"FontFamily\" Value=\"{ThemeResource ContentControlThemeFontFamily}\" />  " +
     "   <Setter Property=\"FontSize\" Value=\"{ThemeResource ControlContentThemeFontSize}\" />" +
     "   <Setter Property=\"MinWidth\" Value=\"120\" /> " +
     "   <Setter Property=\"MinHeight\" Value=\"32\" /> " +
     "   <Setter Property=\"UseSystemFocusVisuals\" Value=\"True\" />  " +
     "   <Setter Property=\"FocusVisualMargin\" Value=\"-7,-3,-7,-3\" />  " +
     "   <Setter Property=\"Template\">  " +
     " <Setter.Value>" +
     "  <ControlTemplate TargetType=\"CheckBox\"> " +
     "   <Grid x:Name=\"RootGrid\" Background=\"{TemplateBinding Background}\" BorderThickness=\"{TemplateBinding BorderThickness}\" BorderBrush=\"{TemplateBinding BorderBrush}\">" +
     " <Grid.ColumnDefinitions>  " +
     "  <ColumnDefinition Width=\"20\" /> " +
     "  <ColumnDefinition Width=\"*\" />  " +
     " </Grid.ColumnDefinitions> " +
     " <VisualStateManager.VisualStateGroups>" +
     "  <VisualStateGroup x:Name=\"CombinedStates\"> " +
     "   <VisualState x:Name=\"UncheckedNormal\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUnchecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUnchecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUnchecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUnchecked}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUnchecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUnchecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"10\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"UncheckedPointerOver\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUncheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUncheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUncheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUncheckedPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUncheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUncheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"10\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"UncheckedPressed\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUncheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUncheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUncheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUncheckedPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUncheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUncheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"StrokeThickness\" To=\"{ThemeResource CheckBoxCheckedStrokeThickness}\" />  " +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"10\" />  " +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"UncheckedDisabled\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundUncheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundUncheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushUncheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeUncheckedDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillUncheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundUncheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedNormal\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundChecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundChecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushChecked}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeChecked}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillChecked}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundChecked}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"StrokeThickness\" To=\"{ThemeResource CheckBoxCheckedStrokeThickness}\" />  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"10\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedPointerOver\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundCheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundCheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushCheckedPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeCheckedPointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillCheckedPointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundCheckedPointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"10\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedPressed\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundCheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundCheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushCheckedPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeCheckedPressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillCheckedPressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundCheckedPressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"StrokeThickness\" To=\"{ThemeResource CheckBoxCheckedStrokeThickness}\" />  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"10\" />  " +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"CheckedDisabled\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundCheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundCheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushCheckedDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeCheckedDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillCheckedDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundCheckedDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminateNormal\">" +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminate}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminate}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminate}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminate}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminate}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminate}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"10\" To=\"0\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminatePointerOver\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminatePointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminatePointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminatePointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminatePointerOver}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminatePointerOver}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminatePointerOver}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     "  <DoubleAnimation Storyboard.TargetProperty=\"BlurRadius\" Storyboard.TargetName=\"Shadow\" Duration=\"0:0:0.25\" From=\"0\" To=\"10\" EnableDependentAnimation=\"True\" />" +
     " </Storyboard> " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminatePressed\">  " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminatePressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminatePressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminatePressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminatePressed}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminatePressed}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminatePressed}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"10\" />  " +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "   <VisualState x:Name=\"IndeterminateDisabled\"> " +
     " <Storyboard>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"ContentPresenter\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxForegroundIndeterminateDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"Background\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBackgroundIndeterminateDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"RootGrid\" Storyboard.TargetProperty=\"BorderBrush\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxBorderBrushIndeterminateDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Stroke\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundStrokeIndeterminateDisabled}\" />  " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"NormalRectangle\" Storyboard.TargetProperty=\"Fill\">  " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckBackgroundFillIndeterminateDisabled}\" /> " +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Foreground\"> " +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"{ThemeResource CheckBoxCheckGlyphForegroundIndeterminateDisabled}\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <ObjectAnimationUsingKeyFrames Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Glyph\">" +
     "   <DiscreteObjectKeyFrame KeyTime=\"0\" Value=\"&#xE73C;\" />" +
     "  </ObjectAnimationUsingKeyFrames>  " +
     "  <DoubleAnimation Duration=\"0\" Storyboard.TargetName=\"CheckGlyph\" Storyboard.TargetProperty=\"Opacity\" To=\"1\" />" +
     " </Storyboard> " +
     "  " +
     " <VisualState.Setters>  " +
     "  <Setter Target=\"Shadow.BlurRadius\" Value=\"0\" />" +
     " </VisualState.Setters> " +
     "  " +
     "   </VisualState> " +
     "  </VisualStateGroup>" +
     " </VisualStateManager.VisualStateGroups>  " +
     " <Grid Height=\"32\" VerticalAlignment=\"Top\">  " +
     "  " +
     "  <Tools:DropShadowPanel x:Name=\"Shadow\"" +
     " BlurRadius=\"15\" " +
     " Color=\"Black\"" +
     " Height=\"20\"  " +
     " Width=\"20\"" +
     " ShadowOpacity=\".5\" " +
     " OffsetX=\"0\"  " +
     " OffsetY=\".0\" " +
     " HorizontalContentAlignment=\"Stretch\" " +
     " VerticalContentAlignment=\"Stretch\"" +
     " Style=\"{StaticResource ShadowMenu}\">" +
     "  " +
     "   <Grid x:Name=\"BackgroundLayer\" Height=\"20\" Width=\"20\" Background=\"{ThemeResource SystemControlAcrylicWindowBrush}\">  " +
     " <Rectangle x:Name=\"NormalRectangle\" Fill=\"{ThemeResource CheckBoxCheckBackgroundFillUnchecked}\" Height=\"20\" StrokeThickness=\"{ThemeResource CheckBoxBorderThemeThickness}\" Stroke=\"{ThemeResource CheckBoxCheckBackgroundStrokeUnchecked}\" UseLayoutRounding=\"False\" Width=\"20\" />  " +
     "   </Grid>  " +
     "  </Tools:DropShadowPanel>  " +
     "  " +
     "  <FontIcon x:Name=\"CheckGlyph\" FontFamily=\"{ThemeResource SymbolThemeFontFamily}\" Foreground=\"{ThemeResource CheckBoxCheckGlyphForegroundUnchecked}\" FontSize=\"20\" Glyph=\"&#xE001;\" Opacity=\"0\" />  " +
     " </Grid> " +
     " <ContentPresenter x:Name=\"ContentPresenter\" AutomationProperties.AccessibilityView=\"Raw\" ContentTemplate=\"{TemplateBinding ContentTemplate}\" Content=\"{TemplateBinding Content}\" ContentTransitions=\"{TemplateBinding ContentTransitions}\" Grid.Column=\"1\" HorizontalAlignment=\"{TemplateBinding HorizontalContentAlignment}\" Margin=\"{TemplateBinding Padding}\" TextWrapping=\"Wrap\" VerticalAlignment=\"{TemplateBinding VerticalContentAlignment}\" />" +
     "   </Grid>  " +
     "  </ControlTemplate> " +
     " </Setter.Value>  " +
     "   </Setter>" +
     "  </Style>  " +
     "  " +
     "  <ResourceDictionary.ThemeDictionaries>  " +
     "  " +
     "   <ResourceDictionary x:Key=\"Light\">  " +
     "  " +
     " <SolidColorBrush x:Key=\"CustomColorBrush\" Color=\"{StaticResource CustomColor}\" />" +
     " <SolidColorBrush x:Key=\"ContrastColorBrush\" Color=\"{StaticResource ContrastColor}\" />  " +
     " <SolidColorBrush x:Key=\"ContrastColorReverseBrush\" Color=\"{StaticResource ContrastColorReverse}\" />" +
     " <SolidColorBrush x:Key=\"ExtendedSplashBackground\" Color=\"{StaticResource CustomColor}\" /> " +
     " <SolidColorBrush x:Key=\"ExtendedSplashForeground\" Color=\"{StaticResource ContrastColor}\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"ButtonFilterGridHover\" Color=\"#00000000\" />  " +
     "  " +
     " <Style TargetType=\"T10Controls:HamburgerMenu\"> " +
     "  <Setter Property=\"AccentColor\" Value=\"{StaticResource CustomColor}\" /> " +
     "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" />  " +
     "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" />  " +
     "  <Setter Property=\"VisualStateWideMinWidth\" Value=\"{StaticResource WideMinWidth}\" />" +
     "  <Setter Property=\"NavButtonForeground\" Value=\"{StaticResource ContrastColorReverseBrush}\" />" +
     " </Style>" +
     "  " +
     " <Style TargetType=\"T10Controls:PageHeader\"> " +
     "  <Setter Property=\"Background\" Value=\"{ThemeResource CustomColorBrush}\" /> " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
     "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" />  " +
     "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" />  " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"AppBarButton\">  " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"AppBarSeparator\">  " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"T10Controls:Resizer\"> " +
     "  <Setter Property=\"GrabberBrush\" Value=\"{ThemeResource CustomColorBrush}\" />  " +
     "  <Setter Property=\"GrabberVisibility\" Value=\"Visible\" /> " +
     " </Style>" +
     "  " +
     " <AcrylicBrush x:Key=\"NavigationViewExpandedPaneBackground\"  " +
     "   BackgroundSource=\"HostBackdrop\" " +
     "   TintColor=\"#FFFFFFFF\"  " +
     "   TintOpacity=\"0.4\"" +
     "   FallbackColor=\"#FFCCCCCC\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicSoft\"" +
     "   BackgroundSource=\"HostBackdrop\" " +
     "   TintColor=\"#FFFFFFFF\"  " +
     "   TintOpacity=\"0.4\"" +
     "   FallbackColor=\"#FFCCCCCC\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicFull\"" +
     "   BackgroundSource=\"HostBackdrop\" " +
     "   TintColor=\"#FFFFFFFF\"  " +
     "   TintOpacity=\"1\"  " +
     "   FallbackColor=\"#FFA0A0A0\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicInAppSoft\" " +
     "   BackgroundSource=\"Backdrop\"  " +
     "   TintColor=\"#FFFFFFFF\"  " +
     "   TintOpacity=\"0.4\"" +
     "   FallbackColor=\"#FFA0A0A0\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicInAppMedium\"  " +
     "   BackgroundSource=\"Backdrop\"  " +
     "   TintColor=\"#FFFFFFFF\"  " +
     "   TintOpacity=\"0.6\"" +
     "   FallbackColor=\"#FFA0A0A0\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicInAppHard\" " +
     "   BackgroundSource=\"Backdrop\"  " +
     "   TintColor=\"#FFFFFFFF\"  " +
     "   TintOpacity=\"0.8\"" +
     "   FallbackColor=\"#FFA0A0A0\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarBackgroundThemeBrush\" " +
     "   Color=\"#FF171717\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarPressedBackgroundThemeBrush\"" +
     "   Color=\"DarkGray\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarHoverBackgroundThemeBrush\"  " +
     "   Color=\"Gray\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarForegroundThemeBrush\" " +
     "   Color=\"Black\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarButtonHoverThemeBrush\"" +
     "   Color=\"#FF343434\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarButtonPressedThemeBrush\" " +
     "   Color=\"#FF4C4C4C\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"DarkNoteBrush\" " +
     "   Color=\"{StaticResource DarkNote}\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"LightNoteBrush\"" +
     "   Color=\"{StaticResource LightNote}\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"DetailPartHeader\" " +
     "   Color=\"#FF686868\" />" +
     "  " +
     "   </ResourceDictionary>" +
     "  " +
     "   <ResourceDictionary x:Key=\"Default\">" +
     "  " +
     " <SolidColorBrush x:Key=\"CustomColorBrush\" Color=\"{StaticResource CustomColor}\" />" +
     " <SolidColorBrush x:Key=\"ContrastColorBrush\" Color=\"{StaticResource ContrastColorReverse}\" /> " +
     " <SolidColorBrush x:Key=\"ContrastColorReverseBrush\" Color=\"{StaticResource ContrastColor}\" /> " +
     " <SolidColorBrush x:Key=\"ExtendedSplashBackground\" Color=\"{StaticResource CustomColor}\" /> " +
     " <SolidColorBrush x:Key=\"ExtendedSplashForeground\" Color=\"{StaticResource ContrastColor}\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"ButtonFilterGridHover\" Color=\"#66000000\" />  " +
     "  " +
     " <Style TargetType=\"T10Controls:HamburgerMenu\"> " +
     "  " +
     "  <!-- " +
     "  " +
     "  Windows 10 2015 (1511) Hamburger Menu Style  " +
     "  Simply replace AccentColor with the follow setters." +
     "  " +
     "  <Setter Property=\"HamburgerBackground\" Value=\"{StaticResource CustomColorBrush}\" /> " +
     "  <Setter Property=\"HamburgerForeground\" Value=\"White\" /> " +
     "  <Setter Property=\"NavAreaBackground\" Value=\"#FF2C2C2C\" />  " +
     "  <Setter Property=\"NavButtonForeground\" Value=\"White\" /> " +
     "  <Setter Property=\"NavButtonBackground\" Value=\"Transparent\" /> " +
     "  <Setter Property=\"NavButtonHoverForeground\" Value=\"White\" />  " +
     "  <Setter Property=\"NavButtonHoverBackground\" Value=\"#FF585858\" /> " +
     "  <Setter Property=\"NavButtonPressedForeground\" Value=\"White\" />" +
     "  <Setter Property=\"NavButtonPressedBackground\" Value=\"#FF848484\" />  " +
     "  <Setter Property=\"NavButtonCheckedForeground\" Value=\"White\" />" +
     "  <Setter Property=\"NavButtonCheckedBackground\" Value=\"#FF2A4E6C\" />  " +
     "  <Setter Property=\"NavButtonCheckedIndicatorBrush\" Value=\"Transparent\" />  " +
     "  " +
     "  -->" +
     "  " +
     "  <Setter Property=\"AccentColor\" Value=\"{StaticResource CustomColor}\" /> " +
     "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" />  " +
     "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" />  " +
     "  <Setter Property=\"VisualStateWideMinWidth\" Value=\"{StaticResource WideMinWidth}\" />" +
     "  <Setter Property=\"NavButtonForeground\" Value=\"{StaticResource ContrastColorReverseBrush}\" />" +
     " </Style>" +
     "  " +
     " <Style TargetType=\"T10Controls:PageHeader\"> " +
     "  <Setter Property=\"Background\" Value=\"{ThemeResource CustomColorBrush}\" /> " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
     "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{StaticResource NarrowMinWidth}\" />  " +
     "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{StaticResource NormalMinWidth}\" />  " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"AppBarButton\">  " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"AppBarSeparator\">  " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorReverseBrush}\" /> " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"T10Controls:Resizer\"> " +
     "  <Setter Property=\"GrabberBrush\" Value=\"{ThemeResource CustomColorBrush}\" />  " +
     "  <Setter Property=\"GrabberVisibility\" Value=\"Visible\" /> " +
     " </Style>" +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicSoft\"" +
     "   BackgroundSource=\"HostBackdrop\" " +
     "   TintColor=\"#FF000000\"  " +
     "   TintOpacity=\"0.4\"" +
     "   FallbackColor=\"#FFCCCCCC\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicInAppSoft\" " +
     "   BackgroundSource=\"Backdrop\"  " +
     "   TintColor=\"#FF000000\"  " +
     "   TintOpacity=\"0.4\"" +
     "   FallbackColor=\"#FF202020\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicInAppMedium\"  " +
     "   BackgroundSource=\"Backdrop\"  " +
     "   TintColor=\"#FF000000\"  " +
     "   TintOpacity=\"0.6\"" +
     "   FallbackColor=\"#FF202020\" /> " +
     "  " +
     " <AcrylicBrush x:Key=\"AcrylicInAppHard\" " +
     "   BackgroundSource=\"Backdrop\"  " +
     "   TintColor=\"#FF000000\"  " +
     "   TintOpacity=\"0.8\"" +
     "   FallbackColor=\"#FF202020\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarBackgroundThemeBrush\" " +
     "   Color=\"#FF171717\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarForegroundThemeBrush\" " +
     "   Color=\"White\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarButtonHoverThemeBrush\"" +
     "   Color=\"#FF343434\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarButtonPressedThemeBrush\" " +
     "   Color=\"#FF4C4C4C\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarPressedBackgroundThemeBrush\"" +
     "   Color=\"Gray\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarHoverBackgroundThemeBrush\"  " +
     "   Color=\"DarkGray\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"DarkNoteBrush\" " +
     "   Color=\"{StaticResource LightNote}\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"LightNoteBrush\"" +
     "   Color=\"{StaticResource DarkNote}\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"DetailPartHeader\" " +
     "   Color=\"#FFA8A8A8\" />" +
     "  " +
     "   </ResourceDictionary>" +
     "  " +
     "   <ResourceDictionary x:Key=\"HighContrast\"> " +
     "  " +
     " <SolidColorBrush x:Key=\"ExtendedSplashBackground\" Color=\"Black\" />" +
     " <SolidColorBrush x:Key=\"ExtendedSplashForeground\" Color=\"White\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"ButtonFilterGridHover\" Color=\"#66000000\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"AcrylicSoft\"" +
     "   Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"AcrylicInAppSoft\" " +
     "   Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"AcrylicInAppMedium\"  " +
     "   Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"AcrylicInAppHard\" " +
     "   Color=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  " +
     " <Style TargetType=\"T10Controls:HamburgerMenu\"> " +
     "  <Setter Property=\"PaneBorderThickness\" Value=\"0\" />  " +
     "  <Setter Property=\"SecondarySeparator\" Value=\"{ThemeResource SystemColorWindowTextColor}\" /> " +
     "  <Setter Property=\"NavButtonBackground\" Value=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  <Setter Property=\"NavButtonForeground\" Value=\"{ThemeResource SystemColorWindowTextColor}\" />" +
     "  <Setter Property=\"NavAreaBackground\" Value=\"{ThemeResource SystemColorWindowColor}\" />" +
     "  <Setter Property=\"HamburgerForeground\" Value=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  <Setter Property=\"HamburgerBackground\" Value=\"{ThemeResource SystemColorWindowTextColor}\" />" +
     "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{ThemeResource NarrowMinWidth}\" />" +
     "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{ThemeResource NormalMinWidth}\" />" +
     "  <Setter Property=\"VisualStateWideMinWidth\" Value=\"{ThemeResource WideMinWidth}\" /> " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"T10Controls:PageHeader\"> " +
     "  <Setter Property=\"Background\" Value=\"{ThemeResource SystemColorWindowColor}\" /> " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource SystemColorWindowTextColor}\" />" +
     "  <Setter Property=\"VisualStateNarrowMinWidth\" Value=\"{ThemeResource NarrowMinWidth}\" />" +
     "  <Setter Property=\"VisualStateNormalMinWidth\" Value=\"{ThemeResource NormalMinWidth}\" />" +
     " </Style>" +
     "  " +
     " <Style TargetType=\"AppBarButton\">  " +
     "  <Setter Property=\"Background\" Value=\"{ThemeResource ContrastColorBrush}\" />  " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorBrush}\" />  " +
     " </Style>" +
     "  " +
     " <Style TargetType=\"AppBarSeparator\">  " +
     "  <Setter Property=\"Foreground\" Value=\"{ThemeResource ContrastColorBrush}\" />  " +
     " </Style>" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarBackgroundThemeBrush\" " +
     "   Color=\"Black\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarButtonHoverThemeBrush\"" +
     "   Color=\"#FF343434\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarButtonPressedThemeBrush\" " +
     "   Color=\"#FF4C4C4C\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarPressedBackgroundThemeBrush\"" +
     "   Color=\"LightGray\" />" +
     "  " +
     " <SolidColorBrush x:Key=\"TitleBarHoverBackgroundThemeBrush\"  " +
     "   Color=\"Gray\" />  " +
     "  " +
     " <SolidColorBrush x:Key=\"DarkNoteBrush\" " +
     "   Color=\"{StaticResource LightNote}\" /> " +
     "  " +
     " <SolidColorBrush x:Key=\"LightNoteBrush\"" +
     "   Color=\"{StaticResource DarkNote}\" />  " +
     "   </ResourceDictionary>" +
     "  " +
     "  </ResourceDictionary.ThemeDictionaries> " +
     "  " +
      " </ResourceDictionary>  ";

 }
}
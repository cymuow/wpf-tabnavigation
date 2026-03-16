using MahApps.Metro.Controls;

using Prism.Regions;

using WpfTabNavigation.Constants;

namespace WpfTabNavigation.Views;

public partial class ShellWindow : MetroWindow
{
    public ShellWindow(IRegionManager regionManager)
    {
        InitializeComponent();
        RegionManager.SetRegionName(shellContentControl, Regions.Main);
        RegionManager.SetRegionManager(shellContentControl, regionManager);
    }
}

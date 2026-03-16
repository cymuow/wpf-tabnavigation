using System.ComponentModel;
using System.Windows.Controls;

namespace WpfTabNavigation.Views;

public partial class MainPage : UserControl
{
    public MainPage(IRegionManager regionManager)
    {
        InitializeComponent();
        
        // ContentRegion에 ViewA와 ViewB를 미리 등록 (앱 실행 시 자동 생성됨)
        regionManager.RegisterViewWithRegion("tabContentRegion", typeof(ViewA));
        regionManager.RegisterViewWithRegion("tabContentRegion", typeof(ViewB));
        regionManager.RegisterViewWithRegion("tabContentRegion", typeof(ViewC));
    }
}

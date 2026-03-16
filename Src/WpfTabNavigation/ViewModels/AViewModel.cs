using System.Diagnostics;

namespace WpfTabNavigation.ViewModels;

public class AViewModel : BindableBase, IActiveAware
{
    private string _title = "View A";
    private bool _isActive = false;

    public string Title
    {
        get => _title;
    }

    public bool IsActive
    {
        get => _isActive;
        set
        {
            _isActive = value;
            if (_isActive)
            {
                OnTabActivated(); // 탭에 진입할 때
            }
            else
            {
                OnTabDeactivated(); // 탭에서 나갈 때 (해제 시)
            }
            OnIsActiveChanged();
        }
    }

    private void OnTabDeactivated()
    {
        Debug.WriteLine("View A 퇴거");
    }

    protected virtual void OnIsActiveChanged() => IsActiveChanged?.Invoke(this, EventArgs.Empty);

    private void OnTabActivated()
    {
        Debug.WriteLine("View A 진입");
    }

    public event EventHandler IsActiveChanged;
}

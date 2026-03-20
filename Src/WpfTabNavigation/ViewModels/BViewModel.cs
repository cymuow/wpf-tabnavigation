using System.Diagnostics;

namespace WpfTabNavigation.ViewModels;

public class BViewModel : BindableBase, IActiveAware
{
    private string _title = "View B";
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
            if (_isActive == value)
            {
                return; // 이 줄을 추가하면 불필요한 로직 실행을 막습니다.
            }

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
        Debug.WriteLine("View B 퇴장");
    }

    protected virtual void OnIsActiveChanged() => IsActiveChanged?.Invoke(this, EventArgs.Empty);

    private void OnTabActivated()
    {
        Debug.WriteLine("View B 진입");
    }

    public event EventHandler IsActiveChanged;
}

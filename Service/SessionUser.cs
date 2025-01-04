using MyFinanceHub.Model;

public class SessionUser
{
    private User _userLogin;

    public bool LoggedIn => _userLogin != null;

    public User UserLogin
    {
        get => _userLogin ?? throw new InvalidOperationException("No user is logged in.");
        set => _userLogin = value;
    }

    public void Logout()
    {
        _userLogin = null;
    }
}

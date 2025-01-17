using MyFinanceHub.Model;

public class SessionUser
{
    private User _userLogin;
    private string _selectedCurrency = "NPR"; // Default currency

    public bool LoggedIn => _userLogin != null;

    public User UserLogin
    {
        get => _userLogin ?? throw new InvalidOperationException("No user is logged in.");
        set => _userLogin = value;
    }

    public string SelectedCurrency
    {
        get => _selectedCurrency;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Currency cannot be null or empty.");
            _selectedCurrency = value;
        }
    }

    public void Logout()
    {
        _userLogin = null;
        _selectedCurrency = "NPR";
    }

    public void Login(User user, string selectedCurrency)
    {
        UserLogin = user;
        SelectedCurrency = selectedCurrency;
    }
}

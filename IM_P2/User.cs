namespace IM_P2;

public class User
{
    private string _username;

    private string _password;

    public User(string username, string password)
    {
        _username = username;
    }

    public string Username => _username;
}
namespace IM_P2;

public class User
{
    public string _username;

    public string _password;

    public User(string username, string password)
    {
        _username = username;
    }

    public string Username => _username;
}
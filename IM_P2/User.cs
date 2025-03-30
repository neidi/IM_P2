namespace IM_P2;

public class User
{
    private string _password;

    public User(string username, string password)
    {
        Username = username;
        _password = password;
    }

    public string Username { get; }
}
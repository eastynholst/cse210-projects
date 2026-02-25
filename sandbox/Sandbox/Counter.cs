using System.Security.Cryptography.X509Certificates;

public class Message
{
    public string _message;
    public int _priority;
    public string GetMessage()
    {
        return $"{_priority}: {_message}";
    }

}
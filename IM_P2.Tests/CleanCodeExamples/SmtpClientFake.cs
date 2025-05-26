using System.Net.Mail;
using IM_P2.CleanCodeExamples;

namespace IM_P2.Tests.CleanCodeExamples;

public class SmtpClientFake : ISmtpClient
{
    private readonly List<MailMessage> _messages = new();

    public IReadOnlyCollection<MailMessage> Messages => _messages.ToArray();

    public void Send(MailMessage message)
    {
        _messages.Add(message);
    }
}
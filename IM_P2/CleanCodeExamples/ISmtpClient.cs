using System.Net.Mail;

namespace IM_P2.CleanCodeExamples;

public interface ISmtpClient

{
    void Send(MailMessage message);
}
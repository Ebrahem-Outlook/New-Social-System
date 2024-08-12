namespace Social.Application.Core.Abstractions.Emails;

public interface IEmailService
{
    void SendEmailAsync(string from, string to, string body);
}

using Social.Application.Core.Abstractions.Emails;

namespace Social.Infrastructure.Emails;

internal class EmailService : IEmailService
{
    public void SendEmailAsync(string from, string to, string body)
    {
        throw new NotImplementedException();
    }
}
